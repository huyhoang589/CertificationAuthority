namespace CA
{
    partial class form_IssueRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_IssueRequest));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtRequestTo = new System.Windows.Forms.DateTimePicker();
            this.dtRequestFrom = new System.Windows.Forms.DateTimePicker();
            this.btnIssueCancel = new System.Windows.Forms.Button();
            this.btnIssueNewCerts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.cbBoxCertPurpose = new System.Windows.Forms.ComboBox();
            this.openRootCA = new System.Windows.Forms.OpenFileDialog();
            this.openPrivKey = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtRequestTo);
            this.groupBox2.Controls.Add(this.dtRequestFrom);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 82);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Срок действия сертификата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Конец дейсвия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Начало действия";
            // 
            // dtRequestTo
            // 
            this.dtRequestTo.Location = new System.Drawing.Point(168, 48);
            this.dtRequestTo.Name = "dtRequestTo";
            this.dtRequestTo.Size = new System.Drawing.Size(200, 22);
            this.dtRequestTo.TabIndex = 1;
            this.dtRequestTo.Value = new System.DateTime(2014, 10, 7, 0, 0, 0, 0);
            // 
            // dtRequestFrom
            // 
            this.dtRequestFrom.Location = new System.Drawing.Point(168, 21);
            this.dtRequestFrom.Name = "dtRequestFrom";
            this.dtRequestFrom.Size = new System.Drawing.Size(200, 22);
            this.dtRequestFrom.TabIndex = 0;
            // 
            // btnIssueCancel
            // 
            this.btnIssueCancel.Location = new System.Drawing.Point(389, 248);
            this.btnIssueCancel.Name = "btnIssueCancel";
            this.btnIssueCancel.Size = new System.Drawing.Size(161, 28);
            this.btnIssueCancel.TabIndex = 15;
            this.btnIssueCancel.Text = "Отмена";
            this.btnIssueCancel.UseVisualStyleBackColor = true;
            this.btnIssueCancel.Click += new System.EventHandler(this.btnIssueCancel_Click);
            // 
            // btnIssueNewCerts
            // 
            this.btnIssueNewCerts.Location = new System.Drawing.Point(174, 248);
            this.btnIssueNewCerts.Name = "btnIssueNewCerts";
            this.btnIssueNewCerts.Size = new System.Drawing.Size(161, 28);
            this.btnIssueNewCerts.TabIndex = 14;
            this.btnIssueNewCerts.Text = "Выдать";
            this.btnIssueNewCerts.UseVisualStyleBackColor = true;
            this.btnIssueNewCerts.Click += new System.EventHandler(this.btnIssueNewCerts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox0);
            this.groupBox3.Controls.Add(this.cbBoxCertPurpose);
            this.groupBox3.Location = new System.Drawing.Point(4, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 146);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Назначение сертификата";
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(415, 112);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(179, 21);
            this.checkBox8.TabIndex = 9;
            this.checkBox8.Text = "Только расшифровать";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(415, 82);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(171, 21);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Только зашифровать";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(195, 82);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(175, 21);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Согласование ключей";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(195, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(167, 21);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Шифрование данных";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 112);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(168, 21);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Шифрование ключей";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(415, 55);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(161, 21);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Подписывание СОС";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(195, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(226, 21);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Подписывание сертификатов";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Неотрекаемость";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.Location = new System.Drawing.Point(6, 55);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(157, 21);
            this.checkBox0.TabIndex = 1;
            this.checkBox0.Text = "Цифровая подпись";
            this.checkBox0.UseVisualStyleBackColor = true;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // cbBoxCertPurpose
            // 
            this.cbBoxCertPurpose.FormattingEnabled = true;
            this.cbBoxCertPurpose.Items.AddRange(new object[] {
            "Удостоверяющий Центр",
            "Подпись и шифрование",
            "Только подпись",
            "Прочие варианты ..."});
            this.cbBoxCertPurpose.Location = new System.Drawing.Point(6, 23);
            this.cbBoxCertPurpose.Name = "cbBoxCertPurpose";
            this.cbBoxCertPurpose.Size = new System.Drawing.Size(226, 24);
            this.cbBoxCertPurpose.TabIndex = 0;
            this.cbBoxCertPurpose.SelectedIndexChanged += new System.EventHandler(this.cbBoxCertPurpose_SelectedIndexChanged);
            // 
            // openRootCA
            // 
            this.openRootCA.FileName = "openFileDialog1";
            // 
            // openPrivKey
            // 
            this.openPrivKey.FileName = "openFileDialog1";
            // 
            // form_IssueRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIssueCancel);
            this.Controls.Add(this.btnIssueNewCerts);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_IssueRequest";
            this.Text = "Выдать сертификат по запросу";
            this.Load += new System.EventHandler(this.form_IssueRequest_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtRequestTo;
        private System.Windows.Forms.DateTimePicker dtRequestFrom;
        private System.Windows.Forms.Button btnIssueCancel;
        private System.Windows.Forms.Button btnIssueNewCerts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.ComboBox cbBoxCertPurpose;
        private System.Windows.Forms.OpenFileDialog openRootCA;
        private System.Windows.Forms.OpenFileDialog openPrivKey;
    }
}