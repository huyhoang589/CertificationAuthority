﻿namespace CA
{
    partial class form_RefreshCRL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RefreshCRL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.NextRefreshCRLtimepicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCRLTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bntRefreshCRLCancel = new System.Windows.Forms.Button();
            this.bntRefreshCRLOK = new System.Windows.Forms.Button();
            this.openRootCACert = new System.Windows.Forms.OpenFileDialog();
            this.openFilePrivKey = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NextRefreshCRLtimepicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelCRLTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 91);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "(UTC )";
            // 
            // NextRefreshCRLtimepicker
            // 
            this.NextRefreshCRLtimepicker.Location = new System.Drawing.Point(197, 45);
            this.NextRefreshCRLtimepicker.Name = "NextRefreshCRLtimepicker";
            this.NextRefreshCRLtimepicker.Size = new System.Drawing.Size(200, 22);
            this.NextRefreshCRLtimepicker.TabIndex = 3;
            this.NextRefreshCRLtimepicker.Value = new System.DateTime(2014, 10, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Следующее обновление :";
            // 
            // labelCRLTime
            // 
            this.labelCRLTime.AutoSize = true;
            this.labelCRLTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCRLTime.Location = new System.Drawing.Point(197, 15);
            this.labelCRLTime.Name = "labelCRLTime";
            this.labelCRLTime.Size = new System.Drawing.Size(73, 19);
            this.labelCRLTime.TabIndex = 1;
            this.labelCRLTime.Text = "UTC Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время выдачи СОС : ";
            // 
            // bntRefreshCRLCancel
            // 
            this.bntRefreshCRLCancel.Location = new System.Drawing.Point(323, 101);
            this.bntRefreshCRLCancel.Name = "bntRefreshCRLCancel";
            this.bntRefreshCRLCancel.Size = new System.Drawing.Size(80, 24);
            this.bntRefreshCRLCancel.TabIndex = 9;
            this.bntRefreshCRLCancel.Text = "Отмена";
            this.bntRefreshCRLCancel.UseVisualStyleBackColor = true;
            this.bntRefreshCRLCancel.Click += new System.EventHandler(this.bntRefreshCRLCancel_Click);
            // 
            // bntRefreshCRLOK
            // 
            this.bntRefreshCRLOK.Location = new System.Drawing.Point(203, 101);
            this.bntRefreshCRLOK.Name = "bntRefreshCRLOK";
            this.bntRefreshCRLOK.Size = new System.Drawing.Size(80, 24);
            this.bntRefreshCRLOK.TabIndex = 8;
            this.bntRefreshCRLOK.Text = "Готово";
            this.bntRefreshCRLOK.UseVisualStyleBackColor = true;
            this.bntRefreshCRLOK.Click += new System.EventHandler(this.bntRefreshCRLOK_Click);
            // 
            // openRootCACert
            // 
            this.openRootCACert.FileName = "openRootCA";
            // 
            // openFilePrivKey
            // 
            this.openFilePrivKey.FileName = "openFileDialog1";
            // 
            // form_RefreshCRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 134);
            this.Controls.Add(this.bntRefreshCRLCancel);
            this.Controls.Add(this.bntRefreshCRLOK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_RefreshCRL";
            this.Text = "Времена Списка Отозванных Сертификатов";
            this.Load += new System.EventHandler(this.form_RefreshCRL_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker NextRefreshCRLtimepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCRLTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntRefreshCRLCancel;
        private System.Windows.Forms.Button bntRefreshCRLOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openRootCACert;
        private System.Windows.Forms.OpenFileDialog openFilePrivKey;
    }
}