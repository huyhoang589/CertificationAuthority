using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using X509;
using Utilities;
using DSGOST2012;
using HGOST2012;
using X509.X509Name;
using X509.X509DateTime;
using X509.X509Extended;
using X509.Certificate;

namespace CA
{
    public partial class form_createCerts : Form
    {
        public form_createCerts()
        {
            InitializeComponent();
        }

        private ByteArrayList privKey, tmp_V3ext, tmp_DT;
        private string str_iEmail, str_iCN, str_iO, str_iOU, str_iL, str_iST, str_iC;
        private string sPrivKeyFilename, sOutputFilename, certSerial;
        private int keyUsageValue;
 
        private void form_createCerts_Load(object sender, EventArgs e)
        {
            privKey = new ByteArrayList();
            tmp_V3ext = new ByteArrayList();
            tmp_DT = new ByteArrayList();

            comboBoxCertPurpose.Enabled = true;
            keyUsageValue = 0;
            checkBox0v128.Enabled = false;
            checkBox1v64.Enabled = false;
            checkBox2v32.Enabled = false;
            checkBox3v16.Enabled = false;
            checkBox4v8.Enabled = false;
            checkBox5v4.Enabled = false;
            checkBox6v2.Enabled = false;
            checkBox7v1.Enabled = false;
            checkBox8.Enabled = false;

            if (form_mainCA.selfSignCert == true)
            {
                comboBoxCertPurpose.SelectedIndex = 0;
                comboBoxCertPurpose.Enabled = false;

                checkBox0v128.Enabled = true;
                checkBox1v64.Enabled = true;
                checkBox5v4.Enabled = true;
                checkBox6v2.Enabled = true;

                checkBox0v128.Checked = true;
                checkBox1v64.Checked = true;
                checkBox5v4.Checked = true;
                checkBox6v2.Checked = true;

                sOutputFilename = form_mainCA.rootCA;
            }

            if (form_mainCA.certRequest == true)
            {
                sOutputFilename = form_mainCA.certsRequest;
                comboBoxCertPurpose.Visible = false;
                checkBox0v128.Visible = false;
                checkBox1v64.Visible = false;
                checkBox2v32.Visible = false;
                checkBox3v16.Visible = false;
                checkBox4v8.Visible = false;
                checkBox5v4.Visible = false;
                checkBox6v2.Visible = false;
                checkBox7v1.Visible = false;
                checkBox8.Visible = false;
                btnCreateNewCerts.Text = "Создать Запрос";
                groupBox3.Text = "Запрос на сертификат";
                this.Text = "Создание запроса на сертификат";
            }
            //MessageBox.Show(form_mainCA.selfSignCert.ToString());

           
        }

