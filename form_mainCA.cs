using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Utilities;

namespace CA
{
    public partial class form_mainCA : Form
    {
        private string rootDirectory, revokeReason, certImportName, ExportFilename;   
        public static string certname, RequestName,fileDeletedName ;
        public static string rootCA;           // Корневой
        public static string ActivateCerts;    // Выданные
        public static string deActivateCerts;  // Отозванные
        public static string CRL;              // СОС
        public static string certsRequest;     // Запросы
        public static string pathKeyFolder;    // Каталог ключевого носителя
        public static bool selfSignCert = false ;
        public static bool certRequest = false;
        public static bool reCRL = false;
        private DateTime revokeDate;        
        X509Certificate x509cert;

        public form_mainCA()
        {
            InitializeComponent();
            
        }

        // Load all folder Inside
        List<DirectoryInfo> LoadAllFolderInside(String path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            List<DirectoryInfo> listChildDir = new List<DirectoryInfo>();
            foreach (DirectoryInfo dir in dirInfo.GetDirectories())
            {
                listChildDir.Add(dir);
            }
            return listChildDir;
        }

        //Load all Files
        FileInfo[] LoadAllFiles(String path)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(path);

            FileInfo[] fileInfolist = dirinfo.GetFiles();
            return fileInfolist;
        }

        // Add all ChildNode 
        void AddChildNode(TreeNode treenode, List<DirectoryInfo> listdir)
        {
            foreach (DirectoryInfo dir in listdir)
            {
                TreeNode node = new TreeNode();
                node.Text = dir.Name;
                node.Tag = dir.FullName;
                treenode.Nodes.Add(node);
            }
        }

        private void mainCA_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Для корректной работы программы необходимо указать домашнюю директорию."
                    + "\n" + "В домашней директории будут храниться:"
                    + "\n" + "корневой сертификат, сертификаты пользователей,"
                    + "\n" + "список отозванных сертификатов и ключи.",
                    "Сведение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Создавать домашняя директория
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                rootDirectory = folderBrowserDialog.SelectedPath;
            else
                this.Close();

            listViewCerts.Visible = true;
            listViewCRL.Visible = false;
            listViewRequest.Visible = false;

            btnMenuImport.Visible = false;
            labelBtnImport.Visible = false;
            btnMenuExport.Visible = false;
            labelBtnMenuExport.Visible = false;
            btnMenuOpen.Visible = false;
            labelBtnMenuOpen.Visible = false;
            btnMenuDelete.Visible = false;
            labelBtnMenuDelete.Visible = false;

            string CA = rootDirectory + @"\" + "Certification Authority";
            string Certificates = CA + @"\" + "1-Сертификаты";
            rootCA = CA + @"\" + "1-Сертификаты" + @"\" + "Корневой" + @"\";
            ActivateCerts = CA + @"\" + "1-Сертификаты" + @"\" + "Выданные" + @"\";
            deActivateCerts = CA + @"\" + "1-Сертификаты" + @"\" + "Отозванные" + @"\";
            CRL = CA + @"\" + "2-СОС" + @"\";
            certsRequest = CA + @"\" + "3-Запросы" + @"\";
            pathKeyFolder = CA + @"\" + "Ключи" + @"\";

            if (!Directory.Exists(Certificates))
                Directory.CreateDirectory(CA);
            if (!Directory.Exists(Certificates))
                Directory.CreateDirectory(Certificates);
            if (!Directory.Exists(rootCA))
                Directory.CreateDirectory(rootCA);
            if (!Directory.Exists(ActivateCerts))
                Directory.CreateDirectory(ActivateCerts);
            if (!Directory.Exists(deActivateCerts))
                Directory.CreateDirectory(deActivateCerts);
            if (!Directory.Exists(CRL))
                Directory.CreateDirectory(CRL);
            if (!Directory.Exists(certsRequest))
                Directory.CreateDirectory(certsRequest);
            if (!Directory.Exists(pathKeyFolder))
                Directory.CreateDirectory(pathKeyFolder);
            
