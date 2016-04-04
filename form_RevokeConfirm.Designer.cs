namespace CA
{
    partial class form_RevokeConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RevokeConfirm));
            this.labelRevoke = new System.Windows.Forms.Label();
            this.bntRevokeOK = new System.Windows.Forms.Button();
            this.btnRevokeCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelRevoke
            // 
            this.labelRevoke.AutoSize = true;
            this.labelRevoke.Location = new System.Drawing.Point(12, 9);
            this.labelRevoke.Name = "labelRevoke";
            this.labelRevoke.Size = new System.Drawing.Size(93, 17);
            this.labelRevoke.TabIndex = 0;
            this.labelRevoke.Text = "Сертификат:";
            // 
            // bntRevokeOK
            // 
            this.bntRevokeOK.Location = new System.Drawing.Point(170, 80);
            this.bntRevokeOK.Name = "bntRevokeOK";
            this.bntRevokeOK.Size = new System.Drawing.Size(80, 24);
            this.bntRevokeOK.TabIndex = 8;
            this.bntRevokeOK.Text = "Да";
            this.bntRevokeOK.UseVisualStyleBackColor = true;
            this.bntRevokeOK.Click += new System.EventHandler(this.bntRevokeOK_Click);
            // 
            // btnRevokeCancel
            // 
            this.btnRevokeCancel.Location = new System.Drawing.Point(349, 80);
            this.btnRevokeCancel.Name = "btnRevokeCancel";
            this.btnRevokeCancel.Size = new System.Drawing.Size(80, 24);
            this.btnRevokeCancel.TabIndex = 9;
            this.btnRevokeCancel.Text = "Нет";
            this.btnRevokeCancel.UseVisualStyleBackColor = true;
            this.btnRevokeCancel.Click += new System.EventHandler(this.btnRevokeCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 108);
            this.panel1.TabIndex = 10;
            // 
            // form_RevokeConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 116);
            this.Controls.Add(this.btnRevokeCancel);
            this.Controls.Add(this.bntRevokeOK);
            this.Controls.Add(this.labelRevoke);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RevokeConfirm";
            this.Text = "Отозвать сертификат ?";
            this.Load += new System.EventHandler(this.form_RevokeConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRevoke;
        private System.Windows.Forms.Button bntRevokeOK;
        private System.Windows.Forms.Button btnRevokeCancel;
        private System.Windows.Forms.Panel panel1;

    }
}