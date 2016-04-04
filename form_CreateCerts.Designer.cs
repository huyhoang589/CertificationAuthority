namespace CA
{
    partial class form_createCerts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_createCerts));
            this.saveFileCerts = new System.Windows.Forms.SaveFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateNewCerts = new System.Windows.Forms.Button();
            this.txt_L = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_O = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_ST = new System.Windows.Forms.TextBox();
            this.txt_OU = new System.Windows.Forms.TextBox();
            this.txt_CN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtValidTo = new System.Windows.Forms.DateTimePicker();
            this.dtValidFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7v1 = new System.Windows.Forms.CheckBox();
            this.checkBox4v8 = new System.Windows.Forms.CheckBox();
            this.checkBox3v16 = new System.Windows.Forms.CheckBox();
            this.checkBox2v32 = new System.Windows.Forms.CheckBox();
            this.checkBox6v2 = new System.Windows.Forms.CheckBox();
            this.checkBox5v4 = new System.Windows.Forms.CheckBox();
            this.checkBox1v64 = new System.Windows.Forms.CheckBox();
            this.checkBox0v128 = new System.Windows.Forms.CheckBox();
            this.comboBoxCertPurpose = new System.Windows.Forms.ComboBox();
            this.openFilePrivKey = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateNewCerts
            // 
            this.btnCreateNewCerts.Location = new System.Drawing.Point(176, 501);
            this.btnCreateNewCerts.Name = "btnCreateNewCerts";
            this.btnCreateNewCerts.Size = new System.Drawing.Size(161, 28);
            this.btnCreateNewCerts.TabIndex = 10;
            this.btnCreateNewCerts.Text = "Создать сертификат";
            this.btnCreateNewCerts.UseVisualStyleBackColor = true;
            this.btnCreateNewCerts.Click += new System.EventHandler(this.btnCreateNewCerts_Click);
            // 
            // txt_L
            // 
            this.txt_L.Location = new System.Drawing.Point(180, 114);
            this.txt_L.Name = "txt_L";
            this.txt_L.Size = new System.Drawing.Size(401, 22);
            this.txt_L.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Город (L)";
            // 
            // txt_O
            // 
            this.txt_O.Location = new System.Drawing.Point(180, 55);
            this.txt_O.Name = "txt_O";
            this.txt_O.Size = new System.Drawing.Size(401, 22);
            this.txt_O.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Организация (О)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_L);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_O);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_C);
            this.groupBox4.Controls.Add(this.txt_Email);
            this.groupBox4.Controls.Add(this.txt_ST);
            this.groupBox4.Controls.Add(this.txt_OU);
            this.groupBox4.Controls.Add(this.txt_CN);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 248);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Идентификационная информация";
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(180, 203);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(52, 22);
            this.txt_C.TabIndex = 9;
            this.txt_C.Text = "RU";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(180, 175);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(401, 22);
            this.txt_Email.TabIndex = 8;
            // 
            // txt_ST
            // 
            this.txt_ST.Location = new System.Drawing.Point(180, 143);
            this.txt_ST.Name = "txt_ST";
            this.txt_ST.Size = new System.Drawing.Size(401, 22);
            this.txt_ST.TabIndex = 7;
            // 
            // txt_OU
            // 
            this.txt_OU.Location = new System.Drawing.Point(180, 86);
            this.txt_OU.Name = "txt_OU";
            this.txt_OU.Size = new System.Drawing.Size(401, 22);
            this.txt_OU.TabIndex = 6;
            // 
            // txt_CN
            // 
            this.txt_CN.Location = new System.Drawing.Point(180, 24);
            this.txt_CN.Name = "txt_CN";
            this.txt_CN.Size = new System.Drawing.Size(401, 22);
            this.txt_CN.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Страна (С)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Область (ST)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Подразделения (OU)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Идентификатор (CN)*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtValidTo);
            this.groupBox2.Controls.Add(this.dtValidFrom);
            this.groupBox2.Location = new System.Drawing.Point(6, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 82);
            this.groupBox2.TabIndex = 7;
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
            // dtValidTo
            // 
            this.dtValidTo.Location = new System.Drawing.Point(168, 48);
            this.dtValidTo.Name = "dtValidTo";
            this.dtValidTo.Size = new System.Drawing.Size(200, 22);
            this.dtValidTo.TabIndex = 1;
            this.dtValidTo.Value = new System.DateTime(2014, 10, 22, 0, 0, 0, 0);
            // 
            // dtValidFrom
            // 
            this.dtValidFrom.Location = new System.Drawing.Point(168, 21);
            this.dtValidFrom.Name = "dtValidFrom";
            this.dtValidFrom.Size = new System.Drawing.Size(200, 22);
            this.dtValidFrom.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox7v1);
            this.groupBox3.Controls.Add(this.checkBox4v8);
            this.groupBox3.Controls.Add(this.checkBox3v16);
            this.groupBox3.Controls.Add(this.checkBox2v32);
            this.groupBox3.Controls.Add(this.checkBox6v2);
            this.groupBox3.Controls.Add(this.checkBox5v4);
            this.groupBox3.Controls.Add(this.checkBox1v64);
            this.groupBox3.Controls.Add(this.checkBox0v128);
            this.groupBox3.Controls.Add(this.comboBoxCertPurpose);
            this.groupBox3.Location = new System.Drawing.Point(6, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 146);
            this.groupBox3.TabIndex = 8;
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
            // checkBox7v1
            // 
            this.checkBox7v1.AutoSize = true;
            this.checkBox7v1.Location = new System.Drawing.Point(415, 82);
            this.checkBox7v1.Name = "checkBox7v1";
            this.checkBox7v1.Size = new System.Drawing.Size(171, 21);
            this.checkBox7v1.TabIndex = 8;
            this.checkBox7v1.Text = "Только зашифровать";
            this.checkBox7v1.UseVisualStyleBackColor = true;
            this.checkBox7v1.CheckedChanged += new System.EventHandler(this.checkBox7v1_CheckedChanged);
            // 
            // checkBox4v8
            // 
            this.checkBox4v8.AutoSize = true;
            this.checkBox4v8.Location = new System.Drawing.Point(195, 82);
            this.checkBox4v8.Name = "checkBox4v8";
            this.checkBox4v8.Size = new System.Drawing.Size(175, 21);
            this.checkBox4v8.TabIndex = 7;
            this.checkBox4v8.Text = "Согласование ключей";
            this.checkBox4v8.UseVisualStyleBackColor = true;
            this.checkBox4v8.CheckedChanged += new System.EventHandler(this.checkBox4v8_CheckedChanged);
            // 
            // checkBox3v16
            // 
            this.checkBox3v16.AutoSize = true;
            this.checkBox3v16.Location = new System.Drawing.Point(195, 55);
            this.checkBox3v16.Name = "checkBox3v16";
            this.checkBox3v16.Size = new System.Drawing.Size(167, 21);
            this.checkBox3v16.TabIndex = 6;
            this.checkBox3v16.Text = "Шифрование данных";
            this.checkBox3v16.UseVisualStyleBackColor = true;
            this.checkBox3v16.CheckedChanged += new System.EventHandler(this.checkBox3v16_CheckedChanged);
            // 
            // checkBox2v32
            // 
            this.checkBox2v32.AutoSize = true;
            this.checkBox2v32.Location = new System.Drawing.Point(6, 112);
            this.checkBox2v32.Name = "checkBox2v32";
            this.checkBox2v32.Size = new System.Drawing.Size(168, 21);
            this.checkBox2v32.TabIndex = 5;
            this.checkBox2v32.Text = "Шифрование ключей";
            this.checkBox2v32.UseVisualStyleBackColor = true;
            this.checkBox2v32.CheckedChanged += new System.EventHandler(this.checkBox2v32_CheckedChanged);
            // 
            // checkBox6v2
            // 
            this.checkBox6v2.AutoSize = true;
            this.checkBox6v2.Location = new System.Drawing.Point(415, 55);
            this.checkBox6v2.Name = "checkBox6v2";
            this.checkBox6v2.Size = new System.Drawing.Size(161, 21);
            this.checkBox6v2.TabIndex = 4;
            this.checkBox6v2.Text = "Подписывание СОС";
            this.checkBox6v2.UseVisualStyleBackColor = true;
            this.checkBox6v2.CheckedChanged += new System.EventHandler(this.checkBox6v2_CheckedChanged);
            // 
            // checkBox5v4
            // 
            this.checkBox5v4.AutoSize = true;
            this.checkBox5v4.Location = new System.Drawing.Point(195, 112);
            this.checkBox5v4.Name = "checkBox5v4";
            this.checkBox5v4.Size = new System.Drawing.Size(226, 21);
            this.checkBox5v4.TabIndex = 3;
            this.checkBox5v4.Text = "Подписывание сертификатов";
            this.checkBox5v4.UseVisualStyleBackColor = true;
            this.checkBox5v4.CheckedChanged += new System.EventHandler(this.checkBox5v4_CheckedChanged);
            // 
            // checkBox1v64
            // 
            this.checkBox1v64.AutoSize = true;
            this.checkBox1v64.Location = new System.Drawing.Point(6, 82);
            this.checkBox1v64.Name = "checkBox1v64";
            this.checkBox1v64.Size = new System.Drawing.Size(140, 21);
            this.checkBox1v64.TabIndex = 2;
            this.checkBox1v64.Text = "Неотрекаемость";
            this.checkBox1v64.UseVisualStyleBackColor = true;
            this.checkBox1v64.CheckedChanged += new System.EventHandler(this.checkBox1v64_CheckedChanged);
            // 
            // checkBox0v128
            // 
            this.checkBox0v128.AutoSize = true;
            this.checkBox0v128.Location = new System.Drawing.Point(6, 55);
            this.checkBox0v128.Name = "checkBox0v128";
            this.checkBox0v128.Size = new System.Drawing.Size(157, 21);
            this.checkBox0v128.TabIndex = 1;
            this.checkBox0v128.Text = "Цифровая подпись";
            this.checkBox0v128.UseVisualStyleBackColor = true;
            this.checkBox0v128.CheckedChanged += new System.EventHandler(this.checkBox0v128_CheckedChanged);
            // 
            // comboBoxCertPurpose
            // 
            this.comboBoxCertPurpose.FormattingEnabled = true;
            this.comboBoxCertPurpose.Items.AddRange(new object[] {
            "Удостоверяющий Центр",
            "Подпись и шифрование",
            "Только подпись",
            "Прочие варианты ..."});
            this.comboBoxCertPurpose.Location = new System.Drawing.Point(6, 23);
            this.comboBoxCertPurpose.Name = "comboBoxCertPurpose";
            this.comboBoxCertPurpose.Size = new System.Drawing.Size(226, 24);
            this.comboBoxCertPurpose.TabIndex = 0;
            this.comboBoxCertPurpose.SelectedIndexChanged += new System.EventHandler(this.comboBoxCertPurpose_SelectedIndexChanged);
            // 
            // openFilePrivKey
            // 
            this.openFilePrivKey.FileName = "openFileDialog1";
            // 
            // form_createCerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 543);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateNewCerts);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_createCerts";
            this.Text = "Создание нового сертификата";
            this.Load += new System.EventHandler(this.form_createCerts_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileCerts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateNewCerts;
        private System.Windows.Forms.TextBox txt_L;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_O;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_ST;
        private System.Windows.Forms.TextBox txt_OU;
        private System.Windows.Forms.TextBox txt_CN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtValidTo;
        private System.Windows.Forms.DateTimePicker dtValidFrom;
        private System.Windows.Forms.ComboBox comboBoxCertPurpose;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7v1;
        private System.Windows.Forms.CheckBox checkBox4v8;
        private System.Windows.Forms.CheckBox checkBox3v16;
        private System.Windows.Forms.CheckBox checkBox2v32;
        private System.Windows.Forms.CheckBox checkBox6v2;
        private System.Windows.Forms.CheckBox checkBox5v4;
        private System.Windows.Forms.CheckBox checkBox1v64;
        private System.Windows.Forms.CheckBox checkBox0v128;
        private System.Windows.Forms.OpenFileDialog openFilePrivKey;
    }
}