            //Add CA Directory
            treeViewCA.ImageList = CAimageList;
            TreeNode certsNode = new TreeNode("Сертификаты");
            certsNode.ImageIndex = 0;
            certsNode.SelectedImageIndex = 0;
            certsNode.Tag = Certificates;
            
            TreeNode rootCANode = new TreeNode("Корневой");
            certsNode.Nodes.Add(rootCANode);
            rootCANode.ImageIndex = 3;
            rootCANode.SelectedImageIndex = 4;
            rootCANode.Tag = rootCA;

            TreeNode ActCertsNode = new TreeNode("Выданные");
            certsNode.Nodes.Add(ActCertsNode);
            ActCertsNode.ImageIndex = 3;
            ActCertsNode.SelectedImageIndex = 4;
            ActCertsNode.Tag = ActivateCerts;

            TreeNode deActCertsNode = new TreeNode("Отозванные");
            certsNode.Nodes.Add(deActCertsNode);
            deActCertsNode.ImageIndex = 3;
            deActCertsNode.SelectedImageIndex = 4;
            deActCertsNode.Tag = deActivateCerts;
                        
            treeViewCA.Nodes.Add(certsNode);

            TreeNode requestNode = new TreeNode("Запросы");
            requestNode.ImageIndex = 1;
            requestNode.SelectedImageIndex = 1;
            requestNode.Tag = certsRequest;
            treeViewCA.Nodes.Add(requestNode);

            TreeNode crlNode = new TreeNode("СОС");
            crlNode.ImageIndex = 2;
            crlNode.SelectedImageIndex = 2;
            crlNode.Tag = CRL;
            treeViewCA.Nodes.Add(crlNode);

            // create CRL.txt ; crlList.txt;Request.txt
            string CRL_txt = CRL + "CRL.txt";
            string crlList_txt = CRL + "crlList.txt";
            string Request_txt = certsRequest + "Request.txt";
            if (!File.Exists(CRL_txt))
            {
                FileStream fsCRL_txt = new FileStream(CRL_txt, FileMode.Create);
            }

            if (!File.Exists(crlList_txt))
            {
                FileStream fscrlList_txt = new FileStream(crlList_txt, FileMode.Create);
            }

