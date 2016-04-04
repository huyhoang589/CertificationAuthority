using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Utilities;
using System.Security.Cryptography.X509Certificates;
using DSGOST2012;
using HGOST2012;
using X509;
using X509.X509Name;
using X509.X509DateTime;
using X509.X509Extended;
using X509.Certificate;

namespace CA
{
    public partial class form_IssueRequest : Form
    {
        public form_IssueRequest()
        {
            InitializeComponent();
        }

        private X509Certificate x509cert, request;
        private ByteArrayList privKey;
        private string sPrivKeyFilename, sOutputFilename, certSerial;
        private int keyUsageValue;
        private bool checkKey;
        public static bool issueConfirm ;

        private void form_IssueRequest_Load(object sender, EventArgs e)
        {
            issueConfirm = false;
            privKey = new ByteArrayList();
            
            request = X509Certificate.CreateFromCertFile(form_mainCA.RequestName + ".CER");
            dtRequestFrom.Value = DateTime.Parse(request.GetEffectiveDateString());
            dtRequestTo.Value = DateTime.Parse(request.GetExpirationDateString());

            cbBoxCertPurpose.Enabled = true;
            keyUsageValue = 0;
            checkBox0.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
        }
                
        private void btnIssueNewCerts_Click(object sender, EventArgs e)
        {
            //-------------------------Check RootCA Cert-------------------------
            string[] fileList = Directory.GetFiles(form_mainCA.rootCA);
            int countCert = 0;
            foreach (string fileName in fileList)
            {
                countCert = countCert + 1;
            }

            if (countCert > 1)
            {
                MessageBox.Show("Несколько корневых сертификатов присутствуют в хранилище.Выберите корневой сертификат. ", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                openRootCA.Filter = "Сертификат(*.CER)|*.CER*";
                openRootCA.DefaultExt = "CER";
                openRootCA.InitialDirectory = form_mainCA.rootCA;
                if (openRootCA.ShowDialog() == DialogResult.OK)
                {
                    string certName = openRootCA.FileName;
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
                if (fi.Extension == ".KEY")
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
                openPrivKey.Filter = "Файл Ключа(*.key)|*.key*";
                openPrivKey.DefaultExt = "key";
                openPrivKey.InitialDirectory = form_mainCA.pathKeyFolder;
                if (openPrivKey.ShowDialog() == DialogResult.OK)
                {
                    sPrivKeyFilename = openPrivKey.FileName;
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

                //----------------------------- ISSUER -----------------------------
                string str_iEmail, str_iOU, str_iO, str_iL, str_iST, str_iC, str_iCN;
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
                DateTime from = dtRequestFrom.Value;
                DateTime to = dtRequestTo.Value;
                UtcTime time = new UtcTime();
                time.set_ValidFrom(from);
                time.set_ValidTo(to);
                ByteArrayList tmp_DT = time.get_UtcTime();

                //----------------------------- SUBJECT -----------------------------
                string str_sEmail, str_sOU, str_sO, str_sL, str_sST, str_sC, str_sCN;
                getSubjectInfo requestInfo = new getSubjectInfo();
                requestInfo.set_Subject(request.Subject);
                str_sEmail = subInfo.get_E();
                str_sCN = subInfo.get_CN();
                str_sOU = subInfo.get_OU();
                str_sO = subInfo.get_O();
                str_sL = subInfo.get_L();
                str_sST = subInfo.get_ST();
                str_sC = subInfo.get_C();

                commonName sCN = new commonName();
                sCN.set_commonName(str_sCN);
                organizationName sO = new organizationName();
                sO.set_orgName(str_sO);
                organizationUnitName sOU = new organizationUnitName();
                sOU.set_OU(str_sOU);
                localName sL = new localName();
                sL.set_localName(str_sL);
                StateOfProvince sST = new StateOfProvince();
                sST.set_ST(str_sST);
                EmailAdress sEmail = new EmailAdress();
                sEmail.set_emailAdress(str_sEmail);
                countryName sC = new countryName();
                sC.set_countryName(str_sC);

                Subject Sub = new Subject();
                Sub.set_CN(sCN.get_commonName());
                Sub.set_O(sO.get_orgName());
                Sub.set_OU(sOU.get_OU());
                Sub.set_L(sL.get_localName());
                Sub.set_ST(sST.get_StateOfProvince());
                Sub.set_emailAdress(sEmail.get_emailAdress());
                Sub.set_C(sC.get_countryName());
                ByteArrayList tmp_Sub = Sub.get_Subject();

                //----------------------------- GOST KEY -----------------------------
                byte[] bytes_pubkeyIssuer = HexStringToByteArrayConverter.Convert(x509cert.GetPublicKeyString());
                //MessageBox.Show(bytes_pubkeyIssuer.Length + "\n" + x509cert.GetPublicKeyString());
                ByteArrayList pubkeyIssuer = new ByteArrayList();
                for(int i=3;i<bytes_pubkeyIssuer.Length ;i++)
                pubkeyIssuer.Add(bytes_pubkeyIssuer[i]);
                //MessageBox.Show(pubkeyIssuer.getSize().ToString());
                
                KeyGOST kgost = new KeyGOST();
                kgost.set_keyGOST(pubkeyIssuer);
                ByteArrayList tmp_keyGOST = kgost.get_KeyGOST();
                
                byte[] bytes_pubkeySubject = HexStringToByteArrayConverter.Convert(request.GetPublicKeyString());
                ByteArrayList pubkeySubject = new ByteArrayList();
                for (int j = 2; j < bytes_pubkeySubject.Length; j++)
                    pubkeySubject.Add(bytes_pubkeySubject[j]);

                //----------------------------- KEY USAGE -----------------------------
                KeyUsage kUsage = new KeyUsage();
                kUsage.set_keyUsageValue(keyUsageValue);
                ByteArrayList tmp_kU = kUsage.get_keyUsage();

                //----------------------------- SUBJECT KEY ID-----------------------------
                SubjectKeyID subKeyID = new SubjectKeyID();
                subKeyID.set_pubKey(pubkeySubject);
                ByteArrayList tmp_subKeyID = subKeyID.get_subKeyId();

                //----------------------------- AUTHOR KEY ID-----------------------------
                AuthorityKeyId auKeyID = new AuthorityKeyId();

                byte[] bytes_CaCertSerial = HexStringToByteArrayConverter.Convert(x509cert.GetSerialNumberString());
                ByteArrayList serialCaCert = new ByteArrayList();
                serialCaCert.Add(bytes_CaCertSerial);

                auKeyID.set_CAkey(pubkeyIssuer);
                auKeyID.set_IssuerInfo(tmp_Sub);
                auKeyID.set_seriaCAcert(serialCaCert);
                ByteArrayList tmp_auKeyID = auKeyID.get_AuthorityKeyId();

                //----------------------------- CRL POINT-----------------------------
                cRLPoint CRL = new cRLPoint();
                CRL.set_cRLPoint(form_CAConnect.caConnectCrlInfo);
                ByteArrayList tmp_CRL = CRL.get_cRLPoint();

                //----------------------------- AuInfoAccess-----------------------------
                authorityInfoAccess auInfo = new authorityInfoAccess();
                auInfo.set_auInfoAccess(form_CAConnect.caConnectCertInfo);
                ByteArrayList tmp_auInfo = auInfo.get_auInfoAccess();

                //----------------------------- X509 V3 Extended -----------------------------
                V3Extended V3ext = new V3Extended();
                V3ext.set_keyUsage(tmp_kU);
                V3ext.set_subjectKeyID(tmp_subKeyID);
                V3ext.set_authorKeyID(tmp_auKeyID);
                V3ext.set_cRLPoint(tmp_CRL);
                V3ext.set_auInfoAccess(tmp_auInfo);
                ByteArrayList tmp_V3ext = V3ext.get_V3Extended();

                //----------------------------- TBSCetificateGenerator -----------------------------
                TBSCerificateGenerator tbsCer = new TBSCerificateGenerator();
                tbsCer.set_Issuer(tmp_Iss);
                tbsCer.set_DateTime(tmp_DT);
                tbsCer.set_Subject(tmp_Sub);
                tbsCer.set_pubKey(tmp_keyGOST);
                tbsCer.set_Extended(tmp_V3ext);
                ByteArrayList tmp_tbsCert = tbsCer.get_tbsCertificate();
                certSerial = string.Copy(tbsCer.get_Serial());

                //----------------------------- DIGITAL SIGNATURE -----------------------------
                Signer sign = new Signer("gost341012paramseta");
                ByteArrayList sign_out = sign.genSign(tmp_tbsCert, privKey);

                //----------------------------- SIGNATURE VALUE -----------------------------
                SignValue X509Sign = new SignValue();
                X509Sign.set_SignOut(sign_out);
                X509Sign.set_CheckSign(true);   // checkSign
                ByteArrayList tmp_X509Sign = X509Sign.get_Signature();

                //----------------------------- ALGORITHM SIGNATURE -----------------------------
                string str_algsingcert = "gost341012withgost341112";
                AlgorithmSignCert alg = new AlgorithmSignCert();
                alg.set_AlgSignCert(str_algsingcert);
                ByteArrayList tmp_AlgSignCert = alg.get_AlgSignCert();

                //----------------------------- X509 V3 CertificateGenerator -----------------------------
                X509V3CertificateGenerator gen = new X509V3CertificateGenerator();
                gen.set_tsbCert(tmp_tbsCert);
                gen.set_AlgSignCert(tmp_AlgSignCert);
                gen.set_Signature(tmp_X509Sign);
                ByteArrayList V3cert = gen.get_V3Certificate();
                byte[] tmp_Certificate = V3cert.getArray();
                
                //Записывать выданный Сертификат
                FileStream stream = new FileStream(sOutputFilename + certSerial + ".CER", FileMode.Create);
                BinaryWriter bWriter = new BinaryWriter(stream);
                bWriter.Write(tmp_Certificate, 0, V3cert.getSize());
                bWriter.Flush();
                bWriter.Close();
                issueConfirm = true;
                
                MessageBox.Show("Сертификат выдал успешно !", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnIssueCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //----------------------- Назначения Сертификатов -----------------------
        private void checkBox0_CheckedChanged(object sender, EventArgs e)   // цифровая подпись
        {
            keyUsageValue = keyUsageValue + 128;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)    // Неотрекаемость		
        {
            keyUsageValue = keyUsageValue + 64;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)    // Шифрование Ключей
        {
            keyUsageValue = keyUsageValue + 32;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)    // Шифрование Данных
        {
            keyUsageValue = keyUsageValue + 16;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)     // Согласование Ключей
        {
            keyUsageValue = keyUsageValue + 8;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)     // Подписывание сертификатов
        {
            keyUsageValue = keyUsageValue + 4;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)     // Подписывание СОС
        {
            keyUsageValue = keyUsageValue + 2;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)     // Только зашифровывать
        {
            keyUsageValue = keyUsageValue + 1;
        }

        private void cbBoxCertPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyUsageValue = 0;
            checkBox0.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;

            // Удостоверяющий Центр
            if (cbBoxCertPurpose.SelectedIndex == 0)
            {
                checkBox0.Enabled = true;
                checkBox1.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;

                checkBox0.Checked = true;
                checkBox1.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;

                sOutputFilename = form_mainCA.ActivateCerts;
            }

            // Подпись и шифрование
            if (cbBoxCertPurpose.SelectedIndex == 1)
            {
                checkBox0.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;

                checkBox0.Checked = true;
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;

                sOutputFilename = form_mainCA.ActivateCerts;
            }

            // Только Подпись
            if (cbBoxCertPurpose.SelectedIndex == 2)
            {
                checkBox0.Enabled = true;
                checkBox1.Enabled = true;

                checkBox0.Checked = true;
                checkBox1.Checked = true;

                sOutputFilename = form_mainCA.ActivateCerts;
            }

            // Прочие варианты
            if (cbBoxCertPurpose.SelectedIndex == 3)
            {
                checkBox0.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;

                sOutputFilename = form_mainCA.ActivateCerts;
            }
        }

    }
}
