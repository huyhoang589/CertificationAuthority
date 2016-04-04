namespace CA
{
    partial class form_RevokeReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RevokeReason));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reason6 = new System.Windows.Forms.RadioButton();
            this.reason5 = new System.Windows.Forms.RadioButton();
            this.reason4 = new System.Windows.Forms.RadioButton();
            this.reason3 = new System.Windows.Forms.RadioButton();
            this.reason2 = new System.Windows.Forms.RadioButton();
            this.reason1 = new System.Windows.Forms.RadioButton();
            this.reason0 = new System.Windows.Forms.RadioButton();
            this.btnReasonCancel = new System.Windows.Forms.Button();
            this.bntReasonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reason6);
            this.panel1.Controls.Add(this.reason5);
            this.panel1.Controls.Add(this.reason4);
            this.panel1.Controls.Add(this.reason3);
            this.panel1.Controls.Add(this.reason2);
            this.panel1.Controls.Add(this.reason1);
            this.panel1.Controls.Add(this.reason0);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 216);
            this.panel1.TabIndex = 0;
            // 
            // reason6
            // 
            this.reason6.AutoSize = true;
            this.reason6.Location = new System.Drawing.Point(17, 175);
            this.reason6.Name = "reason6";
            this.reason6.Size = new System.Drawing.Size(213, 21);
            this.reason6.TabIndex = 6;
            this.reason6.TabStop = true;
            this.reason6.Text = "Приостановление действия";
            this.reason6.UseVisualStyleBackColor = true;
            this.reason6.CheckedChanged += new System.EventHandler(this.reason6_CheckedChanged);
            // 
            // reason5
            // 
            this.reason5.AutoSize = true;
            this.reason5.Location = new System.Drawing.Point(17, 148);
            this.reason5.Name = "reason5";
            this.reason5.Size = new System.Drawing.Size(174, 21);
            this.reason5.TabIndex = 5;
            this.reason5.TabStop = true;
            this.reason5.Text = "Прекращение работы";
            this.reason5.UseVisualStyleBackColor = true;
            this.reason5.CheckedChanged += new System.EventHandler(this.reason5_CheckedChanged);
            // 
            // reason4
            // 
            this.reason4.AutoSize = true;
            this.reason4.Location = new System.Drawing.Point(17, 121);
            this.reason4.Name = "reason4";
            this.reason4.Size = new System.Drawing.Size(170, 21);
            this.reason4.TabIndex = 4;
            this.reason4.TabStop = true;
            this.reason4.Text = "Сертификат заменен";
            this.reason4.UseVisualStyleBackColor = true;
            this.reason4.CheckedChanged += new System.EventHandler(this.reason4_CheckedChanged);
            // 
            // reason3
            // 
            this.reason3.AutoSize = true;
            this.reason3.Location = new System.Drawing.Point(17, 94);
            this.reason3.Name = "reason3";
            this.reason3.Size = new System.Drawing.Size(218, 21);
            this.reason3.TabIndex = 3;
            this.reason3.TabStop = true;
            this.reason3.Text = "Изменение принадлежности";
            this.reason3.UseVisualStyleBackColor = true;
            this.reason3.CheckedChanged += new System.EventHandler(this.reason3_CheckedChanged);
            // 
            // reason2
            // 
            this.reason2.AutoSize = true;
            this.reason2.Location = new System.Drawing.Point(17, 67);
            this.reason2.Name = "reason2";
            this.reason2.Size = new System.Drawing.Size(159, 21);
            this.reason2.TabIndex = 2;
            this.reason2.TabStop = true;
            this.reason2.Text = "Компрометация ЦС";
            this.reason2.UseVisualStyleBackColor = true;
            this.reason2.CheckedChanged += new System.EventHandler(this.reason2_CheckedChanged);
            // 
            // reason1
            // 
            this.reason1.AutoSize = true;
            this.reason1.Location = new System.Drawing.Point(17, 40);
            this.reason1.Name = "reason1";
            this.reason1.Size = new System.Drawing.Size(180, 21);
            this.reason1.TabIndex = 1;
            this.reason1.TabStop = true;
            this.reason1.Text = "Компрометация ключа";
            this.reason1.UseVisualStyleBackColor = true;
            this.reason1.CheckedChanged += new System.EventHandler(this.reason1_CheckedChanged);
            // 
            // reason0
            // 
            this.reason0.AutoSize = true;
            this.reason0.Location = new System.Drawing.Point(17, 13);
            this.reason0.Name = "reason0";
            this.reason0.Size = new System.Drawing.Size(104, 21);
            this.reason0.TabIndex = 0;
            this.reason0.TabStop = true;
            this.reason0.Text = "Не указана";
            this.reason0.UseVisualStyleBackColor = true;
            this.reason0.CheckedChanged += new System.EventHandler(this.reason0_CheckedChanged);
            // 
            // btnReasonCancel
            // 
            this.btnReasonCancel.Location = new System.Drawing.Point(157, 242);
            this.btnReasonCancel.Name = "btnReasonCancel";
            this.btnReasonCancel.Size = new System.Drawing.Size(80, 24);
            this.btnReasonCancel.TabIndex = 11;
            this.btnReasonCancel.Text = "Отмена";
            this.btnReasonCancel.UseVisualStyleBackColor = true;
            this.btnReasonCancel.Click += new System.EventHandler(this.btnReasonCancel_Click);
            // 
            // bntReasonOK
            // 
            this.bntReasonOK.Location = new System.Drawing.Point(34, 242);
            this.bntReasonOK.Name = "bntReasonOK";
            this.bntReasonOK.Size = new System.Drawing.Size(80, 24);
            this.bntReasonOK.TabIndex = 10;
            this.bntReasonOK.Text = "Готово";
            this.bntReasonOK.UseVisualStyleBackColor = true;
            this.bntReasonOK.Click += new System.EventHandler(this.bntReasonOK_Click);
            // 
            // form_RevokeReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 282);
            this.Controls.Add(this.btnReasonCancel);
            this.Controls.Add(this.bntReasonOK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RevokeReason";
            this.Text = "Укажите причину отзыва";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton reason6;
        private System.Windows.Forms.RadioButton reason5;
        private System.Windows.Forms.RadioButton reason4;
        private System.Windows.Forms.RadioButton reason3;
        private System.Windows.Forms.RadioButton reason2;
        private System.Windows.Forms.RadioButton reason1;
        private System.Windows.Forms.RadioButton reason0;
        private System.Windows.Forms.Button btnReasonCancel;
        private System.Windows.Forms.Button bntReasonOK;

    }
}