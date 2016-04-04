namespace CA
{
    partial class form_IssueRequestConfirm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_IssueRequestConfirm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIssueCancel = new System.Windows.Forms.Button();
            this.bntIssueOK = new System.Windows.Forms.Button();
            this.labelRequestName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnIssueCancel);
            this.panel1.Controls.Add(this.bntIssueOK);
            this.panel1.Controls.Add(this.labelRequestName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 97);
            this.panel1.TabIndex = 0;
            // 
            // btnIssueCancel
            // 
            this.btnIssueCancel.Location = new System.Drawing.Point(218, 60);
            this.btnIssueCancel.Name = "btnIssueCancel";
            this.btnIssueCancel.Size = new System.Drawing.Size(80, 24);
            this.btnIssueCancel.TabIndex = 11;
            this.btnIssueCancel.Text = "Нет";
            this.btnIssueCancel.UseVisualStyleBackColor = true;
            this.btnIssueCancel.Click += new System.EventHandler(this.btnIssueCancel_Click);
            // 
            // bntIssueOK
            // 
            this.bntIssueOK.Location = new System.Drawing.Point(39, 60);
            this.bntIssueOK.Name = "bntIssueOK";
            this.bntIssueOK.Size = new System.Drawing.Size(80, 24);
            this.bntIssueOK.TabIndex = 10;
            this.bntIssueOK.Text = "Да";
            this.bntIssueOK.UseVisualStyleBackColor = true;
            this.bntIssueOK.Click += new System.EventHandler(this.bntIssueOK_Click);
            // 
            // labelRequestName
            // 
            this.labelRequestName.AutoSize = true;
            this.labelRequestName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRequestName.Location = new System.Drawing.Point(255, 15);
            this.labelRequestName.Name = "labelRequestName";
            this.labelRequestName.Size = new System.Drawing.Size(58, 19);
            this.labelRequestName.TabIndex = 1;
            this.labelRequestName.Text = "Запрос";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выдать сертификат по запросу : ";
            // 
            // form_IssueRequestConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 103);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_IssueRequestConfirm";
            this.Text = "Выдать сертификат ?";
            this.Load += new System.EventHandler(this.form_IssueRequestConfirm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRequestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssueCancel;
        private System.Windows.Forms.Button bntIssueOK;
    }
}