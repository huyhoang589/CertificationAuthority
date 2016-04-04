namespace CA
{
    partial class form_generateKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_generateKey));
            this.Information = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.saveDialogGenKey = new System.Windows.Forms.SaveFileDialog();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // Information
            // 
            this.Information.Controls.Add(this.label2);
            this.Information.Controls.Add(this.label1);
            this.Information.Location = new System.Drawing.Point(10, 15);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(366, 94);
            this.Information.TabIndex = 4;
            this.Information.TabStop = false;
            this.Information.Text = "Информации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина ключа : 512 (бит)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алгоритм генерации ключей : ГОСТ Р.3410 - 2012";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(58, 117);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(112, 24);
            this.bntOK.TabIndex = 6;
            this.bntOK.Text = "Генерировать";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // form_generateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 147);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_generateKey";
            this.Text = "Режим генерации секретного ключа";
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.SaveFileDialog saveDialogGenKey;
    }
}