using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace CA
{
    public partial class form_RevokeReason : Form
    {
        public form_RevokeReason()
        {
            InitializeComponent();
        }
        public static string certRevoke;
        public static string reasonRevoke;
        public static DateTime dataRevoke;
        private void bntReasonOK_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(form_mainCA.certname);
            if (File.Exists(form_mainCA.deActivateCerts + fi.Name))
            {
                MessageBox.Show("Файл с таким же именем уже существует в этом расположении. Замещает файл !", "Отозвание сертификата", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete(form_mainCA.certname);
            }
            else
            {
                File.Move(form_mainCA.certname, form_mainCA.deActivateCerts + fi.Name);
                certRevoke = form_mainCA.deActivateCerts + fi.Name;
            }
            dataRevoke = DateTime.Now;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnReasonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void reason0_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason0.Text;
        }

        private void reason1_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason1.Text;
        }

        private void reason2_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason2.Text;
        }

        private void reason3_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason3.Text;
        }

        private void reason4_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason4.Text;
        }

        private void reason5_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason5.Text;
        }

        private void reason6_CheckedChanged(object sender, EventArgs e)
        {
            reasonRevoke = reason6.Text;
        }
    }
}
