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

namespace CA
{
    public partial class form_DeleteConfim : Form
    {
        public form_DeleteConfim()
        {
            InitializeComponent();
        }

        public static bool deleleOK;

        private void form_DeleteConfim_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(form_mainCA.fileDeletedName);
            if (fi.Extension == ".CER")
            {
                X509Certificate cert = X509Certificate.CreateFromCertFile(fi.FullName);
                getSubjectInfo sInfo = new getSubjectInfo();
                sInfo.set_Subject(cert.Subject);
                string info = sInfo.get_CN();
                labelFileDeleted.Text = info;
            }
            else
            labelFileDeleted.Text = fi.Name ;

            deleleOK = false;
        }

        private void bntDeleteOK_Click(object sender, EventArgs e)
        {
            deleleOK = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
