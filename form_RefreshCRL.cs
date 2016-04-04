using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using X509;
using X509.CRL;
using X509.CRLExtended;
using X509.X509Name;
using X509.Certificate;
using Utilities;

namespace CA
{
    public partial class form_RefreshCRL : Form
    {
        public form_RefreshCRL()
        {
            InitializeComponent();
        }

        private bool checkKey;
        private static DateTime dataNextRefreshCRL;
        private static DateTime dataPublicCRL;
        private X509Certificate x509cert;
        private ByteArrayList privKey, crlList;
        private string sPrivKeyFilename, str_iCN;

        private void form_RefreshCRL_Load(object sender, EventArgs e)
        {
            labelCRLTime.Text = DateTime.Now.ToUniversalTime().ToString();
            privKey = new ByteArrayList();
            crlList = new ByteArrayList();
        }

        private void bntRefreshCRLOK_Click(object sender, EventArgs e)
        {
            //-------------------------Check RootCA Cert-------------------------
            string[] fileList = Directory.GetFiles(form_mainCA.rootCA);
            int countCert =0;
            foreach (string fileName in fileList)
            {
                countCert = countCert + 1;
            }
           
            if (countCert > 1)
            {
                MessageBox.Show("Несколько корневых сертификатов присутствуют в хранилище.Выберите корневой сертификат. ", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openRootCACert.Filter = "Сертификат(*.CER)|*.CER*";
                openRootCACert.DefaultExt = "CER";
                openRootCACert.InitialDirectory = form_mainCA.rootCA;
                if (openRootCACert.ShowDialog() == DialogResult.OK)
                {
                    string certName = openRootCACert.FileName;
                    x509cert = X509Certificate.CreateFromCertFile(certName);
                }
            }

            if (countCert == 1)
            {
                foreach (string certName in fileList)
                    x509cert = X509Certificate.CreateFromCertFile(certName);
            }

            if (countCert == 0)
            {
                MessageBox.Show("Корневой сертификат отсутствует. Необходимо его создать.", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                form_mainCA.selfSignCert = true;
                form_mainCA.certRequest = false;
                form_createCerts creatCert = new form_createCerts();
                form_mainCA.selfSignCert = true;
                creatCert.ShowDialog();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            //-------------------------Check Key-------------------------
            checkKey = false;
            string[] fileList1 = Directory.GetFiles(form_mainCA.pathKeyFolder);
            int countKey = 0;
            foreach (string fileName in fileList1)
            {
                FileInfo fi = new FileInfo(fileName);
                if(fi.Extension ==".KEY")
                    countKey = countKey + 1;
            }
            //MessageBox.Show(countKey.ToString());
            if (countKey != 0) checkKey = true;
            if (countKey == 1)
            {
                foreach (string fileName in fileList1)
                {
                    FileInfo fi = new FileInfo(fileName);
                    sPrivKeyFilename = fi.FullName;
                }
                //MessageBox.Show("Ключ " + sPrivKeyFilename + " загрузился !", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (countKey > 1)
            {
                MessageBox.Show("Несколько ключей присутствуют в каталоге ключевого носителя. Выберите ключ.", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openFilePrivKey.Filter = "Файл Ключа(*.key)|*.key*";
                openFilePrivKey.DefaultExt = "key";
                openFilePrivKey.InitialDirectory = form_mainCA.pathKeyFolder;
                if (openFilePrivKey.ShowDialog() == DialogResult.OK)
                {
                    sPrivKeyFilename = openFilePrivKey.FileName;
                    FileInfo fi = new FileInfo(sPrivKeyFilename);
                    MessageBox.Show("Ключ " + fi.Name + " загрузился !", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else checkKey = false;

            }

            if (checkKey == false)
            {
                MessageBox.Show("Нет ключа в каталоге ключевого носителя. Необходимо создать ключ.", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_generateKey fGenkey = new form_generateKey();
                fGenkey.ShowDialog();
            }

            if (checkKey == true)
            {
                //-----------------------------Load privKey------------------------
                privKey = new ByteArrayList();
                FileStream readKey = new FileStream(sPrivKeyFilename, FileMode.Open);
                BinaryReader bRead = new BinaryReader(readKey);
                int lenKey = (int)readKey.Length;
                byte[] bytes_privKey = bRead.ReadBytes(lenKey);
                privKey.Add(bytes_privKey);
                bRead.Close();

                //----------------------------- ALGORITHM SIGNATURE -----------------------------
                string str_algsingcert = "gost341012withgost341112";
                AlgorithmSignCert alg = new AlgorithmSignCert();
                alg.set_AlgSignCert(str_algsingcert);
                ByteArrayList tmp_AlgSignCert = alg.get_AlgSignCert();

                //----------------------------- ISSUER -----------------------------
                string str_iEmail, str_iOU, str_iO, str_iL, str_iST, str_iC;
                getSubjectInfo subInfo = new getSubjectInfo();
                subInfo.set_Subject(x509cert.Issuer);
                str_iEmail = subInfo.get_E();
                str_iCN = subInfo.get_CN();
                str_iOU = subInfo.get_OU();
                str_iO = subInfo.get_O();
                str_iL = subInfo.get_L();
                str_iST = subInfo.get_ST();
                str_iC = subInfo.get_C();

                commonName iCN = new commonName();
                iCN.set_commonName(str_iCN);
                organizationName iO = new organizationName();
                iO.set_orgName(str_iO);
                organizationUnitName iOU = new organizationUnitName();
                iOU.set_OU(str_iOU);
                localName iL = new localName();
                iL.set_localName(str_iL);
                StateOfProvince iST = new StateOfProvince();
                iST.set_ST(str_iST);
                EmailAdress iEmail = new EmailAdress();
                iEmail.set_emailAdress(str_iEmail);
                countryName iC = new countryName();
                iC.set_countryName(str_iC);

                Issuer issuer = new Issuer();
                issuer.set_CN(iCN.get_commonName());
                issuer.set_O(iO.get_orgName());
                issuer.set_OU(iOU.get_OU());
                issuer.set_L(iL.get_localName());
                issuer.set_ST(iST.get_StateOfProvince());
                issuer.set_emailAdress(iEmail.get_emailAdress());
                issuer.set_C(iC.get_countryName());
                ByteArrayList tmp_Iss = issuer.get_Issuer();

                //----------------------------- DATE TIME -----------------------------
                dataNextRefreshCRL = NextRefreshCRLtimepicker.Value;
                dataPublicCRL = DateTime.Now.ToUniversalTime();

                //----------------------------- CRL content-----------------------------
                if (form_mainCA.reCRL == true)
                {
                    String[] line = File.ReadAllLines(form_mainCA.CRL + "CRL.txt");
                    int countCrl = 0;
                    foreach (String s in line) countCrl = countCrl + 1;
                                        
                    crlList = new ByteArrayList();
                    
                    foreach (String s in line)
                    {
                        String[] content = s.Split(new char[] { '#' });
                        string str_serial = string.Copy(content[0]);
                        string str_data = string.Copy(content[1]).Replace("-","").Replace(":","").Replace(" ","") +"Z";
                        string str_reason = string.Copy(content[2]);
                        
                        byte[] bytes_serial = HexStringToByteArrayConverter.Convert(str_serial);
                        byte[] bytes_data = Encoding.ASCII.GetBytes(str_data);

                        ObjectsId oID = new ObjectsId("crlreason");
                        ByteArrayList lID = oID.getID();
                        
                        ByteArrayList tmp = new ByteArrayList();
                        tmp.Add(0x30);  // SEQUENCE
                        tmp.Add(0x29);  // 41 bytes  
                        tmp.Add(0x02);  // INTEGER
                        tmp.Add(bytes_serial.Length);
                        tmp.Add(bytes_serial);  // SERIAL
                        tmp.Add(0x17);  // UTCTime
                        tmp.Add(0x0D);  // 13 bytes
                        tmp.Add(bytes_data);    // data revoke
                        tmp.Add(0x30);  // SEQUENCE
                        tmp.Add(0x0C);  // 12 bytes
                        tmp.Add(0x30);  // SEQUENCE
                        tmp.Add(0x0A);  // 10 bytes
                        tmp.Add(lID.getArray());    // OBJ ID
                        tmp.Add(0x04);  // OCTET STRING
                        tmp.Add(0x03);  // 3 bytes
                        tmp.Add(0x0A);  // ENUMERATED
                        tmp.Add(0x01);
                        if (str_reason == "Не указана") tmp.Add(0x00);
                        if (str_reason == "Компрометация ключа") tmp.Add(0x01);
                        if (str_reason == "Компрометация ЦС") tmp.Add(0x02);
                        if (str_reason == "Изменение принадлежности") tmp.Add(0x03);
                        if (str_reason == "Сертификат заменен") tmp.Add(0x04);
                        if (str_reason == "Прекращение работы") tmp.Add(0x05);
                        if (str_reason == "Приостановление действия") tmp.Add(0x06);

                        crlList.Add(tmp.getArray());

                    }

                }

                //----------------------------- CRL EXTENDED -----------------------------

                // CRLExt 1-CRLauID
                ByteArrayList caKEY = new ByteArrayList();
                caKEY.Add(x509cert.GetPublicKey());
                CRLauID crlAuID = new CRLauID();
                crlAuID.set_CAkey(caKEY);
                ByteArrayList tmp_crlAuID = crlAuID.get_CLRauID();

                // CRLExt 2-CAKeyCertIndexPair
                CAKeyCertIndexPair caKCI = new CAKeyCertIndexPair();
                caKCI.set_VersionCenterCert("01");
                ByteArrayList tmp_caKCI = caKCI.get_CAKeyCertIndexPair();

                // CRLExt 3-CRLNumber
                CRLNumber crlNum = new CRLNumber();
                ByteArrayList tmp_clrNum = crlNum.get_CRLNumber();

                // CRLExt 4-CRLNextPublish
                CRLNextPublish crlNextPub = new CRLNextPublish();
                crlNextPub.set_dateNextPublish(DateTime.Now);
                ByteArrayList tmp_crlNextPub = crlNextPub.get_cRLNextPublish();

                CRLExtend crlExt = new CRLExtend();
                crlExt.set_CRLauKeyID(tmp_crlAuID);
                crlExt.set_CAKeyCertIndexPair(tmp_caKCI);
                crlExt.set_CRLNextPublish(tmp_crlNextPub);
                ByteArrayList tmp_crlExt = crlExt.get_CLRExtended();

                //----------------------------- CertificatesRevocationList -----------------------------
                tbsCRLGenerator tbsCRL = new tbsCRLGenerator();
                tbsCRL.set_Issuer(tmp_Iss);
                tbsCRL.set_UTCTime(dataPublicCRL, dataNextRefreshCRL);
                if (form_mainCA.reCRL == true) tbsCRL.set_CRL(crlList);
                tbsCRL.set_CRLExtended(tmp_crlExt);
                ByteArrayList tmp_tbsCRL = tbsCRL.get_tbsCRL();

                Signer signCRL = new Signer("gost341012paramseta");
                ByteArrayList sign_outCRL = signCRL.genSign(tmp_tbsCRL, privKey);
                SignValue CRLSign = new SignValue();
                CRLSign.set_SignOut(sign_outCRL);
                CRLSign.set_CheckSign(true);   //checkSign
                ByteArrayList tmp_CRLSign = CRLSign.get_Signature();

                CertificatesRevocationList genCRL = new CertificatesRevocationList();
                genCRL.set_tsbCRL(tmp_tbsCRL);
                genCRL.set_AlgSignCert(tmp_AlgSignCert);
                genCRL.set_Signature(tmp_CRLSign);
                ByteArrayList CRLout = genCRL.get_CRL();
                

                //----------------------------- Записывать СОС-----------------------------
                string[] CrlList = Directory.GetFiles(form_mainCA.CRL);
                
                foreach (string fileName in CrlList)
                {
                    FileInfo fi = new FileInfo(fileName);
                    if (fi.Extension == ".CRL") File.Delete(fileName);
                }
                string sOutputFilename = form_mainCA.CRL + "CA_" + str_iCN + "_CRL" + ".CRL";
                byte[] bytes_CRL = CRLout.getArray();
                FileStream stream = new FileStream(sOutputFilename, FileMode.Create);
                BinaryWriter bWriter = new BinaryWriter(stream);
                bWriter.Write(bytes_CRL, 0, bytes_CRL.Length);
                bWriter.Close();

                // Write to crlList.txt
                StreamWriter sw = new StreamWriter(form_mainCA.CRL + "crlList.txt", false);
                sw.Write("CA_" + str_iCN + "_CRL" + "#");
                sw.Write(DateTime.Now.ToString());
                sw.WriteLine();
                sw.Close();

                if(form_mainCA.reCRL == true)
                    MessageBox.Show("СОС Обновил Успешно !", " Свведение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("СОС Сгенерировал Успешно !", " Свведение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void bntRefreshCRLCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
