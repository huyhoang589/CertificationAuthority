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
    public partial class form_ImportCert : Form
    {
        public form_ImportCert()
        {
            InitializeComponent();
        }
        public static bool ImportRootCA, ImportActiveCert, ImportCertChecked;

        private void bntImportOK_Click(object sender, EventArgs e)
        {
            ImportCertChecked = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnImportCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButtonRootCA_CheckedChanged(object sender, EventArgs e)
        {
            ImportRootCA = true;
            ImportActiveCert = false;
        }

        private void radioButtonActiveCert_CheckedChanged(object sender, EventArgs e)
        {
            ImportRootCA = false;
            ImportActiveCert = true;
        }
    }
}
