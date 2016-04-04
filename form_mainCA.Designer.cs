namespace CA
{
    partial class form_mainCA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_mainCA));
            this.treeViewCA = new System.Windows.Forms.TreeView();
            this.CAimageList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.listViewCerts = new System.Windows.Forms.ListView();
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Issuer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickActCert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickRevoke = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ActionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateKey = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewCerts = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCertsRevocationList = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateCertRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigCAConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCRL = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickRevokedCert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openRevokedCert = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRevokedCert = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListBtnMenu = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuExport = new System.Windows.Forms.Button();
            this.labelBtnMenuExport = new System.Windows.Forms.Label();
            this.btnMenuOpen = new System.Windows.Forms.Button();
            this.labelBtnMenuOpen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenuKey = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenuCreat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenuRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMenuService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMenuImport = new System.Windows.Forms.Button();
            this.labelBtnImport = new System.Windows.Forms.Label();
            this.btnMenuDelete = new System.Windows.Forms.Button();
            this.labelBtnMenuDelete = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listViewRequest = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickCRL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightClickRequest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выдатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuBtnCreat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.самоподписанныйСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросНаСертификатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuBtnService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.настройкаДоступаКУЦToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileImport = new System.Windows.Forms.OpenFileDialog();
            this.saveFileExport = new System.Windows.Forms.SaveFileDialog();
            this.rightClickActCert.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.rightClickRevokedCert.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.rightClickCRL.SuspendLayout();
            this.rightClickRequest.SuspendLayout();
            this.contextMenuBtnCreat.SuspendLayout();
            this.contextMenuBtnService.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCA
            // 
            this.treeViewCA.ImageIndex = 0;
            this.treeViewCA.ImageList = this.CAimageList;
            this.treeViewCA.Location = new System.Drawing.Point(4, 64);
            this.treeViewCA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeViewCA.Name = "treeViewCA";
            this.treeViewCA.SelectedImageIndex = 0;
            this.treeViewCA.Size = new System.Drawing.Size(156, 258);
            this.treeViewCA.TabIndex = 0;
            this.treeViewCA.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCA_AfterSelect);
            // 
            // CAimageList
            // 
            this.CAimageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CAimageList.ImageStream")));
            this.CAimageList.TransparentColor = System.Drawing.Color.Transparent;
            this.CAimageList.Images.SetKeyName(0, "Certs.ico");
            this.CAimageList.Images.SetKeyName(1, "Request.ico");
            this.CAimageList.Images.SetKeyName(2, "COC.png");
            this.CAimageList.Images.SetKeyName(3, "FolderClose.ico");
            this.CAimageList.Images.SetKeyName(4, "FolderOpen.ico");
            this.CAimageList.Images.SetKeyName(5, "Certs_True.ico");
            this.CAimageList.Images.SetKeyName(6, "Certs_False.ico");
            this.CAimageList.Images.SetKeyName(7, "Certs_root.ico");
            // 
            // listViewCerts
            // 
            this.listViewCerts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subject,
            this.serial,
            this.ValidFrom,
            this.ValidTo,
            this.Issuer});
            this.listViewCerts.ContextMenuStrip = this.rightClickActCert;
            this.listViewCerts.GridLines = true;
            this.listViewCerts.LargeImageList = this.CAimageList;
            this.listViewCerts.Location = new System.Drawing.Point(163, 64);
            this.listViewCerts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewCerts.Name = "listViewCerts";
            this.listViewCerts.Size = new System.Drawing.Size(570, 258);
            this.listViewCerts.SmallImageList = this.CAimageList;
            this.listViewCerts.StateImageList = this.CAimageList;
            this.listViewCerts.TabIndex = 1;
            this.listViewCerts.UseCompatibleStateImageBehavior = false;
            this.listViewCerts.View = System.Windows.Forms.View.Details;
            this.listViewCerts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCerts_MouseClick);
            // 
            // subject
            // 
            this.subject.Text = "Владелец";
            this.subject.Width = 112;
            // 
            // serial
            // 
            this.serial.Text = "Серийный Номер";
            this.serial.Width = 163;
            // 
            // ValidFrom
            // 
            this.ValidFrom.Text = "Начало Действия";
            this.ValidFrom.Width = 170;
            // 
            // ValidTo
            // 
            this.ValidTo.Text = "Конец Действия";
            this.ValidTo.Width = 159;
            // 
            // Issuer
            // 
            this.Issuer.Text = "Издатель";
            this.Issuer.Width = 82;
            // 
            // rightClickActCert
            // 
            this.rightClickActCert.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClickOpen,
            this.RightClickRevoke,
            this.RightClickDelete});
            this.rightClickActCert.Name = "rightClickActCert";
            this.rightClickActCert.Size = new System.Drawing.Size(124, 70);
            this.rightClickActCert.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickActCert_Opening);
            // 
            // RightClickOpen
            // 
            this.RightClickOpen.Name = "RightClickOpen";
            this.RightClickOpen.Size = new System.Drawing.Size(123, 22);
            this.RightClickOpen.Text = "Открыть";
            this.RightClickOpen.Click += new System.EventHandler(this.RightClickOpen_Click);
            // 
            // RightClickRevoke
            // 
            this.RightClickRevoke.Name = "RightClickRevoke";
            this.RightClickRevoke.Size = new System.Drawing.Size(123, 22);
            this.RightClickRevoke.Text = "Отозвать";
            this.RightClickRevoke.Click += new System.EventHandler(this.RightClickRevoke_Click);
            // 
            // RightClickDelete
            // 
            this.RightClickDelete.Name = "RightClickDelete";
            this.RightClickDelete.Size = new System.Drawing.Size(123, 22);
            this.RightClickDelete.Text = "Удалить";
            this.RightClickDelete.Click += new System.EventHandler(this.RightClickDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionMenu,
            this.сервисToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ActionMenu
            // 
            this.ActionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateKey,
            this.CreateNewCerts,
            this.refreshCertsRevocationList,
            this.CreateCertRequest,
            this.ExitProgramm});
            this.ActionMenu.Name = "ActionMenu";
            this.ActionMenu.Size = new System.Drawing.Size(75, 20);
            this.ActionMenu.Text = "Действие";
            // 
            // GenerateKey
            // 
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.Size = new System.Drawing.Size(334, 22);
            this.GenerateKey.Text = "Генерировать секретный ключ";
            this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
            // 
            // CreateNewCerts
            // 
            this.CreateNewCerts.Name = "CreateNewCerts";
            this.CreateNewCerts.Size = new System.Drawing.Size(334, 22);
            this.CreateNewCerts.Text = "Создать самоподписанный сертификат";
            this.CreateNewCerts.Click += new System.EventHandler(this.CreateNewCerts_Click);
            // 
            // refreshCertsRevocationList
            // 
            this.refreshCertsRevocationList.Name = "refreshCertsRevocationList";
            this.refreshCertsRevocationList.Size = new System.Drawing.Size(334, 22);
            this.refreshCertsRevocationList.Text = "Обновить список отозванных сертификатов";
            this.refreshCertsRevocationList.Click += new System.EventHandler(this.refreshCertsRevocationList_Click);
            // 
            // CreateCertRequest
            // 
            this.CreateCertRequest.Name = "CreateCertRequest";
            this.CreateCertRequest.Size = new System.Drawing.Size(334, 22);
            this.CreateCertRequest.Text = "Создать запрос на сертификат";
            this.CreateCertRequest.Click += new System.EventHandler(this.CreateCertRequest_Click);
            // 
            // ExitProgramm
            // 
            this.ExitProgramm.Name = "ExitProgramm";
            this.ExitProgramm.Size = new System.Drawing.Size(334, 22);
            this.ExitProgramm.Text = "Выход";
            this.ExitProgramm.Click += new System.EventHandler(this.ExitProgramm_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigCAConnect});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // ConfigCAConnect
            // 
            this.ConfigCAConnect.Name = "ConfigCAConnect";
            this.ConfigCAConnect.Size = new System.Drawing.Size(221, 22);
            this.ConfigCAConnect.Text = "Настройка доступа к УЦ";
            this.ConfigCAConnect.Click += new System.EventHandler(this.ConfigCAConnect_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listViewCRL
            // 
            this.listViewCRL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCRL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.dateTime,
            this.reason});
            this.listViewCRL.ContextMenuStrip = this.rightClickRevokedCert;
            this.listViewCRL.GridLines = true;
            this.listViewCRL.LargeImageList = this.CAimageList;
            this.listViewCRL.Location = new System.Drawing.Point(161, 64);
            this.listViewCRL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewCRL.Name = "listViewCRL";
            this.listViewCRL.Size = new System.Drawing.Size(572, 258);
            this.listViewCRL.SmallImageList = this.CAimageList;
            this.listViewCRL.StateImageList = this.CAimageList;
            this.listViewCRL.TabIndex = 3;
            this.listViewCRL.UseCompatibleStateImageBehavior = false;
            this.listViewCRL.View = System.Windows.Forms.View.Details;
            this.listViewCRL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewCRL_MouseClick);
            // 
            // Number
            // 
            this.Number.Text = "Серийный номер";
            this.Number.Width = 241;
            // 
            // dateTime
            // 
            this.dateTime.Text = "Дата отзыва";
            this.dateTime.Width = 206;
            // 
            // reason
            // 
            this.reason.Text = "Причина отзыва";
            this.reason.Width = 288;
            // 
            // rightClickRevokedCert
            // 
            this.rightClickRevokedCert.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRevokedCert,
            this.cancelRevokedCert,
            this.удалитьToolStripMenuItem2});
            this.rightClickRevokedCert.Name = "rightClickRevokedCert";
            this.rightClickRevokedCert.Size = new System.Drawing.Size(158, 70);
            this.rightClickRevokedCert.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickRevokedCert_Opening);
            // 
            // openRevokedCert
            // 
            this.openRevokedCert.Name = "openRevokedCert";
            this.openRevokedCert.Size = new System.Drawing.Size(157, 22);
            this.openRevokedCert.Text = "Открыть";
            this.openRevokedCert.Click += new System.EventHandler(this.openRevokedCert_Click);
            // 
            // cancelRevokedCert
            // 
            this.cancelRevokedCert.Name = "cancelRevokedCert";
            this.cancelRevokedCert.Size = new System.Drawing.Size(157, 22);
            this.cancelRevokedCert.Text = "Отмена отзыва";
            this.cancelRevokedCert.Click += new System.EventHandler(this.cancelRevokedCert_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // imageListBtnMenu
            // 
            this.imageListBtnMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtnMenu.ImageStream")));
            this.imageListBtnMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBtnMenu.Images.SetKeyName(0, "add_card.ico");
            this.imageListBtnMenu.Images.SetKeyName(1, "network_service.ico");
            this.imageListBtnMenu.Images.SetKeyName(2, "reload.ico");
            this.imageListBtnMenu.Images.SetKeyName(3, "ustanov_sertif.gif");
            this.imageListBtnMenu.Images.SetKeyName(4, "zapros_sertif.gif");
            this.imageListBtnMenu.Images.SetKeyName(5, "file_delete_01.ico");
            this.imageListBtnMenu.Images.SetKeyName(6, "sertifikaty.gif");
            this.imageListBtnMenu.Images.SetKeyName(7, "file_del.ico");
            this.imageListBtnMenu.Images.SetKeyName(8, "move_waiting_up.ico");
            this.imageListBtnMenu.Images.SetKeyName(9, "key_add.ico");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnMenuExport);
            this.panel1.Controls.Add(this.labelBtnMenuExport);
            this.panel1.Controls.Add(this.btnMenuOpen);
            this.panel1.Controls.Add(this.labelBtnMenuOpen);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 41);
            this.panel1.TabIndex = 5;
            // 
            // btnMenuExport
            // 
            this.btnMenuExport.ImageIndex = 8;
            this.btnMenuExport.ImageList = this.imageListBtnMenu;
            this.btnMenuExport.Location = new System.Drawing.Point(265, 2);
            this.btnMenuExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuExport.Name = "btnMenuExport";
            this.btnMenuExport.Size = new System.Drawing.Size(30, 24);
            this.btnMenuExport.TabIndex = 27;
            this.btnMenuExport.UseVisualStyleBackColor = true;
            this.btnMenuExport.Click += new System.EventHandler(this.btnMenuExport_Click);
            // 
            // labelBtnMenuExport
            // 
            this.labelBtnMenuExport.AutoSize = true;
            this.labelBtnMenuExport.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtnMenuExport.Location = new System.Drawing.Point(257, 24);
            this.labelBtnMenuExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBtnMenuExport.Name = "labelBtnMenuExport";
            this.labelBtnMenuExport.Size = new System.Drawing.Size(49, 13);
            this.labelBtnMenuExport.TabIndex = 28;
            this.labelBtnMenuExport.Text = "Экспорт";
            this.labelBtnMenuExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenuOpen
            // 
            this.btnMenuOpen.ImageIndex = 4;
            this.btnMenuOpen.ImageList = this.imageListBtnMenu;
            this.btnMenuOpen.Location = new System.Drawing.Point(318, 2);
            this.btnMenuOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuOpen.Name = "btnMenuOpen";
            this.btnMenuOpen.Size = new System.Drawing.Size(30, 24);
            this.btnMenuOpen.TabIndex = 19;
            this.btnMenuOpen.UseVisualStyleBackColor = true;
            this.btnMenuOpen.Click += new System.EventHandler(this.btnMenuOpen_Click);
            // 
            // labelBtnMenuOpen
            // 
            this.labelBtnMenuOpen.AutoSize = true;
            this.labelBtnMenuOpen.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtnMenuOpen.Location = new System.Drawing.Point(310, 24);
            this.labelBtnMenuOpen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBtnMenuOpen.Name = "labelBtnMenuOpen";
            this.labelBtnMenuOpen.Size = new System.Drawing.Size(57, 13);
            this.labelBtnMenuOpen.TabIndex = 20;
            this.labelBtnMenuOpen.Text = "Открыть";
            this.labelBtnMenuOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMenuKey);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 41);
            this.panel2.TabIndex = 32;
            // 
            // btnMenuKey
            // 
            this.btnMenuKey.ImageIndex = 9;
            this.btnMenuKey.ImageList = this.imageListBtnMenu;
            this.btnMenuKey.Location = new System.Drawing.Point(7, 2);
            this.btnMenuKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuKey.Name = "btnMenuKey";
            this.btnMenuKey.Size = new System.Drawing.Size(30, 24);
            this.btnMenuKey.TabIndex = 14;
            this.btnMenuKey.UseVisualStyleBackColor = true;
            this.btnMenuKey.Click += new System.EventHandler(this.btnMenuKey_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(-2, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ген.Ключ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnMenuCreat);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(49, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(49, 41);
            this.panel3.TabIndex = 33;
            // 
            // btnMenuCreat
            // 
            this.btnMenuCreat.ImageIndex = 0;
            this.btnMenuCreat.ImageList = this.imageListBtnMenu;
            this.btnMenuCreat.Location = new System.Drawing.Point(8, 2);
            this.btnMenuCreat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuCreat.Name = "btnMenuCreat";
            this.btnMenuCreat.Size = new System.Drawing.Size(30, 24);
            this.btnMenuCreat.TabIndex = 4;
            this.btnMenuCreat.UseVisualStyleBackColor = true;
            this.btnMenuCreat.Click += new System.EventHandler(this.btnMenuCreat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Создать";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnMenuRefresh);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(146, -1);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(57, 41);
            this.panel4.TabIndex = 34;
            // 
            // btnMenuRefresh
            // 
            this.btnMenuRefresh.ImageIndex = 2;
            this.btnMenuRefresh.ImageList = this.imageListBtnMenu;
            this.btnMenuRefresh.Location = new System.Drawing.Point(13, 2);
            this.btnMenuRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuRefresh.Name = "btnMenuRefresh";
            this.btnMenuRefresh.Size = new System.Drawing.Size(30, 24);
            this.btnMenuRefresh.TabIndex = 12;
            this.btnMenuRefresh.UseVisualStyleBackColor = true;
            this.btnMenuRefresh.Click += new System.EventHandler(this.btnMenuRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Обновить";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnMenuService);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(98, -2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(49, 41);
            this.panel5.TabIndex = 35;
            // 
            // btnMenuService
            // 
            this.btnMenuService.ImageIndex = 1;
            this.btnMenuService.ImageList = this.imageListBtnMenu;
            this.btnMenuService.Location = new System.Drawing.Point(8, 2);
            this.btnMenuService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuService.Name = "btnMenuService";
            this.btnMenuService.Size = new System.Drawing.Size(30, 24);
            this.btnMenuService.TabIndex = 9;
            this.btnMenuService.UseVisualStyleBackColor = true;
            this.btnMenuService.Click += new System.EventHandler(this.btnMenuService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Сервис";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnMenuImport);
            this.panel6.Controls.Add(this.labelBtnImport);
            this.panel6.Controls.Add(this.btnMenuDelete);
            this.panel6.Controls.Add(this.labelBtnMenuDelete);
            this.panel6.Location = new System.Drawing.Point(202, -2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 41);
            this.panel6.TabIndex = 36;
            // 
            // btnMenuImport
            // 
            this.btnMenuImport.ImageIndex = 3;
            this.btnMenuImport.ImageList = this.imageListBtnMenu;
            this.btnMenuImport.Location = new System.Drawing.Point(9, 3);
            this.btnMenuImport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuImport.Name = "btnMenuImport";
            this.btnMenuImport.Size = new System.Drawing.Size(30, 24);
            this.btnMenuImport.TabIndex = 17;
            this.btnMenuImport.UseVisualStyleBackColor = true;
            this.btnMenuImport.Click += new System.EventHandler(this.btnMenuImport_Click);
            // 
            // labelBtnImport
            // 
            this.labelBtnImport.AutoSize = true;
            this.labelBtnImport.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtnImport.Location = new System.Drawing.Point(3, 25);
            this.labelBtnImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBtnImport.Name = "labelBtnImport";
            this.labelBtnImport.Size = new System.Drawing.Size(48, 13);
            this.labelBtnImport.TabIndex = 18;
            this.labelBtnImport.Text = "Импорт";
            this.labelBtnImport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.ImageIndex = 7;
            this.btnMenuDelete.ImageList = this.imageListBtnMenu;
            this.btnMenuDelete.Location = new System.Drawing.Point(171, 2);
            this.btnMenuDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Size = new System.Drawing.Size(30, 24);
            this.btnMenuDelete.TabIndex = 23;
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnMenuDelete_Click);
            // 
            // labelBtnMenuDelete
            // 
            this.labelBtnMenuDelete.AutoSize = true;
            this.labelBtnMenuDelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBtnMenuDelete.Location = new System.Drawing.Point(164, 25);
            this.labelBtnMenuDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBtnMenuDelete.Name = "labelBtnMenuDelete";
            this.labelBtnMenuDelete.Size = new System.Drawing.Size(52, 13);
            this.labelBtnMenuDelete.TabIndex = 24;
            this.labelBtnMenuDelete.Text = "Удалить";
            this.labelBtnMenuDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(420, -2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 41);
            this.panel7.TabIndex = 37;
            // 
            // listViewRequest
            // 
            this.listViewRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewRequest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.data});
            this.listViewRequest.GridLines = true;
            this.listViewRequest.LargeImageList = this.CAimageList;
            this.listViewRequest.Location = new System.Drawing.Point(161, 64);
            this.listViewRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewRequest.Name = "listViewRequest";
            this.listViewRequest.Size = new System.Drawing.Size(572, 258);
            this.listViewRequest.SmallImageList = this.CAimageList;
            this.listViewRequest.StateImageList = this.CAimageList;
            this.listViewRequest.TabIndex = 6;
            this.listViewRequest.UseCompatibleStateImageBehavior = false;
            this.listViewRequest.View = System.Windows.Forms.View.Details;
            this.listViewRequest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewRequest_MouseClick);
            // 
            // name
            // 
            this.name.Text = "Код ( ID )";
            this.name.Width = 267;
            // 
            // data
            // 
            this.data.Text = "Дата создания";
            this.data.Width = 217;
            // 
            // rightClickCRL
            // 
            this.rightClickCRL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.rightClickCRL.Name = "rightClickCRL";
            this.rightClickCRL.Size = new System.Drawing.Size(122, 48);
            this.rightClickCRL.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickCRL_Opening);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // rightClickRequest
            // 
            this.rightClickRequest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.выдатьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.rightClickRequest.Name = "rightClickRequest";
            this.rightClickRequest.Size = new System.Drawing.Size(122, 70);
            this.rightClickRequest.Opening += new System.ComponentModel.CancelEventHandler(this.rightClickRequest_Opening);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem1_Click);
            // 
            // выдатьToolStripMenuItem
            // 
            this.выдатьToolStripMenuItem.Name = "выдатьToolStripMenuItem";
            this.выдатьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выдатьToolStripMenuItem.Text = "Выдать";
            this.выдатьToolStripMenuItem.Click += new System.EventHandler(this.выдатьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // contextMenuBtnCreat
            // 
            this.contextMenuBtnCreat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.самоподписанныйСертификатToolStripMenuItem,
            this.запросНаСертификатToolStripMenuItem});
            this.contextMenuBtnCreat.Name = "contextMenuBtnCreat";
            this.contextMenuBtnCreat.Size = new System.Drawing.Size(248, 48);
            // 
            // самоподписанныйСертификатToolStripMenuItem
            // 
            this.самоподписанныйСертификатToolStripMenuItem.Name = "самоподписанныйСертификатToolStripMenuItem";
            this.самоподписанныйСертификатToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.самоподписанныйСертификатToolStripMenuItem.Text = "Самоподписанный сертификат";
            this.самоподписанныйСертификатToolStripMenuItem.Click += new System.EventHandler(this.самоподписанныйСертификатToolStripMenuItem_Click);
            // 
            // запросНаСертификатToolStripMenuItem
            // 
            this.запросНаСертификатToolStripMenuItem.Name = "запросНаСертификатToolStripMenuItem";
            this.запросНаСертификатToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.запросНаСертификатToolStripMenuItem.Text = "Запрос на сертификат";
            this.запросНаСертификатToolStripMenuItem.Click += new System.EventHandler(this.запросНаСертификатToolStripMenuItem_Click);
            // 
            // contextMenuBtnService
            // 
            this.contextMenuBtnService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаДоступаКУЦToolStripMenuItem});
            this.contextMenuBtnService.Name = "contextMenuBtnService";
            this.contextMenuBtnService.Size = new System.Drawing.Size(208, 26);
            // 
            // настройкаДоступаКУЦToolStripMenuItem
            // 
            this.настройкаДоступаКУЦToolStripMenuItem.Name = "настройкаДоступаКУЦToolStripMenuItem";
            this.настройкаДоступаКУЦToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.настройкаДоступаКУЦToolStripMenuItem.Text = "Настройка доступа к УЦ";
            this.настройкаДоступаКУЦToolStripMenuItem.Click += new System.EventHandler(this.настройкаДоступаКУЦToolStripMenuItem_Click);
            // 
            // openFileImport
            // 
            this.openFileImport.FileName = "openFileDialog1";
            // 
            // form_mainCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 323);
            this.Controls.Add(this.listViewRequest);
            this.Controls.Add(this.listViewCRL);
            this.Controls.Add(this.listViewCerts);
            this.Controls.Add(this.treeViewCA);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "form_mainCA";
            this.Text = "Удостоверяющий Центр";
            this.Load += new System.EventHandler(this.mainCA_Load);
            this.rightClickActCert.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rightClickRevokedCert.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.rightClickCRL.ResumeLayout(false);
            this.rightClickRequest.ResumeLayout(false);
            this.contextMenuBtnCreat.ResumeLayout(false);
            this.contextMenuBtnService.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCA;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListView listViewCerts;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader serial;
        private System.Windows.Forms.ColumnHeader ValidFrom;
        private System.Windows.Forms.ColumnHeader ValidTo;
        private System.Windows.Forms.ColumnHeader Issuer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ActionMenu;
        private System.Windows.Forms.ToolStripMenuItem CreateNewCerts;
        private System.Windows.Forms.ToolStripMenuItem GenerateKey;
        private System.Windows.Forms.ImageList CAimageList;
        private System.Windows.Forms.ContextMenuStrip rightClickActCert;
        private System.Windows.Forms.ToolStripMenuItem RightClickOpen;
        private System.Windows.Forms.ToolStripMenuItem RightClickRevoke;
        private System.Windows.Forms.ToolStripMenuItem RightClickDelete;
        private System.Windows.Forms.ListView listViewCRL;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader reason;
        private System.Windows.Forms.ContextMenuStrip rightClickRevokedCert;
        private System.Windows.Forms.ToolStripMenuItem openRevokedCert;
        private System.Windows.Forms.ToolStripMenuItem cancelRevokedCert;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigCAConnect;
        private System.Windows.Forms.ToolStripMenuItem refreshCertsRevocationList;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListBtnMenu;
        private System.Windows.Forms.Button btnMenuCreat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMenuService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenuDelete;
        private System.Windows.Forms.Label labelBtnMenuDelete;
        private System.Windows.Forms.Button btnMenuOpen;
        private System.Windows.Forms.Label labelBtnMenuOpen;
        private System.Windows.Forms.Button btnMenuExport;
        private System.Windows.Forms.Label labelBtnMenuExport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripMenuItem CreateCertRequest;
        private System.Windows.Forms.ListView listViewRequest;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ContextMenuStrip rightClickCRL;
        private System.Windows.Forms.ContextMenuStrip rightClickRequest;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выдатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.Button btnMenuKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMenuImport;
        private System.Windows.Forms.Label labelBtnImport;
        private System.Windows.Forms.ToolStripMenuItem ExitProgramm;
        private System.Windows.Forms.ContextMenuStrip contextMenuBtnCreat;
        private System.Windows.Forms.ToolStripMenuItem самоподписанныйСертификатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросНаСертификатToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuBtnService;
        private System.Windows.Forms.ToolStripMenuItem настройкаДоступаКУЦToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileImport;
        private System.Windows.Forms.SaveFileDialog saveFileExport;
    }
}

