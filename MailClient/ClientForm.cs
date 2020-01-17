using MailClient.DB;
using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class ClientForm : Form
    {
        enum TabState
        {
            ReadMsgTab = 0,
            SendMsgTab = 1,
            KeysTab = 2,
            ServersTab = 3
        }

        private MailClient StudMail;
        private ObservableCollection<FolderInfo> Folders;
        private ObservableCollection<LetterInfo> Letters;

        public ClientForm(UserInfo user)
        {
            InitializeComponent();

            StudMail = new MailClient(user);
            Folders = new ObservableCollection<FolderInfo>();
            Letters = new ObservableCollection<LetterInfo>();

            boxesList.Items.Add("asdgf");
            boxesList.Items.Add("asdgf");
            boxesList.Items.Add("asdgf");
            lettersList.Items.Add("qwerty");
            lettersList.Items.Add("qwerty");
            lettersList.Items.Add("qwerty");

            InitFont();
            updateBooksWorker.RunWorkerAsync();
            updateServersWorker.RunWorkerAsync();
        }

        private void UpdateBoxes()
        {

        }

        private void UpdateLetters()
        {

        }

        private void UpdateBooks(List<RSABookInfo> books)
        {
            keysTable.Rows.Clear();

            foreach (var item in books)
            {
                var index = keysTable.Rows.Add();

                keysTable.Rows[index].Cells["emailCol"].Value = item.Email;
                keysTable.Rows[index].Cells["privateCol"].Value = item.OwnPrivate;
                keysTable.Rows[index].Cells["publicCol"].Value = item.OwnPublic;
                keysTable.Rows[index].Cells["privateECPCol"].Value = item.OwnPrivateECP;
                keysTable.Rows[index].Cells["publicECPCol"].Value = item.OwnPublicECP;
                keysTable.Rows[index].Cells["publicRemoteCol"].Value = item.EmailPublic;
                keysTable.Rows[index].Cells["publicSignRemoteCol"].Value = item.EmailPublicECP;
            }
        }

        private void UpdateServers(List<ServerInfo> servers)
        {
            serversTable.Rows.Clear();

            foreach (var item in servers)
            {
                var index = serversTable.Rows.Add();

                serversTable.Rows[index].Cells["domainCol"].Value = item.Domain;
                serversTable.Rows[index].Cells["smtpHostCol"].Value = item.SmtpHost;
                serversTable.Rows[index].Cells["smtpPortCol"].Value = item.SmtpPort;
                serversTable.Rows[index].Cells["imapHostCol"].Value = item.ImapHost;
                serversTable.Rows[index].Cells["imapPortCol"].Value = item.ImapPort;
                serversTable.Rows[index].Cells["pop3HostCol"].Value = item.Pop3Host;
                serversTable.Rows[index].Cells["pop3PortCol"].Value = item.Pop3Port;
                serversTable.Rows[index].Cells["sslCol"].Value = item.IsSsl;
            }
        }

        private void InitFont()
        {
            var fonts = new InstalledFontCollection();

            foreach (var item in fonts.Families)
            {
                fontsCmb.Items.Add(item.Name);
            }

            fontsCmb.SelectedItem = "Times New Roman";
            msgSendTxt.Font = new Font("Times New Roman", (float) fontSizeBtn.Value, FontStyle.Regular);
        }

        private void ClearLetterRead()
        {
            senderEmailTxt.Text = "";
            themeReadTxt.Text = "";
            msgReadWeb.Navigate("about:blank");
            detachFilesList.Items.Clear();

        }

        private void ClearLetterSend()
        {
            receiverEmailTxt.Text = "";
            themeSendTxt.Text = "";
            fontsCmb.SelectedItem = "Times New Roman";
            fontSizeBtn.Value = 12;
            msgSendTxt.Text = "";
            attachFilesList.Items.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case (int) TabState.ReadMsgTab:
                    break;
                case (int) TabState.SendMsgTab:
                    ClearLetterSend();
                    break;
                case (int) TabState.KeysTab:
                    break;
                case (int) TabState.ServersTab:
                    break;
                default:
                    break;
            }
        }

        #region Обработка вкладки чтения писем



        #endregion

        #region Обработка вкладки отправки сообщений

        private void fontsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                msgSendTxt.SelectionFont = new Font(fontsCmb.SelectedItem.ToString(), (float) fontSizeBtn.Value);
            }
            catch (Exception)
            {
                msgSendTxt.SelectionFont = new Font("Times New Roman", (float) fontSizeBtn.Value);
            }
        }

        private void fontSizeBtn_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                msgSendTxt.SelectionFont = new Font(fontsCmb.SelectedItem.ToString(), (float) fontSizeBtn.Value);
            }
            catch (Exception)
            {
                msgSendTxt.SelectionFont = new Font("Times New Roman", (float) fontSizeBtn.Value);
            }
        }

        private void alignLeftBtn_Click(object sender, EventArgs e)
        {
            msgSendTxt.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenterBtn_Click(object sender, EventArgs e)
        {
            msgSendTxt.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRightBtn_Click(object sender, EventArgs e)
        {
            msgSendTxt.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            var family = fontsCmb.SelectedItem.ToString();
            var oldFont = msgSendTxt.SelectionFont;
            var addFont = new Font(family, (float) fontSizeBtn.Value, oldFont.Style | FontStyle.Bold);
            var rmvFont = new Font(family, (float) fontSizeBtn.Value, oldFont.Style & ~FontStyle.Bold);

            msgSendTxt.SelectionFont = oldFont.Bold ? rmvFont : addFont;
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            var family = fontsCmb.SelectedItem.ToString();
            var oldFont = msgSendTxt.SelectionFont;
            var addFont = new Font(family, (float) fontSizeBtn.Value, oldFont.Style | FontStyle.Italic);
            var rmvFont = new Font(family, (float) fontSizeBtn.Value, oldFont.Style & ~FontStyle.Italic);

            msgSendTxt.SelectionFont = oldFont.Italic ? rmvFont : addFont;
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            var family = fontsCmb.SelectedItem.ToString();
            var oldFont = msgSendTxt.SelectionFont;
            var addFont = new Font(family, (float) fontSizeBtn.Value, oldFont.Style | FontStyle.Underline);
            var rmvFont = new Font(family, (float) fontSizeBtn.Value, oldFont.Style & ~FontStyle.Underline);

            msgSendTxt.SelectionFont = oldFont.Underline ? rmvFont : addFont;
        }

        private void strikeOutBtn_Click(object sender, EventArgs e)
        {
            var family = fontsCmb.SelectedItem.ToString();
            var oldFont = msgSendTxt.SelectionFont;
            var addFont = new Font(family, (float)fontSizeBtn.Value, oldFont.Style | FontStyle.Strikeout);
            var rmvFont = new Font(family, (float)fontSizeBtn.Value, oldFont.Style & ~FontStyle.Strikeout);

            msgSendTxt.SelectionFont = oldFont.Strikeout ? rmvFont : addFont;
        }

        private void attachFilesBtn_Click(object sender, EventArgs e)
        {

        }

        private void detachLastFileBtn_Click(object sender, EventArgs e)
        {
            if (attachFilesList.Items.Count != 0)
                attachFilesList.Items.RemoveAt(attachFilesList.Items.Count - 1);
        }

        private void encryptMsgBtn_Click(object sender, EventArgs e)
        {

        }

        private void keySignMsgBtn_Click(object sender, EventArgs e)
        {

        }

        private void letterSendBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Обработка вкладки ключей

        private void addKeysBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeKeysBtn_Click(object sender, EventArgs e)
        {

        }

        private void genKeyBtn_Click(object sender, EventArgs e)
        {

        }

        private void genKeySignBtn_Click(object sender, EventArgs e)
        {

        }

        private void keysEmailTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void keysPrivateTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void keysPublicTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void keysPrivateSignTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void keysPublicSignTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void keysRemoteTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void keysRemoteSignTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void updateBooksWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = DBRSABooks.GetBooks(DBConnection.Connection, (int) StudMail.CurrentUser.Id);
        }

        private void updateBooksWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateBooks((List<RSABookInfo>) e.Result);
        }

        #endregion

        #region Обработка вкладки серверов

        private void addServerBtn_Click(object sender, EventArgs e)
        {
            var domain = domainTxt.Text.Trim(' ');
            var smtpHost = smtpHostTxt.Text.Trim(' ');
            var smtpPort = smtpPortTxt.Text.Trim(' ');
            var imapHost = imapHostTxt.Text.Trim(' ');
            var imapPort = imapPortTxt.Text.Trim(' ');
            var pop3Host = pop3HostTxt.Text.Trim(' ');
            var pop3Port = pop3PortTxt.Text.Trim(' ');
            ServerInfo newServer;
            int smtp;
            int imap;
            int pop3;

            if (string.IsNullOrEmpty(domain))
            {
                checkInputPrv.SetError(domainTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(smtpHost))
            {
                checkInputPrv.SetError(smtpHostTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(smtpPort) | !int.TryParse(smtpPort, out smtp))
            {
                checkInputPrv.SetError(smtpPortTxt, "Заполните данное поле корректно");
                return;
            }

            if (string.IsNullOrEmpty(imapHost))
            {
                checkInputPrv.SetError(imapHostTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(imapPort) | !int.TryParse(imapPort, out imap))
            {
                checkInputPrv.SetError(imapPortTxt, "Заполните данное поле корректно");
                return;
            }

            if (string.IsNullOrEmpty(pop3Host))
            {
                checkInputPrv.SetError(pop3HostTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(pop3Port) | !int.TryParse(pop3Port, out pop3))
            {
                checkInputPrv.SetError(pop3PortTxt, "Заполните данное поле корректно");
                return;
            }

            newServer = new ServerInfo()
            {
                Domain = domain,
                SmtpHost = smtpHost,
                SmtpPort = smtp,
                ImapHost = imapHost,
                ImapPort = imap,
                Pop3Host = pop3Host,
                Pop3Port = pop3,
                IsSsl = sslCheck.Checked
            };

            if (!DBServers.Add(DBConnection.Connection, newServer))
            {
                checkInputPrv.SetError(domainTxt, "Сервер уже существует");
                return;
            }

            UpdateServers(DBServers.GetServers(DBConnection.Connection));
        }

        private void removeServersBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < serversTable.Rows.Count; i++)
            {
                var selected = (bool) serversTable.Rows[i].Cells["selectedServerCol"].EditedFormattedValue;
                var domain = (string) serversTable.Rows[i].Cells["domainCol"].Value;

                if (!selected || !DBServers.Remove(DBConnection.Connection, domain))
                    continue;
            }

            UpdateServers(DBServers.GetServers(DBConnection.Connection));
        }

        private void domenTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void smtpServerTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void smtpPortTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void imapServerTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void imapPortTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void pop3ServerTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void pop3PortTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void updateServersWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = DBServers.GetServers(DBConnection.Connection);
        }

        private void updateServersWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateServers((List<ServerInfo>) e.Result);
        }

        #endregion
    }
}
