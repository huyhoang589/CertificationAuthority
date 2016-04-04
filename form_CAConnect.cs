using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CA
{
    public partial class form_CAConnect : Form
    {
        public form_CAConnect()
        {
            InitializeComponent();
        }

        public static string caConnectCertInfo = "http://ca.gov.ru/cert";
        public static string caConnectCrlInfo = "http://ca.gov.ru/crl";

        private void form_CAConnect_Load(object sender, EventArgs e)
        {
            txtCertInfo.Enabled = false;
            txtClrInfo.Enabled = false;
            txtCertInfo.Text = caConnectCertInfo;
            txtClrInfo.Text = caConnectCrlInfo;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCertInfo.Enabled = true;
            txtClrInfo.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            caConnectCertInfo = txtCertInfo.Text;
            caConnectCrlInfo = txtClrInfo.Text;
            txtClrInfo.Enabled = false;
            txtCertInfo.Enabled = false;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


       

   
        

        
    }
}
