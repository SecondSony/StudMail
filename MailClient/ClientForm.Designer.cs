namespace MailClient
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lettersPage = new System.Windows.Forms.TabPage();
            this.msgLetterPanel = new System.Windows.Forms.Panel();
            this.letterReadTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.letterReadOptionTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.keySignCheckBtn = new System.Windows.Forms.Button();
            this.decryptMsgBtn = new System.Windows.Forms.Button();
            this.detachFilesBtn = new System.Windows.Forms.Button();
            this.msgReadWeb = new System.Windows.Forms.WebBrowser();
            this.detachFilesList = new System.Windows.Forms.ListView();
            this.letterHeaderTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.senderEmailLbl = new System.Windows.Forms.Label();
            this.themeReadLbl = new System.Windows.Forms.Label();
            this.senderEmailTxt = new System.Windows.Forms.TextBox();
            this.themeReadTxt = new System.Windows.Forms.TextBox();
            this.lettersTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.msgListOptionsPanel = new System.Windows.Forms.Panel();
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.lettersList = new System.Windows.Forms.ListView();
            this.boxesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senderPage = new System.Windows.Forms.TabPage();
            this.msgSendTxt = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.underlineBtn = new System.Windows.Forms.Button();
            this.italicBtn = new System.Windows.Forms.Button();
            this.boldBtn = new System.Windows.Forms.Button();
            this.strikeOutBtn = new System.Windows.Forms.Button();
            this.alignRightBtn = new System.Windows.Forms.Button();
            this.alignCenterBtn = new System.Windows.Forms.Button();
            this.alignLeftBtn = new System.Windows.Forms.Button();
            this.fontSizeBtn = new System.Windows.Forms.NumericUpDown();
            this.fontsCmb = new System.Windows.Forms.ComboBox();
            this.themeTableLabel = new System.Windows.Forms.TableLayoutPanel();
            this.themeSendLbl = new System.Windows.Forms.Label();
            this.themeSendTxt = new System.Windows.Forms.TextBox();
            this.receiverTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.receiverEmailLbl = new System.Windows.Forms.Label();
            this.receiverEmailTxt = new System.Windows.Forms.TextBox();
            this.letterSendOptionsTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.attachFilesList = new System.Windows.Forms.ListView();
            this.attachFilesBtn = new System.Windows.Forms.Button();
            this.encryptMsgBtn = new System.Windows.Forms.Button();
            this.keySignMsgBtn = new System.Windows.Forms.Button();
            this.letterSendBtn = new System.Windows.Forms.Button();
            this.detachLastFileBtn = new System.Windows.Forms.Button();
            this.keysPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.keysTable = new System.Windows.Forms.DataGridView();
            this.selectedKeyCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateSignCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicSignCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicRemoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicSignRemoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.remoteGrp = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.keysRemoteTxt = new System.Windows.Forms.TextBox();
            this.keysRemoteSignTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.genKeysGrp = new System.Windows.Forms.GroupBox();
            this.genKeySignBtn = new System.Windows.Forms.Button();
            this.genKeyBtn = new System.Windows.Forms.Button();
            this.removeKeysBtn = new System.Windows.Forms.Button();
            this.addKeysBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.keysPublicSignTxt = new System.Windows.Forms.TextBox();
            this.keysPrivateSignTxt = new System.Windows.Forms.TextBox();
            this.keysPublicTxt = new System.Windows.Forms.TextBox();
            this.keysPrivateTxt = new System.Windows.Forms.TextBox();
            this.keysEmailTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.serversPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeServersBtn = new System.Windows.Forms.Button();
            this.addServerBtn = new System.Windows.Forms.Button();
            this.sslCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pop3PortTxt = new System.Windows.Forms.TextBox();
            this.pop3HostTxt = new System.Windows.Forms.TextBox();
            this.imapPortTxt = new System.Windows.Forms.TextBox();
            this.imapHostTxt = new System.Windows.Forms.TextBox();
            this.smtpPortTxt = new System.Windows.Forms.TextBox();
            this.smtpHostTxt = new System.Windows.Forms.TextBox();
            this.domainTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serversTable = new System.Windows.Forms.DataGridView();
            this.selectedServerCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.domainCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpHostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smtpPortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imapHostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imapPortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pop3HostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pop3PortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sslCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkInputPrv = new System.Windows.Forms.ErrorProvider(this.components);
            this.tooltipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.updateBooksWorker = new System.ComponentModel.BackgroundWorker();
            this.updateServersWorker = new System.ComponentModel.BackgroundWorker();
            this.lettersStatus = new System.Windows.Forms.StatusStrip();
            this.lettersStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.lettersPage.SuspendLayout();
            this.msgLetterPanel.SuspendLayout();
            this.letterReadTablePanel.SuspendLayout();
            this.letterReadOptionTablePanel.SuspendLayout();
            this.letterHeaderTablePanel.SuspendLayout();
            this.lettersTablePanel.SuspendLayout();
            this.msgListOptionsPanel.SuspendLayout();
            this.senderPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBtn)).BeginInit();
            this.themeTableLabel.SuspendLayout();
            this.receiverTablePanel.SuspendLayout();
            this.letterSendOptionsTablePanel.SuspendLayout();
            this.keysPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.remoteGrp.SuspendLayout();
            this.genKeysGrp.SuspendLayout();
            this.serversPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInputPrv)).BeginInit();
            this.lettersStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lettersPage);
            this.tabControl1.Controls.Add(this.senderPage);
            this.tabControl1.Controls.Add(this.keysPage);
            this.tabControl1.Controls.Add(this.serversPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 553);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // lettersPage
            // 
            this.lettersPage.Controls.Add(this.msgLetterPanel);
            this.lettersPage.Controls.Add(this.lettersTablePanel);
            this.lettersPage.Controls.Add(this.boxesList);
            this.lettersPage.Controls.Add(this.lettersStatus);
            this.lettersPage.Location = new System.Drawing.Point(4, 25);
            this.lettersPage.Name = "lettersPage";
            this.lettersPage.Padding = new System.Windows.Forms.Padding(3);
            this.lettersPage.Size = new System.Drawing.Size(1174, 524);
            this.lettersPage.TabIndex = 0;
            this.lettersPage.Text = "Письма";
            this.lettersPage.UseVisualStyleBackColor = true;
            // 
            // msgLetterPanel
            // 
            this.msgLetterPanel.BackColor = System.Drawing.SystemColors.Control;
            this.msgLetterPanel.Controls.Add(this.letterReadTablePanel);
            this.msgLetterPanel.Controls.Add(this.letterHeaderTablePanel);
            this.msgLetterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgLetterPanel.Location = new System.Drawing.Point(453, 3);
            this.msgLetterPanel.Name = "msgLetterPanel";
            this.msgLetterPanel.Size = new System.Drawing.Size(718, 492);
            this.msgLetterPanel.TabIndex = 5;
            // 
            // letterReadTablePanel
            // 
            this.letterReadTablePanel.ColumnCount = 1;
            this.letterReadTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.letterReadTablePanel.Controls.Add(this.letterReadOptionTablePanel, 0, 2);
            this.letterReadTablePanel.Controls.Add(this.msgReadWeb, 0, 0);
            this.letterReadTablePanel.Controls.Add(this.detachFilesList, 0, 1);
            this.letterReadTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letterReadTablePanel.Location = new System.Drawing.Point(0, 60);
            this.letterReadTablePanel.Name = "letterReadTablePanel";
            this.letterReadTablePanel.RowCount = 3;
            this.letterReadTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.letterReadTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.letterReadTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.letterReadTablePanel.Size = new System.Drawing.Size(718, 432);
            this.letterReadTablePanel.TabIndex = 5;
            // 
            // letterReadOptionTablePanel
            // 
            this.letterReadOptionTablePanel.ColumnCount = 3;
            this.letterReadOptionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.letterReadOptionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.letterReadOptionTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.letterReadOptionTablePanel.Controls.Add(this.keySignCheckBtn, 2, 0);
            this.letterReadOptionTablePanel.Controls.Add(this.decryptMsgBtn, 1, 0);
            this.letterReadOptionTablePanel.Controls.Add(this.detachFilesBtn, 0, 0);
            this.letterReadOptionTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letterReadOptionTablePanel.Location = new System.Drawing.Point(1, 398);
            this.letterReadOptionTablePanel.Margin = new System.Windows.Forms.Padding(1);
            this.letterReadOptionTablePanel.Name = "letterReadOptionTablePanel";
            this.letterReadOptionTablePanel.RowCount = 1;
            this.letterReadOptionTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.letterReadOptionTablePanel.Size = new System.Drawing.Size(716, 33);
            this.letterReadOptionTablePanel.TabIndex = 9;
            // 
            // keySignCheckBtn
            // 
            this.keySignCheckBtn.BackgroundImage = global::MailClient.Properties.Resources.encrypt_sign_48px;
            this.keySignCheckBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keySignCheckBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keySignCheckBtn.FlatAppearance.BorderSize = 0;
            this.keySignCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySignCheckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keySignCheckBtn.Location = new System.Drawing.Point(477, 1);
            this.keySignCheckBtn.Margin = new System.Windows.Forms.Padding(1);
            this.keySignCheckBtn.Name = "keySignCheckBtn";
            this.keySignCheckBtn.Size = new System.Drawing.Size(238, 31);
            this.keySignCheckBtn.TabIndex = 11;
            this.tooltipHelper.SetToolTip(this.keySignCheckBtn, "Проверить цифровую подпись");
            this.keySignCheckBtn.UseVisualStyleBackColor = true;
            // 
            // decryptMsgBtn
            // 
            this.decryptMsgBtn.BackgroundImage = global::MailClient.Properties.Resources.encrypt_48px;
            this.decryptMsgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.decryptMsgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptMsgBtn.FlatAppearance.BorderSize = 0;
            this.decryptMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptMsgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decryptMsgBtn.Location = new System.Drawing.Point(239, 1);
            this.decryptMsgBtn.Margin = new System.Windows.Forms.Padding(1);
            this.decryptMsgBtn.Name = "decryptMsgBtn";
            this.decryptMsgBtn.Size = new System.Drawing.Size(236, 31);
            this.decryptMsgBtn.TabIndex = 10;
            this.tooltipHelper.SetToolTip(this.decryptMsgBtn, "Расшифровать");
            this.decryptMsgBtn.UseVisualStyleBackColor = true;
            this.decryptMsgBtn.Click += new System.EventHandler(this.decryptMsgBtn_Click);
            // 
            // detachFilesBtn
            // 
            this.detachFilesBtn.BackgroundImage = global::MailClient.Properties.Resources.attach_48px;
            this.detachFilesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.detachFilesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detachFilesBtn.FlatAppearance.BorderSize = 0;
            this.detachFilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detachFilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.detachFilesBtn.Location = new System.Drawing.Point(1, 1);
            this.detachFilesBtn.Margin = new System.Windows.Forms.Padding(1);
            this.detachFilesBtn.Name = "detachFilesBtn";
            this.detachFilesBtn.Size = new System.Drawing.Size(236, 31);
            this.detachFilesBtn.TabIndex = 9;
            this.tooltipHelper.SetToolTip(this.detachFilesBtn, "Открепить файлы");
            this.detachFilesBtn.UseVisualStyleBackColor = true;
            this.detachFilesBtn.Click += new System.EventHandler(this.detachFilesBtn_Click);
            // 
            // msgReadWeb
            // 
            this.msgReadWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgReadWeb.Location = new System.Drawing.Point(3, 3);
            this.msgReadWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.msgReadWeb.Name = "msgReadWeb";
            this.msgReadWeb.Size = new System.Drawing.Size(712, 331);
            this.msgReadWeb.TabIndex = 7;
            // 
            // detachFilesList
            // 
            this.detachFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detachFilesList.HideSelection = false;
            this.detachFilesList.Location = new System.Drawing.Point(3, 340);
            this.detachFilesList.MultiSelect = false;
            this.detachFilesList.Name = "detachFilesList";
            this.detachFilesList.Size = new System.Drawing.Size(712, 54);
            this.detachFilesList.TabIndex = 8;
            this.detachFilesList.UseCompatibleStateImageBehavior = false;
            // 
            // letterHeaderTablePanel
            // 
            this.letterHeaderTablePanel.BackColor = System.Drawing.SystemColors.Window;
            this.letterHeaderTablePanel.ColumnCount = 2;
            this.letterHeaderTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.letterHeaderTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.letterHeaderTablePanel.Controls.Add(this.senderEmailLbl, 0, 0);
            this.letterHeaderTablePanel.Controls.Add(this.themeReadLbl, 0, 1);
            this.letterHeaderTablePanel.Controls.Add(this.senderEmailTxt, 1, 0);
            this.letterHeaderTablePanel.Controls.Add(this.themeReadTxt, 1, 1);
            this.letterHeaderTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterHeaderTablePanel.Location = new System.Drawing.Point(0, 0);
            this.letterHeaderTablePanel.Name = "letterHeaderTablePanel";
            this.letterHeaderTablePanel.RowCount = 2;
            this.letterHeaderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.letterHeaderTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.letterHeaderTablePanel.Size = new System.Drawing.Size(718, 60);
            this.letterHeaderTablePanel.TabIndex = 5;
            // 
            // senderEmailLbl
            // 
            this.senderEmailLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.senderEmailLbl.Location = new System.Drawing.Point(3, 0);
            this.senderEmailLbl.Name = "senderEmailLbl";
            this.senderEmailLbl.Size = new System.Drawing.Size(64, 30);
            this.senderEmailLbl.TabIndex = 0;
            this.senderEmailLbl.Text = "От кого:";
            this.senderEmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // themeReadLbl
            // 
            this.themeReadLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeReadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.themeReadLbl.Location = new System.Drawing.Point(3, 30);
            this.themeReadLbl.Name = "themeReadLbl";
            this.themeReadLbl.Size = new System.Drawing.Size(64, 30);
            this.themeReadLbl.TabIndex = 0;
            this.themeReadLbl.Text = "Тема:";
            this.themeReadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // senderEmailTxt
            // 
            this.senderEmailTxt.BackColor = System.Drawing.SystemColors.Window;
            this.senderEmailTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senderEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.senderEmailTxt.Location = new System.Drawing.Point(73, 3);
            this.senderEmailTxt.Name = "senderEmailTxt";
            this.senderEmailTxt.ReadOnly = true;
            this.senderEmailTxt.Size = new System.Drawing.Size(642, 26);
            this.senderEmailTxt.TabIndex = 5;
            // 
            // themeReadTxt
            // 
            this.themeReadTxt.BackColor = System.Drawing.SystemColors.Window;
            this.themeReadTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeReadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.themeReadTxt.Location = new System.Drawing.Point(73, 33);
            this.themeReadTxt.Name = "themeReadTxt";
            this.themeReadTxt.ReadOnly = true;
            this.themeReadTxt.Size = new System.Drawing.Size(642, 26);
            this.themeReadTxt.TabIndex = 6;
            // 
            // lettersTablePanel
            // 
            this.lettersTablePanel.ColumnCount = 1;
            this.lettersTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lettersTablePanel.Controls.Add(this.msgListOptionsPanel, 0, 1);
            this.lettersTablePanel.Controls.Add(this.lettersList, 0, 0);
            this.lettersTablePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lettersTablePanel.Location = new System.Drawing.Point(153, 3);
            this.lettersTablePanel.Name = "lettersTablePanel";
            this.lettersTablePanel.RowCount = 2;
            this.lettersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lettersTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.lettersTablePanel.Size = new System.Drawing.Size(300, 492);
            this.lettersTablePanel.TabIndex = 1;
            // 
            // msgListOptionsPanel
            // 
            this.msgListOptionsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.msgListOptionsPanel.Controls.Add(this.rightBtn);
            this.msgListOptionsPanel.Controls.Add(this.leftBtn);
            this.msgListOptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgListOptionsPanel.Location = new System.Drawing.Point(1, 458);
            this.msgListOptionsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.msgListOptionsPanel.Name = "msgListOptionsPanel";
            this.msgListOptionsPanel.Size = new System.Drawing.Size(298, 33);
            this.msgListOptionsPanel.TabIndex = 2;
            // 
            // rightBtn
            // 
            this.rightBtn.BackgroundImage = global::MailClient.Properties.Resources.right_48px;
            this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBtn.FlatAppearance.BorderSize = 0;
            this.rightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rightBtn.Location = new System.Drawing.Point(153, 0);
            this.rightBtn.Margin = new System.Windows.Forms.Padding(1);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(145, 33);
            this.rightBtn.TabIndex = 3;
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.BackgroundImage = global::MailClient.Properties.Resources.left_48px;
            this.leftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBtn.FlatAppearance.BorderSize = 0;
            this.leftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leftBtn.Location = new System.Drawing.Point(0, 0);
            this.leftBtn.Margin = new System.Windows.Forms.Padding(1);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(145, 33);
            this.leftBtn.TabIndex = 2;
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // lettersList
            // 
            this.lettersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lettersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lettersList.HideSelection = false;
            this.lettersList.Location = new System.Drawing.Point(1, 1);
            this.lettersList.Margin = new System.Windows.Forms.Padding(1);
            this.lettersList.MultiSelect = false;
            this.lettersList.Name = "lettersList";
            this.lettersList.Size = new System.Drawing.Size(298, 455);
            this.lettersList.TabIndex = 1;
            this.lettersList.UseCompatibleStateImageBehavior = false;
            this.lettersList.View = System.Windows.Forms.View.List;
            this.lettersList.SelectedIndexChanged += new System.EventHandler(this.lettersList_SelectedIndexChanged);
            // 
            // boxesList
            // 
            this.boxesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(241)))));
            this.boxesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.boxesList.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.boxesList.HideSelection = false;
            this.boxesList.Location = new System.Drawing.Point(3, 3);
            this.boxesList.MultiSelect = false;
            this.boxesList.Name = "boxesList";
            this.boxesList.Size = new System.Drawing.Size(150, 492);
            this.boxesList.TabIndex = 0;
            this.boxesList.UseCompatibleStateImageBehavior = false;
            this.boxesList.View = System.Windows.Forms.View.List;
            this.boxesList.SelectedIndexChanged += new System.EventHandler(this.boxesList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 145;
            // 
            // senderPage
            // 
            this.senderPage.BackColor = System.Drawing.SystemColors.Control;
            this.senderPage.Controls.Add(this.msgSendTxt);
            this.senderPage.Controls.Add(this.panel4);
            this.senderPage.Controls.Add(this.themeTableLabel);
            this.senderPage.Controls.Add(this.receiverTablePanel);
            this.senderPage.Controls.Add(this.letterSendOptionsTablePanel);
            this.senderPage.Location = new System.Drawing.Point(4, 25);
            this.senderPage.Name = "senderPage";
            this.senderPage.Padding = new System.Windows.Forms.Padding(3);
            this.senderPage.Size = new System.Drawing.Size(1174, 524);
            this.senderPage.TabIndex = 1;
            this.senderPage.Text = "Отправка письма";
            // 
            // msgSendTxt
            // 
            this.msgSendTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgSendTxt.Location = new System.Drawing.Point(3, 108);
            this.msgSendTxt.Name = "msgSendTxt";
            this.msgSendTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.msgSendTxt.Size = new System.Drawing.Size(1168, 363);
            this.msgSendTxt.TabIndex = 11;
            this.msgSendTxt.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.underlineBtn);
            this.panel4.Controls.Add(this.italicBtn);
            this.panel4.Controls.Add(this.boldBtn);
            this.panel4.Controls.Add(this.strikeOutBtn);
            this.panel4.Controls.Add(this.alignRightBtn);
            this.panel4.Controls.Add(this.alignCenterBtn);
            this.panel4.Controls.Add(this.alignLeftBtn);
            this.panel4.Controls.Add(this.fontSizeBtn);
            this.panel4.Controls.Add(this.fontsCmb);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 45);
            this.panel4.TabIndex = 3;
            // 
            // underlineBtn
            // 
            this.underlineBtn.BackColor = System.Drawing.SystemColors.Control;
            this.underlineBtn.BackgroundImage = global::MailClient.Properties.Resources.underline_32px;
            this.underlineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.underlineBtn.FlatAppearance.BorderSize = 0;
            this.underlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineBtn.Location = new System.Drawing.Point(622, 7);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(30, 30);
            this.underlineBtn.TabIndex = 9;
            this.tooltipHelper.SetToolTip(this.underlineBtn, "Подчёркнутый");
            this.underlineBtn.UseVisualStyleBackColor = false;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.BackColor = System.Drawing.SystemColors.Control;
            this.italicBtn.BackgroundImage = global::MailClient.Properties.Resources.italic_48px;
            this.italicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.italicBtn.FlatAppearance.BorderSize = 0;
            this.italicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italicBtn.Location = new System.Drawing.Point(586, 7);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(30, 30);
            this.italicBtn.TabIndex = 8;
            this.tooltipHelper.SetToolTip(this.italicBtn, "Курсив");
            this.italicBtn.UseVisualStyleBackColor = false;
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // boldBtn
            // 
            this.boldBtn.BackColor = System.Drawing.SystemColors.Control;
            this.boldBtn.BackgroundImage = global::MailClient.Properties.Resources.bold_52px;
            this.boldBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boldBtn.FlatAppearance.BorderSize = 0;
            this.boldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldBtn.Location = new System.Drawing.Point(550, 7);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(30, 30);
            this.boldBtn.TabIndex = 7;
            this.tooltipHelper.SetToolTip(this.boldBtn, "Полужирный");
            this.boldBtn.UseVisualStyleBackColor = false;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // strikeOutBtn
            // 
            this.strikeOutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.strikeOutBtn.BackgroundImage = global::MailClient.Properties.Resources.strikeout_52px;
            this.strikeOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.strikeOutBtn.FlatAppearance.BorderSize = 0;
            this.strikeOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strikeOutBtn.Location = new System.Drawing.Point(658, 7);
            this.strikeOutBtn.Name = "strikeOutBtn";
            this.strikeOutBtn.Size = new System.Drawing.Size(35, 35);
            this.strikeOutBtn.TabIndex = 10;
            this.tooltipHelper.SetToolTip(this.strikeOutBtn, "Вычеркнутый");
            this.strikeOutBtn.UseVisualStyleBackColor = false;
            this.strikeOutBtn.Click += new System.EventHandler(this.strikeOutBtn_Click);
            // 
            // alignRightBtn
            // 
            this.alignRightBtn.BackColor = System.Drawing.SystemColors.Control;
            this.alignRightBtn.BackgroundImage = global::MailClient.Properties.Resources.align_right_64px;
            this.alignRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alignRightBtn.FlatAppearance.BorderSize = 0;
            this.alignRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignRightBtn.Location = new System.Drawing.Point(447, 3);
            this.alignRightBtn.Name = "alignRightBtn";
            this.alignRightBtn.Size = new System.Drawing.Size(35, 35);
            this.alignRightBtn.TabIndex = 6;
            this.tooltipHelper.SetToolTip(this.alignRightBtn, "Выровнять по правому краю");
            this.alignRightBtn.UseVisualStyleBackColor = false;
            this.alignRightBtn.Click += new System.EventHandler(this.alignRightBtn_Click);
            // 
            // alignCenterBtn
            // 
            this.alignCenterBtn.BackColor = System.Drawing.SystemColors.Control;
            this.alignCenterBtn.BackgroundImage = global::MailClient.Properties.Resources.align_center_64px;
            this.alignCenterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alignCenterBtn.FlatAppearance.BorderSize = 0;
            this.alignCenterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignCenterBtn.Location = new System.Drawing.Point(406, 3);
            this.alignCenterBtn.Name = "alignCenterBtn";
            this.alignCenterBtn.Size = new System.Drawing.Size(35, 35);
            this.alignCenterBtn.TabIndex = 5;
            this.tooltipHelper.SetToolTip(this.alignCenterBtn, "Выровнять по центру");
            this.alignCenterBtn.UseVisualStyleBackColor = false;
            this.alignCenterBtn.Click += new System.EventHandler(this.alignCenterBtn_Click);
            // 
            // alignLeftBtn
            // 
            this.alignLeftBtn.BackColor = System.Drawing.SystemColors.Control;
            this.alignLeftBtn.BackgroundImage = global::MailClient.Properties.Resources.align_left_64px;
            this.alignLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alignLeftBtn.FlatAppearance.BorderSize = 0;
            this.alignLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alignLeftBtn.Location = new System.Drawing.Point(365, 3);
            this.alignLeftBtn.Name = "alignLeftBtn";
            this.alignLeftBtn.Size = new System.Drawing.Size(35, 35);
            this.alignLeftBtn.TabIndex = 4;
            this.tooltipHelper.SetToolTip(this.alignLeftBtn, "Выровнять по левому краю");
            this.alignLeftBtn.UseVisualStyleBackColor = false;
            this.alignLeftBtn.Click += new System.EventHandler(this.alignLeftBtn_Click);
            // 
            // fontSizeBtn
            // 
            this.fontSizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fontSizeBtn.Location = new System.Drawing.Point(259, 9);
            this.fontSizeBtn.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.fontSizeBtn.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.fontSizeBtn.Name = "fontSizeBtn";
            this.fontSizeBtn.Size = new System.Drawing.Size(50, 26);
            this.fontSizeBtn.TabIndex = 3;
            this.fontSizeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tooltipHelper.SetToolTip(this.fontSizeBtn, "Размер шрифта");
            this.fontSizeBtn.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fontSizeBtn.ValueChanged += new System.EventHandler(this.fontSizeBtn_ValueChanged);
            // 
            // fontsCmb
            // 
            this.fontsCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fontsCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontsCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontsCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fontsCmb.FormattingEnabled = true;
            this.fontsCmb.Location = new System.Drawing.Point(5, 8);
            this.fontsCmb.Name = "fontsCmb";
            this.fontsCmb.Size = new System.Drawing.Size(250, 28);
            this.fontsCmb.Sorted = true;
            this.fontsCmb.TabIndex = 2;
            this.tooltipHelper.SetToolTip(this.fontsCmb, "Шрифт");
            this.fontsCmb.SelectedIndexChanged += new System.EventHandler(this.fontsCmb_SelectedIndexChanged);
            // 
            // themeTableLabel
            // 
            this.themeTableLabel.ColumnCount = 2;
            this.themeTableLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.themeTableLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.themeTableLabel.Controls.Add(this.themeSendLbl, 0, 0);
            this.themeTableLabel.Controls.Add(this.themeSendTxt, 1, 0);
            this.themeTableLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.themeTableLabel.Location = new System.Drawing.Point(3, 33);
            this.themeTableLabel.Name = "themeTableLabel";
            this.themeTableLabel.RowCount = 1;
            this.themeTableLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.themeTableLabel.Size = new System.Drawing.Size(1168, 30);
            this.themeTableLabel.TabIndex = 2;
            // 
            // themeSendLbl
            // 
            this.themeSendLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeSendLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.themeSendLbl.Location = new System.Drawing.Point(3, 0);
            this.themeSendLbl.Name = "themeSendLbl";
            this.themeSendLbl.Size = new System.Drawing.Size(54, 30);
            this.themeSendLbl.TabIndex = 0;
            this.themeSendLbl.Text = "Тема:";
            this.themeSendLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // themeSendTxt
            // 
            this.themeSendTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeSendTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.themeSendTxt.Location = new System.Drawing.Point(63, 3);
            this.themeSendTxt.Name = "themeSendTxt";
            this.themeSendTxt.Size = new System.Drawing.Size(1102, 26);
            this.themeSendTxt.TabIndex = 1;
            // 
            // receiverTablePanel
            // 
            this.receiverTablePanel.ColumnCount = 2;
            this.receiverTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.receiverTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.receiverTablePanel.Controls.Add(this.receiverEmailLbl, 0, 0);
            this.receiverTablePanel.Controls.Add(this.receiverEmailTxt, 1, 0);
            this.receiverTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.receiverTablePanel.Location = new System.Drawing.Point(3, 3);
            this.receiverTablePanel.Name = "receiverTablePanel";
            this.receiverTablePanel.RowCount = 1;
            this.receiverTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.receiverTablePanel.Size = new System.Drawing.Size(1168, 30);
            this.receiverTablePanel.TabIndex = 1;
            // 
            // receiverEmailLbl
            // 
            this.receiverEmailLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiverEmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.receiverEmailLbl.Location = new System.Drawing.Point(3, 0);
            this.receiverEmailLbl.Name = "receiverEmailLbl";
            this.receiverEmailLbl.Size = new System.Drawing.Size(54, 30);
            this.receiverEmailLbl.TabIndex = 0;
            this.receiverEmailLbl.Text = "Кому:";
            this.receiverEmailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receiverEmailTxt
            // 
            this.receiverEmailTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiverEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.receiverEmailTxt.Location = new System.Drawing.Point(63, 3);
            this.receiverEmailTxt.Name = "receiverEmailTxt";
            this.receiverEmailTxt.Size = new System.Drawing.Size(1102, 26);
            this.receiverEmailTxt.TabIndex = 0;
            // 
            // letterSendOptionsTablePanel
            // 
            this.letterSendOptionsTablePanel.ColumnCount = 6;
            this.letterSendOptionsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.letterSendOptionsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.letterSendOptionsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.letterSendOptionsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.letterSendOptionsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.letterSendOptionsTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.letterSendOptionsTablePanel.Controls.Add(this.attachFilesList, 0, 0);
            this.letterSendOptionsTablePanel.Controls.Add(this.attachFilesBtn, 1, 0);
            this.letterSendOptionsTablePanel.Controls.Add(this.encryptMsgBtn, 3, 0);
            this.letterSendOptionsTablePanel.Controls.Add(this.keySignMsgBtn, 4, 0);
            this.letterSendOptionsTablePanel.Controls.Add(this.letterSendBtn, 5, 0);
            this.letterSendOptionsTablePanel.Controls.Add(this.detachLastFileBtn, 2, 0);
            this.letterSendOptionsTablePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.letterSendOptionsTablePanel.Location = new System.Drawing.Point(3, 471);
            this.letterSendOptionsTablePanel.Name = "letterSendOptionsTablePanel";
            this.letterSendOptionsTablePanel.RowCount = 1;
            this.letterSendOptionsTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.letterSendOptionsTablePanel.Size = new System.Drawing.Size(1168, 50);
            this.letterSendOptionsTablePanel.TabIndex = 4;
            // 
            // attachFilesList
            // 
            this.attachFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachFilesList.HideSelection = false;
            this.attachFilesList.Location = new System.Drawing.Point(3, 3);
            this.attachFilesList.MultiSelect = false;
            this.attachFilesList.Name = "attachFilesList";
            this.attachFilesList.Size = new System.Drawing.Size(912, 44);
            this.attachFilesList.TabIndex = 12;
            this.tooltipHelper.SetToolTip(this.attachFilesList, "Приклепляемые файлы");
            this.attachFilesList.UseCompatibleStateImageBehavior = false;
            // 
            // attachFilesBtn
            // 
            this.attachFilesBtn.BackColor = System.Drawing.SystemColors.Control;
            this.attachFilesBtn.BackgroundImage = global::MailClient.Properties.Resources.attach_48px;
            this.attachFilesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attachFilesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachFilesBtn.FlatAppearance.BorderSize = 0;
            this.attachFilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachFilesBtn.Location = new System.Drawing.Point(921, 3);
            this.attachFilesBtn.Name = "attachFilesBtn";
            this.attachFilesBtn.Size = new System.Drawing.Size(44, 44);
            this.attachFilesBtn.TabIndex = 13;
            this.tooltipHelper.SetToolTip(this.attachFilesBtn, "Прикрепить файлы");
            this.attachFilesBtn.UseVisualStyleBackColor = false;
            this.attachFilesBtn.Click += new System.EventHandler(this.attachFilesBtn_Click);
            // 
            // encryptMsgBtn
            // 
            this.encryptMsgBtn.BackColor = System.Drawing.SystemColors.Control;
            this.encryptMsgBtn.BackgroundImage = global::MailClient.Properties.Resources.encrypt_48px;
            this.encryptMsgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.encryptMsgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptMsgBtn.FlatAppearance.BorderSize = 0;
            this.encryptMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptMsgBtn.Location = new System.Drawing.Point(1021, 3);
            this.encryptMsgBtn.Name = "encryptMsgBtn";
            this.encryptMsgBtn.Size = new System.Drawing.Size(44, 44);
            this.encryptMsgBtn.TabIndex = 15;
            this.tooltipHelper.SetToolTip(this.encryptMsgBtn, "Зашифровать сообщение");
            this.encryptMsgBtn.UseVisualStyleBackColor = false;
            this.encryptMsgBtn.Click += new System.EventHandler(this.encryptMsgBtn_Click);
            // 
            // keySignMsgBtn
            // 
            this.keySignMsgBtn.BackColor = System.Drawing.SystemColors.Control;
            this.keySignMsgBtn.BackgroundImage = global::MailClient.Properties.Resources.encrypt_sign_48px;
            this.keySignMsgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keySignMsgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keySignMsgBtn.FlatAppearance.BorderSize = 0;
            this.keySignMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keySignMsgBtn.Location = new System.Drawing.Point(1071, 3);
            this.keySignMsgBtn.Name = "keySignMsgBtn";
            this.keySignMsgBtn.Size = new System.Drawing.Size(44, 44);
            this.keySignMsgBtn.TabIndex = 16;
            this.tooltipHelper.SetToolTip(this.keySignMsgBtn, "Организовать цифровую подпись");
            this.keySignMsgBtn.UseVisualStyleBackColor = false;
            this.keySignMsgBtn.Click += new System.EventHandler(this.keySignMsgBtn_Click);
            // 
            // letterSendBtn
            // 
            this.letterSendBtn.BackColor = System.Drawing.SystemColors.Control;
            this.letterSendBtn.BackgroundImage = global::MailClient.Properties.Resources.email_send_48px;
            this.letterSendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.letterSendBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letterSendBtn.FlatAppearance.BorderSize = 0;
            this.letterSendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.letterSendBtn.Location = new System.Drawing.Point(1121, 3);
            this.letterSendBtn.Name = "letterSendBtn";
            this.letterSendBtn.Size = new System.Drawing.Size(44, 44);
            this.letterSendBtn.TabIndex = 17;
            this.tooltipHelper.SetToolTip(this.letterSendBtn, "Отправить сообщение");
            this.letterSendBtn.UseVisualStyleBackColor = false;
            this.letterSendBtn.Click += new System.EventHandler(this.letterSendBtn_Click);
            // 
            // detachLastFileBtn
            // 
            this.detachLastFileBtn.BackColor = System.Drawing.SystemColors.Control;
            this.detachLastFileBtn.BackgroundImage = global::MailClient.Properties.Resources.remove_48px;
            this.detachLastFileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.detachLastFileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detachLastFileBtn.FlatAppearance.BorderSize = 0;
            this.detachLastFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detachLastFileBtn.Location = new System.Drawing.Point(971, 3);
            this.detachLastFileBtn.Name = "detachLastFileBtn";
            this.detachLastFileBtn.Size = new System.Drawing.Size(44, 44);
            this.detachLastFileBtn.TabIndex = 14;
            this.tooltipHelper.SetToolTip(this.detachLastFileBtn, "Открепить последний файл");
            this.detachLastFileBtn.UseVisualStyleBackColor = false;
            this.detachLastFileBtn.Click += new System.EventHandler(this.detachLastFileBtn_Click);
            // 
            // keysPage
            // 
            this.keysPage.Controls.Add(this.tableLayoutPanel2);
            this.keysPage.Location = new System.Drawing.Point(4, 25);
            this.keysPage.Name = "keysPage";
            this.keysPage.Padding = new System.Windows.Forms.Padding(3);
            this.keysPage.Size = new System.Drawing.Size(1174, 496);
            this.keysPage.TabIndex = 2;
            this.keysPage.Text = "Ключи";
            this.keysPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.Controls.Add(this.keysTable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1168, 490);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // keysTable
            // 
            this.keysTable.AllowUserToAddRows = false;
            this.keysTable.AllowUserToDeleteRows = false;
            this.keysTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.keysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keysTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedKeyCol,
            this.emailCol,
            this.privateCol,
            this.publicCol,
            this.privateSignCol,
            this.publicSignCol,
            this.publicRemoteCol,
            this.publicSignRemoteCol});
            this.keysTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keysTable.Location = new System.Drawing.Point(3, 3);
            this.keysTable.Name = "keysTable";
            this.keysTable.RowHeadersVisible = false;
            this.keysTable.RowHeadersWidth = 51;
            this.keysTable.RowTemplate.Height = 24;
            this.keysTable.Size = new System.Drawing.Size(862, 484);
            this.keysTable.TabIndex = 10;
            this.keysTable.TabStop = false;
            // 
            // selectedKeyCol
            // 
            this.selectedKeyCol.Frozen = true;
            this.selectedKeyCol.HeaderText = "";
            this.selectedKeyCol.MinimumWidth = 25;
            this.selectedKeyCol.Name = "selectedKeyCol";
            this.selectedKeyCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectedKeyCol.Width = 25;
            // 
            // emailCol
            // 
            this.emailCol.HeaderText = "Email";
            this.emailCol.MinimumWidth = 100;
            this.emailCol.Name = "emailCol";
            this.emailCol.Width = 125;
            // 
            // privateCol
            // 
            this.privateCol.HeaderText = "Приватный ключ";
            this.privateCol.MinimumWidth = 100;
            this.privateCol.Name = "privateCol";
            this.privateCol.Width = 120;
            // 
            // publicCol
            // 
            this.publicCol.HeaderText = "Публичный ключ";
            this.publicCol.MinimumWidth = 100;
            this.publicCol.Name = "publicCol";
            this.publicCol.Width = 120;
            // 
            // privateSignCol
            // 
            this.privateSignCol.HeaderText = "Приватный ключ ЭЦП";
            this.privateSignCol.MinimumWidth = 100;
            this.privateSignCol.Name = "privateSignCol";
            this.privateSignCol.Width = 120;
            // 
            // publicSignCol
            // 
            this.publicSignCol.HeaderText = "Публичный ключ ЭЦП";
            this.publicSignCol.MinimumWidth = 100;
            this.publicSignCol.Name = "publicSignCol";
            this.publicSignCol.Width = 120;
            // 
            // publicRemoteCol
            // 
            this.publicRemoteCol.HeaderText = "Публичный ключ удалённого пользователя";
            this.publicRemoteCol.MinimumWidth = 100;
            this.publicRemoteCol.Name = "publicRemoteCol";
            this.publicRemoteCol.Width = 120;
            // 
            // publicSignRemoteCol
            // 
            this.publicSignRemoteCol.HeaderText = "Публичный ключ удалённого пользователя";
            this.publicSignRemoteCol.MinimumWidth = 100;
            this.publicSignRemoteCol.Name = "publicSignRemoteCol";
            this.publicSignRemoteCol.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(871, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 484);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.remoteGrp);
            this.panel3.Controls.Add(this.genKeysGrp);
            this.panel3.Controls.Add(this.removeKeysBtn);
            this.panel3.Controls.Add(this.addKeysBtn);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.keysPublicSignTxt);
            this.panel3.Controls.Add(this.keysPrivateSignTxt);
            this.panel3.Controls.Add(this.keysPublicTxt);
            this.panel3.Controls.Add(this.keysPrivateTxt);
            this.panel3.Controls.Add(this.keysEmailTxt);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 484);
            this.panel3.TabIndex = 1;
            // 
            // remoteGrp
            // 
            this.remoteGrp.Controls.Add(this.label9);
            this.remoteGrp.Controls.Add(this.keysRemoteTxt);
            this.remoteGrp.Controls.Add(this.keysRemoteSignTxt);
            this.remoteGrp.Controls.Add(this.label10);
            this.remoteGrp.Location = new System.Drawing.Point(5, 211);
            this.remoteGrp.Name = "remoteGrp";
            this.remoteGrp.Size = new System.Drawing.Size(286, 100);
            this.remoteGrp.TabIndex = 5;
            this.remoteGrp.TabStop = false;
            this.remoteGrp.Text = "Удалённый пользователь";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(8, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Публичный ЭЦП:";
            // 
            // keysRemoteTxt
            // 
            this.keysRemoteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysRemoteTxt.Location = new System.Drawing.Point(150, 21);
            this.keysRemoteTxt.Name = "keysRemoteTxt";
            this.keysRemoteTxt.Size = new System.Drawing.Size(125, 26);
            this.keysRemoteTxt.TabIndex = 6;
            this.keysRemoteTxt.Enter += new System.EventHandler(this.keysRemoteTxt_Enter);
            // 
            // keysRemoteSignTxt
            // 
            this.keysRemoteSignTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysRemoteSignTxt.Location = new System.Drawing.Point(150, 53);
            this.keysRemoteSignTxt.Name = "keysRemoteSignTxt";
            this.keysRemoteSignTxt.Size = new System.Drawing.Size(125, 26);
            this.keysRemoteSignTxt.TabIndex = 7;
            this.keysRemoteSignTxt.Enter += new System.EventHandler(this.keysRemoteSignTxt_Enter);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Публичный ключ:";
            // 
            // genKeysGrp
            // 
            this.genKeysGrp.Controls.Add(this.genKeySignBtn);
            this.genKeysGrp.Controls.Add(this.genKeyBtn);
            this.genKeysGrp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.genKeysGrp.Location = new System.Drawing.Point(0, 409);
            this.genKeysGrp.Name = "genKeysGrp";
            this.genKeysGrp.Size = new System.Drawing.Size(294, 75);
            this.genKeysGrp.TabIndex = 10;
            this.genKeysGrp.TabStop = false;
            this.genKeysGrp.Text = "Генерация";
            // 
            // genKeySignBtn
            // 
            this.genKeySignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genKeySignBtn.Location = new System.Drawing.Point(150, 22);
            this.genKeySignBtn.Name = "genKeySignBtn";
            this.genKeySignBtn.Size = new System.Drawing.Size(130, 30);
            this.genKeySignBtn.TabIndex = 12;
            this.genKeySignBtn.Text = "Ключи ЭЦП";
            this.genKeySignBtn.UseVisualStyleBackColor = true;
            this.genKeySignBtn.Click += new System.EventHandler(this.genKeySignBtn_Click);
            // 
            // genKeyBtn
            // 
            this.genKeyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.genKeyBtn.Location = new System.Drawing.Point(13, 22);
            this.genKeyBtn.Name = "genKeyBtn";
            this.genKeyBtn.Size = new System.Drawing.Size(130, 30);
            this.genKeyBtn.TabIndex = 11;
            this.genKeyBtn.Text = "Ключи";
            this.genKeyBtn.UseVisualStyleBackColor = true;
            this.genKeyBtn.Click += new System.EventHandler(this.genKeyBtn_Click);
            // 
            // removeKeysBtn
            // 
            this.removeKeysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeKeysBtn.Location = new System.Drawing.Point(13, 370);
            this.removeKeysBtn.Name = "removeKeysBtn";
            this.removeKeysBtn.Size = new System.Drawing.Size(267, 30);
            this.removeKeysBtn.TabIndex = 9;
            this.removeKeysBtn.Text = "Удалить выбранные";
            this.removeKeysBtn.UseVisualStyleBackColor = true;
            this.removeKeysBtn.Click += new System.EventHandler(this.removeKeysBtn_Click);
            // 
            // addKeysBtn
            // 
            this.addKeysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addKeysBtn.Location = new System.Drawing.Point(13, 325);
            this.addKeysBtn.Name = "addKeysBtn";
            this.addKeysBtn.Size = new System.Drawing.Size(267, 30);
            this.addKeysBtn.TabIndex = 8;
            this.addKeysBtn.Text = "Добавить запись";
            this.addKeysBtn.UseVisualStyleBackColor = true;
            this.addKeysBtn.Click += new System.EventHandler(this.addKeysBtn_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.Location = new System.Drawing.Point(10, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Публичный ЭЦП";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.Location = new System.Drawing.Point(10, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Приватный ЭЦП:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(10, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Публичный ключ:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label14.Location = new System.Drawing.Point(10, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Приватный ключ:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label15.Location = new System.Drawing.Point(10, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "Email:";
            // 
            // keysPublicSignTxt
            // 
            this.keysPublicSignTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysPublicSignTxt.Location = new System.Drawing.Point(155, 178);
            this.keysPublicSignTxt.Name = "keysPublicSignTxt";
            this.keysPublicSignTxt.Size = new System.Drawing.Size(125, 26);
            this.keysPublicSignTxt.TabIndex = 4;
            this.keysPublicSignTxt.Enter += new System.EventHandler(this.keysPublicSignTxt_Enter);
            // 
            // keysPrivateSignTxt
            // 
            this.keysPrivateSignTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysPrivateSignTxt.Location = new System.Drawing.Point(155, 146);
            this.keysPrivateSignTxt.Name = "keysPrivateSignTxt";
            this.keysPrivateSignTxt.Size = new System.Drawing.Size(125, 26);
            this.keysPrivateSignTxt.TabIndex = 3;
            this.keysPrivateSignTxt.Enter += new System.EventHandler(this.keysPrivateSignTxt_Enter);
            // 
            // keysPublicTxt
            // 
            this.keysPublicTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysPublicTxt.Location = new System.Drawing.Point(155, 114);
            this.keysPublicTxt.Name = "keysPublicTxt";
            this.keysPublicTxt.Size = new System.Drawing.Size(125, 26);
            this.keysPublicTxt.TabIndex = 2;
            this.keysPublicTxt.Enter += new System.EventHandler(this.keysPublicTxt_Enter);
            // 
            // keysPrivateTxt
            // 
            this.keysPrivateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysPrivateTxt.Location = new System.Drawing.Point(155, 82);
            this.keysPrivateTxt.Name = "keysPrivateTxt";
            this.keysPrivateTxt.Size = new System.Drawing.Size(125, 26);
            this.keysPrivateTxt.TabIndex = 1;
            this.keysPrivateTxt.Enter += new System.EventHandler(this.keysPrivateTxt_Enter);
            // 
            // keysEmailTxt
            // 
            this.keysEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysEmailTxt.Location = new System.Drawing.Point(155, 50);
            this.keysEmailTxt.Name = "keysEmailTxt";
            this.keysEmailTxt.Size = new System.Drawing.Size(125, 26);
            this.keysEmailTxt.TabIndex = 0;
            this.keysEmailTxt.Enter += new System.EventHandler(this.keysEmailTxt_Enter);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(294, 30);
            this.label16.TabIndex = 0;
            this.label16.Text = "Новая запись";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serversPage
            // 
            this.serversPage.Controls.Add(this.tableLayoutPanel1);
            this.serversPage.Location = new System.Drawing.Point(4, 25);
            this.serversPage.Name = "serversPage";
            this.serversPage.Padding = new System.Windows.Forms.Padding(3);
            this.serversPage.Size = new System.Drawing.Size(1174, 496);
            this.serversPage.TabIndex = 3;
            this.serversPage.Text = "Почтовые сервера";
            this.serversPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.serversTable, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1168, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeServersBtn);
            this.panel1.Controls.Add(this.addServerBtn);
            this.panel1.Controls.Add(this.sslCheck);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pop3PortTxt);
            this.panel1.Controls.Add(this.pop3HostTxt);
            this.panel1.Controls.Add(this.imapPortTxt);
            this.panel1.Controls.Add(this.imapHostTxt);
            this.panel1.Controls.Add(this.smtpPortTxt);
            this.panel1.Controls.Add(this.smtpHostTxt);
            this.panel1.Controls.Add(this.domainTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(871, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 484);
            this.panel1.TabIndex = 0;
            // 
            // removeServersBtn
            // 
            this.removeServersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeServersBtn.Location = new System.Drawing.Point(13, 360);
            this.removeServersBtn.Name = "removeServersBtn";
            this.removeServersBtn.Size = new System.Drawing.Size(267, 30);
            this.removeServersBtn.TabIndex = 9;
            this.removeServersBtn.Text = "Удалить выбранные";
            this.removeServersBtn.UseVisualStyleBackColor = true;
            this.removeServersBtn.Click += new System.EventHandler(this.removeServersBtn_Click);
            // 
            // addServerBtn
            // 
            this.addServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addServerBtn.Location = new System.Drawing.Point(13, 320);
            this.addServerBtn.Name = "addServerBtn";
            this.addServerBtn.Size = new System.Drawing.Size(267, 30);
            this.addServerBtn.TabIndex = 8;
            this.addServerBtn.Text = "Добавить сервер";
            this.addServerBtn.UseVisualStyleBackColor = true;
            this.addServerBtn.Click += new System.EventHandler(this.addServerBtn_Click);
            // 
            // sslCheck
            // 
            this.sslCheck.AutoSize = true;
            this.sslCheck.Location = new System.Drawing.Point(13, 285);
            this.sslCheck.Name = "sslCheck";
            this.sslCheck.Size = new System.Drawing.Size(109, 21);
            this.sslCheck.TabIndex = 7;
            this.sslCheck.Text = "SSL защита";
            this.sslCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(10, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "POP3 порт:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(10, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "POP3 сервер:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(10, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "IMAP порт:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(10, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "IMAP сервер:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "SMTP порт:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "SMTP сервер:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Домен:";
            // 
            // pop3PortTxt
            // 
            this.pop3PortTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pop3PortTxt.Location = new System.Drawing.Point(116, 242);
            this.pop3PortTxt.Name = "pop3PortTxt";
            this.pop3PortTxt.Size = new System.Drawing.Size(164, 26);
            this.pop3PortTxt.TabIndex = 6;
            this.pop3PortTxt.Enter += new System.EventHandler(this.pop3PortTxt_Enter);
            // 
            // pop3HostTxt
            // 
            this.pop3HostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pop3HostTxt.Location = new System.Drawing.Point(116, 210);
            this.pop3HostTxt.Name = "pop3HostTxt";
            this.pop3HostTxt.Size = new System.Drawing.Size(164, 26);
            this.pop3HostTxt.TabIndex = 5;
            this.pop3HostTxt.Enter += new System.EventHandler(this.pop3ServerTxt_Enter);
            // 
            // imapPortTxt
            // 
            this.imapPortTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imapPortTxt.Location = new System.Drawing.Point(116, 178);
            this.imapPortTxt.Name = "imapPortTxt";
            this.imapPortTxt.Size = new System.Drawing.Size(164, 26);
            this.imapPortTxt.TabIndex = 4;
            this.imapPortTxt.Enter += new System.EventHandler(this.imapPortTxt_Enter);
            // 
            // imapHostTxt
            // 
            this.imapHostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.imapHostTxt.Location = new System.Drawing.Point(116, 146);
            this.imapHostTxt.Name = "imapHostTxt";
            this.imapHostTxt.Size = new System.Drawing.Size(164, 26);
            this.imapHostTxt.TabIndex = 3;
            this.imapHostTxt.Enter += new System.EventHandler(this.imapServerTxt_Enter);
            // 
            // smtpPortTxt
            // 
            this.smtpPortTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.smtpPortTxt.Location = new System.Drawing.Point(116, 114);
            this.smtpPortTxt.Name = "smtpPortTxt";
            this.smtpPortTxt.Size = new System.Drawing.Size(164, 26);
            this.smtpPortTxt.TabIndex = 2;
            this.smtpPortTxt.Enter += new System.EventHandler(this.smtpPortTxt_Enter);
            // 
            // smtpHostTxt
            // 
            this.smtpHostTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.smtpHostTxt.Location = new System.Drawing.Point(116, 82);
            this.smtpHostTxt.Name = "smtpHostTxt";
            this.smtpHostTxt.Size = new System.Drawing.Size(164, 26);
            this.smtpHostTxt.TabIndex = 1;
            this.smtpHostTxt.Enter += new System.EventHandler(this.smtpServerTxt_Enter);
            // 
            // domainTxt
            // 
            this.domainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.domainTxt.Location = new System.Drawing.Point(116, 50);
            this.domainTxt.Name = "domainTxt";
            this.domainTxt.Size = new System.Drawing.Size(164, 26);
            this.domainTxt.TabIndex = 0;
            this.domainTxt.Enter += new System.EventHandler(this.domenTxt_Enter);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый сервер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serversTable
            // 
            this.serversTable.AllowUserToAddRows = false;
            this.serversTable.AllowUserToDeleteRows = false;
            this.serversTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.serversTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serversTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedServerCol,
            this.domainCol,
            this.smtpHostCol,
            this.smtpPortCol,
            this.imapHostCol,
            this.imapPortCol,
            this.pop3HostCol,
            this.pop3PortCol,
            this.sslCol});
            this.serversTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversTable.Location = new System.Drawing.Point(3, 3);
            this.serversTable.Name = "serversTable";
            this.serversTable.RowHeadersVisible = false;
            this.serversTable.RowHeadersWidth = 51;
            this.serversTable.RowTemplate.Height = 24;
            this.serversTable.Size = new System.Drawing.Size(862, 484);
            this.serversTable.TabIndex = 9;
            this.serversTable.TabStop = false;
            // 
            // selectedServerCol
            // 
            this.selectedServerCol.Frozen = true;
            this.selectedServerCol.HeaderText = "";
            this.selectedServerCol.MinimumWidth = 25;
            this.selectedServerCol.Name = "selectedServerCol";
            this.selectedServerCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectedServerCol.Width = 25;
            // 
            // domainCol
            // 
            this.domainCol.HeaderText = "Домен";
            this.domainCol.MinimumWidth = 100;
            this.domainCol.Name = "domainCol";
            this.domainCol.Width = 125;
            // 
            // smtpHostCol
            // 
            this.smtpHostCol.HeaderText = "SMTP сервер";
            this.smtpHostCol.MinimumWidth = 100;
            this.smtpHostCol.Name = "smtpHostCol";
            this.smtpHostCol.Width = 125;
            // 
            // smtpPortCol
            // 
            this.smtpPortCol.HeaderText = "SMTP порт";
            this.smtpPortCol.MinimumWidth = 70;
            this.smtpPortCol.Name = "smtpPortCol";
            this.smtpPortCol.Width = 70;
            // 
            // imapHostCol
            // 
            this.imapHostCol.HeaderText = "IMAP сервер";
            this.imapHostCol.MinimumWidth = 100;
            this.imapHostCol.Name = "imapHostCol";
            this.imapHostCol.Width = 125;
            // 
            // imapPortCol
            // 
            this.imapPortCol.HeaderText = "IMAP порт";
            this.imapPortCol.MinimumWidth = 70;
            this.imapPortCol.Name = "imapPortCol";
            this.imapPortCol.Width = 70;
            // 
            // pop3HostCol
            // 
            this.pop3HostCol.HeaderText = "POP3 сервер";
            this.pop3HostCol.MinimumWidth = 100;
            this.pop3HostCol.Name = "pop3HostCol";
            this.pop3HostCol.Width = 125;
            // 
            // pop3PortCol
            // 
            this.pop3PortCol.HeaderText = "POP3 порт";
            this.pop3PortCol.MinimumWidth = 70;
            this.pop3PortCol.Name = "pop3PortCol";
            this.pop3PortCol.Width = 70;
            // 
            // sslCol
            // 
            this.sslCol.HeaderText = "Ssl защита";
            this.sslCol.MinimumWidth = 60;
            this.sslCol.Name = "sslCol";
            this.sslCol.ReadOnly = true;
            this.sslCol.Width = 60;
            // 
            // checkInputPrv
            // 
            this.checkInputPrv.ContainerControl = this;
            // 
            // updateBooksWorker
            // 
            this.updateBooksWorker.WorkerReportsProgress = true;
            this.updateBooksWorker.WorkerSupportsCancellation = true;
            this.updateBooksWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateBooksWorker_DoWork);
            this.updateBooksWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updateBooksWorker_RunWorkerCompleted);
            // 
            // updateServersWorker
            // 
            this.updateServersWorker.WorkerReportsProgress = true;
            this.updateServersWorker.WorkerSupportsCancellation = true;
            this.updateServersWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateServersWorker_DoWork);
            this.updateServersWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updateServersWorker_RunWorkerCompleted);
            // 
            // lettersStatus
            // 
            this.lettersStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lettersStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lettersStatusLabel});
            this.lettersStatus.Location = new System.Drawing.Point(3, 495);
            this.lettersStatus.Name = "lettersStatus";
            this.lettersStatus.Size = new System.Drawing.Size(1168, 26);
            this.lettersStatus.TabIndex = 6;
            this.lettersStatus.Text = "statusStrip1";
            // 
            // lettersStatusLabel
            // 
            this.lettersStatusLabel.Name = "lettersStatusLabel";
            this.lettersStatusLabel.Size = new System.Drawing.Size(55, 20);
            this.lettersStatusLabel.Text = "Статус:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudMail";
            this.tabControl1.ResumeLayout(false);
            this.lettersPage.ResumeLayout(false);
            this.lettersPage.PerformLayout();
            this.msgLetterPanel.ResumeLayout(false);
            this.letterReadTablePanel.ResumeLayout(false);
            this.letterReadOptionTablePanel.ResumeLayout(false);
            this.letterHeaderTablePanel.ResumeLayout(false);
            this.letterHeaderTablePanel.PerformLayout();
            this.lettersTablePanel.ResumeLayout(false);
            this.msgListOptionsPanel.ResumeLayout(false);
            this.senderPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeBtn)).EndInit();
            this.themeTableLabel.ResumeLayout(false);
            this.themeTableLabel.PerformLayout();
            this.receiverTablePanel.ResumeLayout(false);
            this.receiverTablePanel.PerformLayout();
            this.letterSendOptionsTablePanel.ResumeLayout(false);
            this.keysPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keysTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.remoteGrp.ResumeLayout(false);
            this.remoteGrp.PerformLayout();
            this.genKeysGrp.ResumeLayout(false);
            this.serversPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInputPrv)).EndInit();
            this.lettersStatus.ResumeLayout(false);
            this.lettersStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lettersPage;
        private System.Windows.Forms.TabPage senderPage;
        private System.Windows.Forms.TabPage keysPage;
        private System.Windows.Forms.TabPage serversPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView serversTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox domainTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pop3PortTxt;
        private System.Windows.Forms.TextBox pop3HostTxt;
        private System.Windows.Forms.TextBox imapPortTxt;
        private System.Windows.Forms.TextBox imapHostTxt;
        private System.Windows.Forms.TextBox smtpPortTxt;
        private System.Windows.Forms.TextBox smtpHostTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeServersBtn;
        private System.Windows.Forms.Button addServerBtn;
        private System.Windows.Forms.CheckBox sslCheck;
        private System.Windows.Forms.DataGridView keysTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button removeKeysBtn;
        private System.Windows.Forms.Button addKeysBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox keysRemoteSignTxt;
        private System.Windows.Forms.TextBox keysRemoteTxt;
        private System.Windows.Forms.TextBox keysPublicSignTxt;
        private System.Windows.Forms.TextBox keysPrivateSignTxt;
        private System.Windows.Forms.TextBox keysPublicTxt;
        private System.Windows.Forms.TextBox keysPrivateTxt;
        private System.Windows.Forms.TextBox keysEmailTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button genKeySignBtn;
        private System.Windows.Forms.Button genKeyBtn;
        private System.Windows.Forms.ErrorProvider checkInputPrv;
        private System.Windows.Forms.GroupBox genKeysGrp;
        private System.Windows.Forms.GroupBox remoteGrp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button alignLeftBtn;
        private System.Windows.Forms.NumericUpDown fontSizeBtn;
        private System.Windows.Forms.ComboBox fontsCmb;
        private System.Windows.Forms.TableLayoutPanel themeTableLabel;
        private System.Windows.Forms.Label themeSendLbl;
        private System.Windows.Forms.TextBox themeSendTxt;
        private System.Windows.Forms.TableLayoutPanel receiverTablePanel;
        private System.Windows.Forms.Label receiverEmailLbl;
        private System.Windows.Forms.Button underlineBtn;
        private System.Windows.Forms.Button italicBtn;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button strikeOutBtn;
        private System.Windows.Forms.Button alignRightBtn;
        private System.Windows.Forms.Button alignCenterBtn;
        private System.Windows.Forms.TableLayoutPanel letterSendOptionsTablePanel;
        private System.Windows.Forms.RichTextBox msgSendTxt;
        private System.Windows.Forms.TextBox receiverEmailTxt;
        private System.Windows.Forms.ToolTip tooltipHelper;
        private System.Windows.Forms.ListView attachFilesList;
        private System.Windows.Forms.Button attachFilesBtn;
        private System.Windows.Forms.Button encryptMsgBtn;
        private System.Windows.Forms.Button keySignMsgBtn;
        private System.Windows.Forms.Button letterSendBtn;
        private System.Windows.Forms.ListView boxesList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TableLayoutPanel lettersTablePanel;
        private System.Windows.Forms.Panel msgListOptionsPanel;
        private System.Windows.Forms.Panel msgLetterPanel;
        private System.Windows.Forms.TableLayoutPanel letterHeaderTablePanel;
        private System.Windows.Forms.Label senderEmailLbl;
        private System.Windows.Forms.Label themeReadLbl;
        private System.Windows.Forms.TextBox senderEmailTxt;
        private System.Windows.Forms.TextBox themeReadTxt;
        private System.Windows.Forms.TableLayoutPanel letterReadTablePanel;
        private System.Windows.Forms.TableLayoutPanel letterReadOptionTablePanel;
        private System.Windows.Forms.Button keySignCheckBtn;
        private System.Windows.Forms.Button decryptMsgBtn;
        private System.Windows.Forms.Button detachFilesBtn;
        private System.Windows.Forms.WebBrowser msgReadWeb;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.ListView detachFilesList;
        private System.Windows.Forms.ListView lettersList;
        private System.Windows.Forms.Button detachLastFileBtn;
        private System.ComponentModel.BackgroundWorker updateBooksWorker;
        private System.ComponentModel.BackgroundWorker updateServersWorker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedKeyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateSignCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicSignCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicRemoteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicSignRemoteCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectedServerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpHostCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn smtpPortCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn imapHostCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn imapPortCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pop3HostCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pop3PortCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sslCol;
        private System.Windows.Forms.StatusStrip lettersStatus;
        private System.Windows.Forms.ToolStripStatusLabel lettersStatusLabel;
    }
}