            if (!File.Exists(Request_txt))
            {
                FileStream fsRequest_txt = new FileStream(Request_txt, FileMode.Create);
            }

        }

        private void RefreshList()
        {
            listViewCerts.Visible = true;
            listViewRequest.Visible = false;
            listViewCRL.Visible = false;

            TreeNode currnode = treeViewCA.SelectedNode;
            string nodeName = currnode.Text;
            listViewCerts.Items.Clear();
            FileInfo[] fileInfoList = LoadAllFiles((String)currnode.Tag);

            foreach (FileInfo fi in fileInfoList)
            {
                x509cert = X509Certificate.CreateFromCertFile(fi.FullName);
                getSubjectInfo subInfo = new getSubjectInfo();
                subInfo.set_Subject(x509cert.Subject);
                string subject = subInfo.get_CN();
                getSubjectInfo issInfo = new getSubjectInfo();
                issInfo.set_Subject(x509cert.Issuer);
                //ListViewItem item = new ListViewItem(x509cert.Subject);
                ListViewItem item = new ListViewItem(subject);
                item.SubItems.Add(x509cert.GetSerialNumberString());
                item.SubItems.Add(x509cert.GetEffectiveDateString());
                item.SubItems.Add(x509cert.GetExpirationDateString());
                item.SubItems.Add(issInfo.get_CN());
                item.Tag = fi.FullName;
                listViewCerts.Visible = true;
                listViewCRL.Visible = false;
                listViewRequest.Visible = false;
                if (nodeName == "Выданные")
                {
                    item.ImageIndex = 5;
                }
               
                if (nodeName == "Корневой")
                {
                    item.ImageIndex = 7;
                }
                listViewCerts.Items.Add(item);
            }
            
        }

        private void RefreshCRL()
        {
            listViewCerts.Visible = false;
            listViewRequest.Visible = false;
            listViewCRL.Visible = true;
            listViewCRL.Items.Clear();
            String[] line = File.ReadAllLines(CRL + "CRL.txt");
            foreach (String s in line)
            {
                String[] content = s.Split(new char[] { '#' });
                //MessageBox.Show(content[0] + "\n" + content[1].Replace("-","").Replace(":","").Replace(" ","") + "\n" + content[2]);
                ListViewItem item = new ListViewItem(content);
                item.ImageIndex = 6;
                listViewCRL.Items.Add(item);
            }
        }

        private void RefreshRequest()
        {
            listViewRequest.Visible = true;
            listViewCerts.Visible = false;
            listViewCRL.Visible = false;
            listViewRequest.Items.Clear();
            listViewRequest.ContextMenuStrip = rightClickRequest;
            String[] line = File.ReadAllLines(certsRequest + "Request.txt");
            foreach (String s in line)
            {
                String[] content = s.Split(new char[] { '#' });
                ListViewItem item = new ListViewItem(content);
                item.ImageIndex = 1;
                listViewRequest.Items.Add(item);
            }
        }

        private void RefreshCrlList()
        {
            listViewRequest.Visible = true;
            listViewCerts.Visible = false;
            listViewCRL.Visible = false;
            listViewRequest.Items.Clear();
            listViewRequest.ContextMenuStrip = rightClickCRL;
            String[] line = File.ReadAllLines(CRL + "crlList.txt");
            foreach (String s in line)
            {
                String[] content = s.Split(new char[] { '#' });
                ListViewItem item = new ListViewItem(content);
                item.ImageIndex = 2;
                listViewRequest.Items.Add(item);
            }
        }

        private void treeViewCA_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnMenuExport.Visible = false;
            labelBtnMenuExport.Visible = false;
            btnMenuOpen.Visible = false;
            labelBtnMenuOpen.Visible = false;
            btnMenuDelete.Visible = false;
            labelBtnMenuDelete.Visible = false;

            if (treeViewCA.SelectedNode.Text == "Корневой")
            {
                btnMenuImport.Visible = true;
                labelBtnImport.Visible = true;
                RefreshList();
            }
            if (treeViewCA.SelectedNode.Text == "Выданные")
            {
                btnMenuImport.Visible = true;
                labelBtnImport.Visible = true;
                RefreshList();
            }
            if (treeViewCA.SelectedNode.Text == "Отозванные")
            {
                btnMenuImport.Visible = false;
                labelBtnImport.Visible = false;
                RefreshCRL();
            }
            if (treeViewCA.SelectedNode.Text == "СОС")
            {
                btnMenuImport.Visible = false;
                labelBtnImport.Visible = false;
                string[] fileList = Directory.GetFiles(CRL);
                int countFile = 0;
                foreach (string fileName in fileList)
                {
                    FileInfo fi = new FileInfo(fileName);
                    if (fi.Extension == ".CRL") countFile = countFile + 1;
                }
                //MessageBox.Show(countFile.ToString());
                if (countFile == 0)
                {
                    reCRL = false;
                    form_CRLConfirm crlConfirm = new form_CRLConfirm();
                    crlConfirm.ShowDialog();
                }
                RefreshCrlList();
            }
            if (treeViewCA.SelectedNode.Text == "Запросы")
                RefreshRequest();
            
        }

        //---------------------ГЕНЕРАЦИЯ КЛЮЧА---------------------
        private void GenerateKey_Click(object sender, EventArgs e)
        {
            form_generateKey fGenKey = new form_generateKey();
            fGenKey.ShowDialog();
        }

        //---------------------НАСТРОЙКА ДОСТУПА К УЦ---------------------
        private void ConfigCAConnect_Click(object sender, EventArgs e)
        {
            form_CAConnect CAConnect = new form_CAConnect();
            CAConnect.ShowDialog();
        }

        //---------------------СОЗДАНИЕ СЕРТИФИКАТА---------------------
        private void CreateNewCerts_Click(object sender, EventArgs e)
        {
            selfSignCert = true;
            certRequest = false;
            //-----------------Check Key-----------------
            string[] fileList = Directory.GetFiles(pathKeyFolder);
            int countFile = 0;
            foreach (string fileName in fileList)
            {
                countFile = countFile + 1;
            }

            if (countFile == 0)
            {
                MessageBox.Show("Нет ключа в каталоге ключевого носителя. Необходимо создать ключ.", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_generateKey fGenkey = new form_generateKey();
                fGenkey.ShowDialog();
            }
            
            form_createCerts fCreateCert = new form_createCerts();
            fCreateCert.ShowDialog();
        }

        //-------------------ОБНОВЛЕНИЕ СОС--------------------------
        private void refreshCertsRevocationList_Click(object sender, EventArgs e)
        {
            form_RefreshCRL refreshCRL = new form_RefreshCRL();
            reCRL = true;
            refreshCRL.ShowDialog();
            
        }

        //-------------------СОЗДАНИЕ ЗАПРОСА НА СЕРТИФИКАТ--------------------------
        private void CreateCertRequest_Click(object sender, EventArgs e)
        {
            certRequest = true;
            selfSignCert = false;
            form_createCerts fCreate = new form_createCerts();
            fCreate.ShowDialog();
        }

        //-------------------ВЫХОД ПРОГРАММЫ--------------------------
        private void ExitProgramm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------О ПРОГРАММЕ--------------------------
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ПО Удостоверяющего Центра для PKI"
                        + "\n" + "Дипломный руководитель : П/п-к Можин С.В."
                        + "\n" + "Выполнил : К-т Нгуен Х.Х Группы С-05."
                        + "\n" + "Орел - 2014",
                        "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //-----------------------------RIGHT CLICK MENU -----------------------------

        //------------------1-rightClickActCert-------------------
        private void rightClickActCert_Opening(object sender, CancelEventArgs e)
        {
            if (listViewCerts.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void listViewCerts_MouseClick(object sender, MouseEventArgs e)
        {
            btnMenuExport.Visible = true;
            labelBtnMenuExport.Visible = true;
            btnMenuOpen.Visible = true;
            labelBtnMenuOpen.Visible = true;
            btnMenuDelete.Visible = true;
            labelBtnMenuDelete.Visible = true;

            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    rightClickActCert.Show(listView, e.Location);
                }

            }
        }

        
        // 1-Открывать сертификаты
        private void RightClickOpen_Click(object sender, EventArgs e)
        {
            certname = listViewCerts.SelectedItems[0].Tag.ToString();
            System.Diagnostics.Process.Start(certname);
        }
              
        // 1-Отозвать сертификаты
        private void RightClickRevoke_Click(object sender, EventArgs e)
        {
            form_RevokeConfirm revokeConf = new form_RevokeConfirm();
            certname = listViewCerts.SelectedItems[0].Tag.ToString();
            revokeConf.ShowDialog();
            revokeReason = form_RevokeReason.reasonRevoke;
            revokeDate = form_RevokeReason.dataRevoke;
            x509cert = X509Certificate.CreateFromCertFile(form_RevokeReason.certRevoke);
            ListViewItem item = new ListViewItem(x509cert.GetSerialNumberString());
            item.SubItems.Add(revokeDate.ToString("yy-MM-dd HH:mm:ss"));
            item.SubItems.Add(revokeReason);
            listViewCRL.Items.Add(item);

            // Write to CRL.txt
            StreamWriter sw = new StreamWriter(CRL + "CRL.txt",false);
            foreach (ListViewItem items in listViewCRL.Items)
            {
                sw.Write(items.SubItems[0].Text + "#");
                sw.Write(items.SubItems[1].Text + "#");
                sw.Write(items.SubItems[2].Text);
                sw.WriteLine();
            }
            sw.Close();
            RefreshList();
            
        }

        // 1-Удалить сертификаты
        private void RightClickDelete_Click(object sender, EventArgs e)
        {
            fileDeletedName = listViewCerts.SelectedItems[0].Tag.ToString();
            form_DeleteConfim fDelete = new form_DeleteConfim();
            fDelete.ShowDialog();
            if (form_DeleteConfim.deleleOK == true)
            {
                File.Delete(fileDeletedName);
                RefreshList();
            }
        }

        //------------------2-rightClickRevokedCert-------------------  
        private void rightClickRevokedCert_Opening(object sender, CancelEventArgs e)
        {
            if (listViewCRL.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void listViewCRL_MouseClick(object sender, MouseEventArgs e)
        {
            btnMenuExport.Visible = true;
            labelBtnMenuExport.Visible = true;
            btnMenuOpen.Visible = true;
            labelBtnMenuOpen.Visible = true;
            btnMenuDelete.Visible = true;
            labelBtnMenuDelete.Visible = true;

            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                    rightClickRevokedCert.Show(listView, e.Location);
                }

            }
        }
        // 2-Открывать сертификаты
        private void openRevokedCert_Click(object sender, EventArgs e)
        {
            string revokedCertName = deActivateCerts + listViewCRL.SelectedItems[0].Text +".CER";
            System.Diagnostics.Process.Start(revokedCertName);
        }

        // 2-Отмена отзыва сертификата
        private void cancelRevokedCert_Click(object sender, EventArgs e)
        {
            string revokedCertName = deActivateCerts + listViewCRL.SelectedItems[0].Text + ".CER";
            FileInfo fi = new FileInfo(revokedCertName);
            File.Move(revokedCertName, ActivateCerts + fi.Name);
            listViewCRL.SelectedItems[0].Remove();
            // Write to CRL.txt
            StreamWriter sw = new StreamWriter(CRL + "CRL.txt", false);
            foreach (ListViewItem items in listViewCRL.Items)
            {
                sw.Write(items.SubItems[0].Text + "#");
                sw.Write(items.SubItems[1].Text + "#");
                sw.Write(items.SubItems[2].Text);
                sw.WriteLine();
            }
            sw.Close();
            RefreshCRL();
        }

        // 2-Удалить
        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fileDeletedName = deActivateCerts + listViewCRL.SelectedItems[0].Text + ".CER";
            
            form_DeleteConfim fDelete = new form_DeleteConfim();
            fDelete.ShowDialog();
            if (form_DeleteConfim.deleleOK == true)
            {
                File.Delete(fileDeletedName);

                listViewCRL.SelectedItems[0].Remove();
                // Write to CRL.txt
                StreamWriter sw = new StreamWriter(CRL + "CRL.txt", false);
                foreach (ListViewItem items in listViewCRL.Items)
                {
                    sw.Write(items.SubItems[0].Text + "#");
                    sw.Write(items.SubItems[1].Text + "#");
                    sw.Write(items.SubItems[2].Text);
                    sw.WriteLine();
                }
                sw.Close();
                RefreshCRL();
            }
        }
        
        //------------------3-rightClickCRL-------------------
        private void rightClickCRL_Opening(object sender, CancelEventArgs e)
        {
            if (listViewRequest.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void listViewRequest_MouseClick(object sender, MouseEventArgs e)
        {
            btnMenuExport.Visible = true;
            labelBtnMenuExport.Visible = true;
            btnMenuOpen.Visible = true;
            labelBtnMenuOpen.Visible = true;
            btnMenuDelete.Visible = true;
            labelBtnMenuDelete.Visible = true;

            ListView listView = sender as ListView;
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    item.Selected = true;
                }

            }
        }
        
        // 3-Открывать
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string crlName = CRL + listViewRequest.SelectedItems[0].Text + ".CRL";
            System.Diagnostics.Process.Start(crlName);
        }

        // 3-Удалить
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileDeletedName = CRL + listViewRequest.SelectedItems[0].Text + ".CRL";
            form_DeleteConfim fDelete = new form_DeleteConfim();
            fDelete.ShowDialog();
            if (form_DeleteConfim.deleleOK == true)
            {
                File.Delete(fileDeletedName);
                listViewRequest.SelectedItems[0].Remove();

                // Write to crlList.txt
                StreamWriter sw = new StreamWriter(CRL + "crlList.txt", false);
                foreach (ListViewItem items in listViewRequest.Items)
                {
                    sw.Write(items.SubItems[0].Text + "#");
                    sw.Write(items.SubItems[1].Text);
                    sw.WriteLine();
                }
                sw.Close();
                RefreshCrlList();
            }
        }

        //------------------4-rightClickRequest-------------------

        private void rightClickRequest_Opening(object sender, CancelEventArgs e)
        {
            if (listViewRequest.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
        }
        // 4-Открывать
        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RequestName = certsRequest + listViewRequest.SelectedItems[0].Text +".CER";
            System.Diagnostics.Process.Start(RequestName);
        }

        // 4-Выдать
        private void выдатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_IssueRequestConfirm requestCorfirm = new form_IssueRequestConfirm();
            RequestName = certsRequest + listViewRequest.SelectedItems[0].Text ;
            requestCorfirm.ShowDialog();
            if (form_IssueRequest.issueConfirm == true)
            {
                File.Delete(RequestName + ".CER");
                listViewRequest.SelectedItems[0].Remove();

                // Write to Request.txt
                StreamWriter sw = new StreamWriter(certsRequest + "Request.txt", false);
                foreach (ListViewItem items in listViewRequest.Items)
                {
                    sw.Write(items.SubItems[0].Text + "#");
                    sw.Write(items.SubItems[1].Text);
                    sw.WriteLine();
                }
                sw.Close();
                RefreshRequest();
            }
        }

        // 4-Удалить
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fileDeletedName = certsRequest + listViewRequest.SelectedItems[0].Text + ".CER";
            form_DeleteConfim fDelete = new form_DeleteConfim();
            fDelete.ShowDialog();
            if (form_DeleteConfim.deleleOK == true)
            {
                File.Delete(fileDeletedName);
                listViewRequest.SelectedItems[0].Remove();

                // Write to Request.txt
                StreamWriter sw = new StreamWriter(certsRequest + "Request.txt", false);
                foreach (ListViewItem items in listViewRequest.Items)
                {
                    sw.Write(items.SubItems[0].Text + "#");
                    sw.Write(items.SubItems[1].Text);
                    sw.WriteLine();
                }
                sw.Close();
                RefreshRequest();
            }
        }

        //-----------------------------BUTTON MENU -----------------------------
        // Генерация ключа
        private void btnMenuKey_Click(object sender, EventArgs e)
        {
            form_generateKey fGenKey = new form_generateKey();
            fGenKey.ShowDialog();
        }
        
        // Создание
        private void btnMenuCreat_Click(object sender, EventArgs e)
        {
            contextMenuBtnCreat.Show(this.btnMenuCreat, new Point(btnMenuCreat.Location.X, btnMenuCreat.Location.Y + btnMenuCreat.Height));
        }

        private void самоподписанныйСертификатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selfSignCert = true;
            certRequest = false;
            //-----------------Check Key-----------------
            string[] fileList = Directory.GetFiles(pathKeyFolder);
            int countFile = 0;
            foreach (string fileName in fileList)
            {
                countFile = countFile + 1;
            }

            if (countFile == 0)
            {
                MessageBox.Show("Нет ключа в каталоге ключевого носителя. Необходимо создать ключ.", "Сведение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_generateKey fGenkey = new form_generateKey();
                fGenkey.ShowDialog();
            }

            form_createCerts fCreateCert = new form_createCerts();
            fCreateCert.ShowDialog();
        }

        private void запросНаСертификатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            certRequest = true;
            selfSignCert = false;
            form_createCerts fCreate = new form_createCerts();
            fCreate.ShowDialog();
        }

        // Сервисы
        private void btnMenuService_Click(object sender, EventArgs e)
        {
            contextMenuBtnService.Show(this.btnMenuService, new Point(btnMenuService.Location.X, btnMenuService.Location.Y + btnMenuService.Height));
        }

        private void настройкаДоступаКУЦToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_CAConnect CAConnect = new form_CAConnect();
            CAConnect.ShowDialog();
        }

        // Импорт сертификатов
        private void btnMenuImport_Click(object sender, EventArgs e)
        {
            openFileImport.Filter = "Сертификат(*.CER)|*.CER*";
            openFileImport.DefaultExt = "CER";
            openFileImport.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileImport.ShowDialog() == DialogResult.OK)
            {
                certImportName = openFileImport.FileName;
                form_ImportCert fImport = new form_ImportCert();
                fImport.ShowDialog();
            }

            if (form_ImportCert.ImportCertChecked == true)
            {
                X509Certificate certImport = X509Certificate.CreateFromCertFile(certImportName);
                FileInfo fi = new FileInfo(certImportName);

                if (form_ImportCert.ImportRootCA == true)
                {
                    File.Copy(certImportName, rootCA + certImport.GetSerialNumberString() + ".CER", true);
                }

                if (form_ImportCert.ImportActiveCert == true)
                {
                    File.Copy(certImportName, ActivateCerts + certImport.GetSerialNumberString() + ".CER", true);
                }

                MessageBox.Show("Выбранный сертификат импортировал успешно !", " Свведение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // Экспорт сертификатов
        private void btnMenuExport_Click(object sender, EventArgs e)
        {
            
            if (treeViewCA.SelectedNode.Text == "Корневой" || treeViewCA.SelectedNode.Text == "Выданные" || treeViewCA.SelectedNode.Text == "Отозванные" || treeViewCA.SelectedNode.Text == "Запросы")
            {
                saveFileExport.Filter = "Сертификат(*.CER)|*.CER*";
                saveFileExport.DefaultExt = "CER";
                saveFileExport.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if (treeViewCA.SelectedNode.Text == "СОС")
            {
                saveFileExport.Filter = "СОС(*.CRL)|*.CRL*";
                saveFileExport.DefaultExt = "CRL";
                saveFileExport.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }

            if (treeViewCA.SelectedNode.Text == "Корневой" || treeViewCA.SelectedNode.Text == "Выданные")
            {
                ExportFilename = listViewCerts.SelectedItems[0].Tag.ToString();
            }

            if (treeViewCA.SelectedNode.Text == "Отозванные")
            {
                ExportFilename = deActivateCerts + listViewCRL.SelectedItems[0].Text + ".CER";
            }

            if (treeViewCA.SelectedNode.Text == "СОС")
            {
                ExportFilename = CRL + listViewRequest.SelectedItems[0].Text + ".CRL";
            }

            if (treeViewCA.SelectedNode.Text == "Запросы")
            {
                ExportFilename = certsRequest + listViewRequest.SelectedItems[0].Text + ".CER";
            }
                       
            if (saveFileExport.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ExportFilename, saveFileExport.FileName, true);
                MessageBox.Show("Выбранный файл экспортировал успешно !", " Свведение ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        // Открыть
        private void btnMenuOpen_Click(object sender, EventArgs e)
        {
            
            if (treeViewCA.SelectedNode.Text == "Корневой" || treeViewCA.SelectedNode.Text == "Выданные")
            {
                ExportFilename = listViewCerts.SelectedItems[0].Tag.ToString();
            }

            if (treeViewCA.SelectedNode.Text == "Отозванные")
            {
                ExportFilename = deActivateCerts + listViewCRL.SelectedItems[0].Text + ".CER";
            }

            if (treeViewCA.SelectedNode.Text == "СОС")
            {
                ExportFilename = CRL + listViewRequest.SelectedItems[0].Text + ".CRL";
            }

            if (treeViewCA.SelectedNode.Text == "Запросы")
            {
                ExportFilename = certsRequest + listViewRequest.SelectedItems[0].Text + ".CER";
            }

            System.Diagnostics.Process.Start(ExportFilename);
        }

        // Удалить
        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            if (treeViewCA.SelectedNode.Text == "Корневой" || treeViewCA.SelectedNode.Text == "Выданные")
            {
                fileDeletedName = listViewCerts.SelectedItems[0].Tag.ToString();
                form_DeleteConfim fDelete = new form_DeleteConfim();
                fDelete.ShowDialog();
                if (form_DeleteConfim.deleleOK == true)
                {
                    File.Delete(fileDeletedName);
                    RefreshList();
                }
            }

            if (treeViewCA.SelectedNode.Text == "Отозванные")
            {
                fileDeletedName = deActivateCerts + listViewCRL.SelectedItems[0].Text + ".CER";

                form_DeleteConfim fDelete = new form_DeleteConfim();
                fDelete.ShowDialog();
                if (form_DeleteConfim.deleleOK == true)
                {
                    File.Delete(fileDeletedName);

                    listViewCRL.SelectedItems[0].Remove();
                    // Write to CRL.txt
                    StreamWriter sw = new StreamWriter(CRL + "CRL.txt", false);
                    foreach (ListViewItem items in listViewCRL.Items)
                    {
                        sw.Write(items.SubItems[0].Text + "#");
                        sw.Write(items.SubItems[1].Text + "#");
                        sw.Write(items.SubItems[2].Text);
                        sw.WriteLine();
                    }
                    sw.Close();
                    RefreshCRL();
                }
            }

            if (treeViewCA.SelectedNode.Text == "СОС")
            {
                fileDeletedName = CRL + listViewRequest.SelectedItems[0].Text + ".CRL";
                form_DeleteConfim fDelete = new form_DeleteConfim();
                fDelete.ShowDialog();
                if (form_DeleteConfim.deleleOK == true)
                {
                    File.Delete(fileDeletedName);
                    listViewRequest.SelectedItems[0].Remove();

                    // Write to crlList.txt
                    StreamWriter sw = new StreamWriter(CRL + "crlList.txt", false);
                    foreach (ListViewItem items in listViewRequest.Items)
                    {
                        sw.Write(items.SubItems[0].Text + "#");
                        sw.Write(items.SubItems[1].Text);
                        sw.WriteLine();
                    }
                    sw.Close();
                    RefreshCrlList();
                }
            }

            if (treeViewCA.SelectedNode.Text == "Запросы")
            {
                fileDeletedName = certsRequest + listViewRequest.SelectedItems[0].Text + ".CER";
                form_DeleteConfim fDelete = new form_DeleteConfim();
                fDelete.ShowDialog();
                if (form_DeleteConfim.deleleOK == true)
                {
                    File.Delete(fileDeletedName);
                    listViewRequest.SelectedItems[0].Remove();

                    // Write to Request.txt
                    StreamWriter sw = new StreamWriter(certsRequest + "Request.txt", false);
                    foreach (ListViewItem items in listViewRequest.Items)
                    {
                        sw.Write(items.SubItems[0].Text + "#");
                        sw.Write(items.SubItems[1].Text);
                        sw.WriteLine();
                    }
                    sw.Close();
                    RefreshRequest();
                }
            }
        }

        // Обновить
        private void btnMenuRefresh_Click(object sender, EventArgs e)
        {
            if (treeViewCA.SelectedNode.Text == "Корневой" || treeViewCA.SelectedNode.Text == "Выданные")
            {
                RefreshList();                
            }

            if (treeViewCA.SelectedNode.Text == "Отозванные")
            {
                RefreshCRL();                
            }

            if (treeViewCA.SelectedNode.Text == "СОС")
            {
                RefreshCrlList();             
            }

            if (treeViewCA.SelectedNode.Text == "Запросы")
            {
                RefreshRequest();                
            }
        }

        

        

        

        

        

        

        

       

       

       


       

       


       
       
      
        
    }
}
