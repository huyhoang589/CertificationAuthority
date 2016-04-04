namespace CA
{
    partial class form_DeleteConfim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DeleteConfim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.bntDeleteOK = new System.Windows.Forms.Button();
            this.labelFileDeleted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteCancel);
            this.panel1.Controls.Add(this.bntDeleteOK);
            this.panel1.Controls.Add(this.labelFileDeleted);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 103);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Location = new System.Drawing.Point(218, 66);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(80, 24);
            this.btnDeleteCancel.TabIndex = 13;
            this.btnDeleteCancel.Text = "Нет";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // bntDeleteOK
            // 
            this.bntDeleteOK.Location = new System.Drawing.Point(39, 66);
            this.bntDeleteOK.Name = "bntDeleteOK";
            this.bntDeleteOK.Size = new System.Drawing.Size(80, 24);
            this.bntDeleteOK.TabIndex = 12;
            this.bntDeleteOK.Text = "Да";
            this.bntDeleteOK.UseVisualStyleBackColor = true;
            this.bntDeleteOK.Click += new System.EventHandler(this.bntDeleteOK_Click);
            // 
            // labelFileDeleted
            // 
            this.labelFileDeleted.AutoSize = true;
            this.labelFileDeleted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFileDeleted.Location = new System.Drawing.Point(78, 33);
            this.labelFileDeleted.Name = "labelFileDeleted";
            this.labelFileDeleted.Size = new System.Drawing.Size(81, 19);
            this.labelFileDeleted.TabIndex = 1;
            this.labelFileDeleted.Text = "file Deleted";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы действительно хотите удалить этот файл ?";
            // 
            // form_DeleteConfim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 108);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_DeleteConfim";
            this.Text = "Удалить файл";
            this.Load += new System.EventHandler(this.form_DeleteConfim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFileDeleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button bntDeleteOK;
    }
}