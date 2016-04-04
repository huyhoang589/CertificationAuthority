using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using BigIntegerClass;
using ECPointClass;
using ECParamSet;
using DSGOST2012;
using Utilities;

namespace CA
{
    public partial class form_generateKey : Form
    {
        public form_generateKey()
        {
            InitializeComponent();
        }
        
        private string sOutputFilename;
                
        //Функция генерации секретного ключа
        private void GenPrivateKey(string sOutputFilename)
        {
            GetKeyPairGenerator pKeyGen = new GetKeyPairGenerator("gost341012paramseta");
            ByteArrayList privKey = pKeyGen.get_PrivateKey();
            byte[] privateKey = privKey.getArray();

            //Записывать секретный ключ d
            FileStream stream = new FileStream(sOutputFilename, FileMode.Create);
            BinaryWriter bWriter = new BinaryWriter(stream);
            bWriter.Write(privateKey, 0, privateKey.Length);
            bWriter.Close();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            string[] fileList = Directory.GetFiles(form_mainCA.pathKeyFolder);
            int countFile = 0;
            foreach (string fileName in fileList)
            {
                countFile = countFile + 1;
            }
            sOutputFilename = form_mainCA.pathKeyFolder+ "key" + countFile.ToString() + ".KEY"; 

            GenPrivateKey(sOutputFilename);
            this.Visible = false;
            MessageBox.Show("Секретный Ключ Сгенерировал Успешно !", " Свведение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
                       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       

        
    }
}
