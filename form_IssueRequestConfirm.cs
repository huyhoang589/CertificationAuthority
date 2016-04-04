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
    public partial class form_IssueRequestConfirm : Form
    {
        public form_IssueRequestConfirm()
        {
            InitializeComponent();
        }

        private void form_IssueRequestConfirm_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(form_mainCA.RequestName);
            labelRequestName.Text = fi.Name;
        }

        private void bntIssueOK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_IssueRequest issue = new form_IssueRequest();
            issue.ShowDialog();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIssueCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
    }
}