        //-----------------------CREATE CERTIFICATE--------------------------
        private void btnCreateNewCerts_Click(object sender, EventArgs e)
        {
            //-------------------------Check Key-------------------------
            bool checkKey = false;
            string[] fileList = Directory.GetFiles(form_mainCA.pathKeyFolder);
            int countFile = 0;
            foreach (string fileName in fileList)
            {
                countFile = countFile + 1;
            }
            if (countFile != 0) checkKey = true;
            if (countFile == 1)
            {
                sPrivKeyFilename = form_mainCA.pathKeyFolder + Path.GetFileName(fileList[0]).Trim();
                //MessageBox.Show("Ключ " + Path.GetFileName(fileList[0]).Trim() + " загрузился !", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (countFile > 1)
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

                //----------------------------- ISSUER -----------------------------
                
                if (form_mainCA.selfSignCert == true || form_mainCA.certRequest == true)
                {
                    str_iCN = txt_CN.Text;
                    str_iO = txt_O.Text;
                    str_iOU = txt_OU.Text;
                    str_iL = txt_L.Text;
                    str_iST = txt_ST.Text;
                    str_iEmail = txt_Email.Text;
                    str_iC = txt_C.Text;
                }

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
                DateTime from = dtValidFrom.Value;
                DateTime to = dtValidTo.Value;
                UtcTime time = new UtcTime();
                time.set_ValidFrom(from);
                time.set_ValidTo(to);
                tmp_DT = time.get_UtcTime();
               

                //----------------------------- SUBJECT -----------------------------
                string str_sCN = txt_CN.Text;
                string str_sO = txt_O.Text;
                string str_sOU = txt_OU.Text;
                string str_sL = txt_L.Text;
                string str_sST = txt_ST.Text;
                string str_sEmail = txt_Email.Text;
                string str_sC = txt_C.Text;

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
                GetKeyPairGenerator pubKeygen = new GetKeyPairGenerator("gost341012paramseta");
                pubKeygen.set_privKey(privKey);
                ByteArrayList pubKey = pubKeygen.get_PublicKey();
                //MessageBox.Show(pubKey.getSize().ToString());

                KeyGOST kgost = new KeyGOST();
                kgost.set_keyGOST(pubKey);
                ByteArrayList tmp_keyGOST = kgost.get_KeyGOST();

                if (form_mainCA.selfSignCert == true)
                {
                    //----------------------------- KEY USAGE -----------------------------
                    KeyUsage kUsage = new KeyUsage();
                    kUsage.set_keyUsageValue(keyUsageValue);
                    ByteArrayList tmp_kU = kUsage.get_keyUsage();

                    //----------------------------- SUBJECT KEY ID-----------------------------
                    SubjectKeyID subKeyID = new SubjectKeyID();
                    subKeyID.set_pubKey(pubKey);
                    ByteArrayList tmp_subKeyID = subKeyID.get_subKeyId();

                    //----------------------------- X509 V3 Extended -----------------------------
                    V3Extended V3ext = new V3Extended();
                    V3ext.set_keyUsage(tmp_kU);
                    V3ext.set_subjectKeyID(tmp_subKeyID);
                    tmp_V3ext = V3ext.get_V3Extended();
                }

                //----------------------------- TBSCetificateGenerator -----------------------------
                TBSCerificateGenerator tbsCer = new TBSCerificateGenerator();
                tbsCer.set_Issuer(tmp_Iss);
                tbsCer.set_DateTime(tmp_DT);
                tbsCer.set_Subject(tmp_Sub);
                tbsCer.set_pubKey(tmp_keyGOST);
                if(form_mainCA.selfSignCert== true) tbsCer.set_Extended(tmp_V3ext);
                ByteArrayList tmp_tbsCert = tbsCer.get_tbsCertificate();
                certSerial = string.Copy(tbsCer.get_Serial());

                //----------------------------- DIGITAL SIGNATURE -----------------------------
                Signer sign = new Signer("gost341012paramseta");
                ByteArrayList sign_out = sign.genSign(tmp_tbsCert, privKey);
                //bool checkSign = sign.verifySign(tmp_tbsCert, sign_out, pubKey);

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

                //Записывать самоподписанный Сертификат

                if (form_mainCA.selfSignCert == true)
                {
                    FileStream stream = new FileStream(sOutputFilename + certSerial + ".CER", FileMode.Create);
                    BinaryWriter bWriter = new BinaryWriter(stream);
                    bWriter.Write(tmp_Certificate, 0, V3cert.getSize());
                    bWriter.Flush();
                    bWriter.Close();

                    MessageBox.Show("Сертификат создал успешно !", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Записывать Запрос на Сертификат
                if (form_mainCA.certRequest == true)
                {
                    string[] requestList = Directory.GetFiles(form_mainCA.certsRequest);
                    int countRequest = 0;
                    foreach (string fileName in requestList)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        if(fi.Extension == ".CER")
                              countRequest = countRequest +1;
                    }

                    FileStream stream = new FileStream(sOutputFilename + "Запрос" + countRequest.ToString() + ".CER", FileMode.Create);
                    BinaryWriter bWriter = new BinaryWriter(stream);
                    bWriter.Write(tmp_Certificate, 0, V3cert.getSize());
                    bWriter.Flush();
                    bWriter.Close();

                    // Write to Request.txt
                    StreamWriter sw = new StreamWriter(sOutputFilename + "Request.txt", true);
                    sw.Write("Запрос" + countRequest.ToString() + "#");
                    sw.Write(DateTime.Now.ToString());
                    sw.WriteLine();
                    sw.Close();

                    MessageBox.Show("Запрос на сертификат создал успешно !", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        //----------------------- Назначения Сертификатов -----------------------
        private void checkBox0v128_CheckedChanged(object sender, EventArgs e)   // цифровая подпись
        {
            keyUsageValue = keyUsageValue + 128;
        }

        private void checkBox1v64_CheckedChanged(object sender, EventArgs e)    // Неотрекаемость		
        {
            keyUsageValue = keyUsageValue + 64;
        }

        private void checkBox2v32_CheckedChanged(object sender, EventArgs e)    // Шифрование Ключей
        {
            keyUsageValue = keyUsageValue + 32;
        }

        private void checkBox3v16_CheckedChanged(object sender, EventArgs e)    // Шифрование Данных
        {
            keyUsageValue = keyUsageValue + 16;
        }

        private void checkBox4v8_CheckedChanged(object sender, EventArgs e)     // Согласование Ключей
        {
            keyUsageValue = keyUsageValue + 8;
        }

        private void checkBox5v4_CheckedChanged(object sender, EventArgs e)     // Подписывание сертификатов
        {
            keyUsageValue = keyUsageValue + 4;
        }

        private void checkBox6v2_CheckedChanged(object sender, EventArgs e)     // Подписывание СОС
        {
            keyUsageValue = keyUsageValue + 2;
        }

        private void checkBox7v1_CheckedChanged(object sender, EventArgs e)     // Только зашифровывать
        {
            keyUsageValue = keyUsageValue + 1;
        }

       
        private void comboBoxCertPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyUsageValue = 0;
            checkBox0v128.Enabled = false;
            checkBox1v64.Enabled = false;
            checkBox2v32.Enabled = false;
            checkBox3v16.Enabled = false;
            checkBox4v8.Enabled = false;
            checkBox5v4.Enabled = false;
            checkBox6v2.Enabled = false;
            checkBox7v1.Enabled = false;
            checkBox8.Enabled = false;

            // Удостоверяющий Центр
            if (comboBoxCertPurpose.SelectedIndex == 0)
            {
                checkBox0v128.Enabled = true;
                checkBox1v64.Enabled = true;
                checkBox5v4.Enabled = true;
                checkBox6v2.Enabled = true;

                checkBox0v128.Checked = true;
                checkBox1v64.Checked = true;
                checkBox5v4.Checked = true;
                checkBox6v2.Checked = true;
                
                sOutputFilename = form_mainCA.rootCA ;
            }

            // Подпись и шифрование
            if (comboBoxCertPurpose.SelectedIndex == 1 )
            {
                checkBox0v128.Enabled = true;
                checkBox1v64.Enabled = true;
                checkBox2v32.Enabled = true;
                checkBox3v16.Enabled = true;

                checkBox0v128.Checked = true;
                checkBox1v64.Checked = true;
                checkBox2v32.Checked = true;
                checkBox3v16.Checked = true;

                sOutputFilename = form_mainCA.ActivateCerts;
            }

            // Только Подпись
            if (comboBoxCertPurpose.SelectedIndex == 2)
            {
                checkBox0v128.Enabled = true;
                checkBox1v64.Enabled = true;
              
                checkBox0v128.Checked = true;
                checkBox1v64.Checked = true;

                sOutputFilename = form_mainCA.ActivateCerts ;
            }

            // Прочие варианты
            if (comboBoxCertPurpose.SelectedIndex == 3)
            {
                checkBox0v128.Enabled = true;
                checkBox1v64.Enabled = true;
                checkBox2v32.Enabled = true;
                checkBox3v16.Enabled = true;
                checkBox4v8.Enabled = true;
                checkBox5v4.Enabled = true;
                checkBox6v2.Enabled = true;
                checkBox7v1.Enabled = true;

                sOutputFilename = form_mainCA.ActivateCerts ;
            }
        }

       
       

        
    }
}
