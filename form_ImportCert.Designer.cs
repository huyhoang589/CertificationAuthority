namespace CA
{
    partial class form_ImportCert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ImportCert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonActiveCert = new System.Windows.Forms.RadioButton();
            this.radioButtonRootCA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportCancel = new System.Windows.Forms.Button();
            this.bntImportOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButtonActiveCert);
            this.panel1.Controls.Add(this.radioButtonRootCA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 104);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonActiveCert
            // 
            this.radioButtonActiveCert.AutoSize = true;
            this.radioButtonActiveCert.Location = new System.Drawing.Point(36, 66);
            this.radioButtonActiveCert.Name = "radioButtonActiveCert";
            this.radioButtonActiveCert.Size = new System.Drawing.Size(98, 21);
            this.radioButtonActiveCert.TabIndex = 2;
            this.radioButtonActiveCert.TabStop = true;
            this.radioButtonActiveCert.Text = "Выданный";
            this.radioButtonActiveCert.UseVisualStyleBackColor = true;
            this.radioButtonActiveCert.CheckedChanged += new System.EventHandler(this.radioButtonActiveCert_CheckedChanged);
            // 
            // radioButtonRootCA
            // 
            this.radioButtonRootCA.AutoSize = true;
            this.radioButtonRootCA.Location = new System.Drawing.Point(36, 35);
            this.radioButtonRootCA.Name = "radioButtonRootCA";
            this.radioButtonRootCA.Size = new System.Drawing.Size(93, 21);
            this.radioButtonRootCA.TabIndex = 1;
            this.radioButtonRootCA.TabStop = true;
            this.radioButtonRootCA.Text = "Корневой";
            this.radioButtonRootCA.UseVisualStyleBackColor = true;
            this.radioButtonRootCA.CheckedChanged += new System.EventHandler(this.radioButtonRootCA_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать хранилище сертификатов :";
            // 
            // btnImportCancel
            // 
            this.btnImportCancel.Location = new System.Drawing.Point(162, 116);
            this.btnImportCancel.Name = "btnImportCancel";
            this.btnImportCancel.Size = new System.Drawing.Size(80, 24);
            this.btnImportCancel.TabIndex = 13;
            this.btnImportCancel.Text = "Отмена";
            this.btnImportCancel.UseVisualStyleBackColor = true;
            this.btnImportCancel.Click += new System.EventHandler(this.btnImportCancel_Click);
            // 
            // bntImportOK
            // 
            this.bntImportOK.Location = new System.Drawing.Point(39, 116);
            this.bntImportOK.Name = "bntImportOK";
            this.bntImportOK.Size = new System.Drawing.Size(80, 24);
            this.bntImportOK.TabIndex = 12;
            this.bntImportOK.Text = "Готово";
            this.bntImportOK.UseVisualStyleBackColor = true;
            this.bntImportOK.Click += new System.EventHandler(this.bntImportOK_Click);
            // 
            // form_ImportCert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 151);
            this.Controls.Add(this.btnImportCancel);
            this.Controls.Add(this.bntImportOK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ImportCert";
            this.Text = "Установка сертификатов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonActiveCert;
        private System.Windows.Forms.RadioButton radioButtonRootCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportCancel;
        private System.Windows.Forms.Button bntImportOK;
    }
}