using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CA
{
    public partial class form_RevokeConfirm : Form
    {
        public form_RevokeConfirm()
        {
            InitializeComponent();
        }

        private void form_RevokeConfirm_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(form_mainCA.certname);
            X509Certificate x509cert = X509Certificate.CreateFromCertFile(fi.FullName);
            labelRevoke.Text = "Сертификат : " + x509cert.Subject + "\n" +"Серийный номер : " + x509cert.GetSerialNumberString();

        }

        private void bntRevokeOK_Click(object sender, EventArgs e)
        {
            form_RevokeReason revokeReason = new form_RevokeReason();
            this.Visible = false;
            revokeReason.ShowDialog();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRevokeCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
    }
}
