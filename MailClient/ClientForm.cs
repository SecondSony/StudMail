using MailClient.Crypto;
using MailClient.DB;
using MailClient.Helpers;
using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
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

        private int curPage;
        private int curFolder;
        private MailClient StudMail;
        private MimeMessage CurrentLetter;
        private List<string> currentPaths = new List<string>();
        private bool isEncryptMsg = false;

        public ClientForm(UserInfo user)
        {
            InitializeComponent();

            StudMail = new MailClient(user);
            UpdateFolders();
            StudMail.GetFolders();

            keySignCheckBtn.Hide();
            keySignMsgBtn.Hide();
            msgListOptionsPanel.Hide();
            msgLetterPanel.Hide();

            InitFont();
            updateBooksWorker.RunWorkerAsync();
            updateServersWorker.RunWorkerAsync();
        }

        private void UpdateFolders()
        {
            var list = new List<string>();
            
            if (StudMail.GetFolders())
                list = StudMail.Folders.Select(f => f.FullName).ToList();

            DBFolders.SyncFolders(DBConnection.Connection, list, StudMail.UserId);
            StudMail.UserFolders = DBFolders.GetFolders(DBConnection.Connection, StudMail.UserId);
            boxesList.Items.Clear();
            lettersList.Items.Clear();

            foreach (var folder in StudMail.UserFolders)
            {
                boxesList.Items.Add(folder.Name);
            }
        }

        private void UpdateLetters()
        {
            lettersList.Items.Clear();

            if (StudMail.GetLetters(curFolder, curPage))
            {
                foreach (var letter in StudMail.Letters)
                {
                    lettersList.Items.Add(letter.From[0].ToString());
                }
            }
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
                keysTable.Rows[index].Cells["privateSignCol"].Value = item.OwnPrivateECP;
                keysTable.Rows[index].Cells["publicSignCol"].Value = item.OwnPublicECP;
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
            msgReadWeb.Document.Write("");
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
            currentPaths.Clear();

            if (isEncryptMsg) encryptMsgBtn_Click(null, null);
        }

        private void LoadMsg()
        {
            var msg = CurrentLetter;
            string body = string.IsNullOrEmpty(msg.TextBody) ? msg.HtmlBody : msg.TextBody;

            msgLetterPanel.Hide();
            //ClearLetterRead();

            senderEmailTxt.Text = msg.From[0].ToString();
            themeReadTxt.Text = msg.Subject;
            msgReadWeb.Navigate("about:blank");
            msgReadWeb.Document.OpenNew(false);
            msgReadWeb.Document.Write(body);
            msgReadWeb.Refresh();

            detachFilesList.Items.Clear();

            foreach (var attachment in msg.Attachments)
            {
                var filename = attachment.ContentDisposition.FileName ?? attachment.ContentType.Name;
                detachFilesList.Items.Add(filename);
            }

            msgLetterPanel.Show();
        }

        /// <summary>
        /// Сохранение содержания письма в файл и открытие
        /// </summary>
        /// <param name="msg"></param>
        private void SaveMsgLocal(string msg)
        {
            var email = CurrentLetter.From[0].ToString();
            var subject = string.IsNullOrEmpty(CurrentLetter.Subject) ? "" : $"_{CurrentLetter.Subject}";
            var path = $"{Environment.CurrentDirectory}\\messages";
            var filename = $"{path}\\{email}{subject}.txt";

            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            using (var writer = new StreamWriter(filename, false))
            {
                writer.Write(msg);
            }
                
            // Открытие файла
            Process.Start(filename);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case (int) TabState.ReadMsgTab:
                    UpdateFolders();
                    msgLetterPanel.Hide();
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

        private void boxesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выгружаем с сервера письма текущей папки
            
            var indexes = boxesList.SelectedIndices;

            curPage = 0;

            foreach (int i in indexes)
            {
                curFolder = i;
                break;
            }


            if (curFolder == -1)
            {
                return;
            }

            msgLetterPanel.Hide();
            lettersStatusLabel.Text = "Статус: Идёт загрузка писем...";
            UpdateLetters();
            lettersStatusLabel.Text = "Статус: Готово";
        }

        private void lettersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Выгружаем письмо и сохраняем в базу данных

            var indexes = lettersList.SelectedIndices;
            var letterId = -1;

            foreach (int i in indexes)
            {
                letterId = i;
                break;
            }

            if (letterId == -1)
            {
                msgLetterPanel.Hide();
                ClearLetterRead();
                CurrentLetter = null;
                return;
            }

            CurrentLetter = StudMail.GetLetter(curFolder, curPage, letterId);
            lettersStatusLabel.Text = $"Статус: Идёт загрузка письма...";
            LoadMsg();
            lettersStatusLabel.Text = "Статус: Готово";
        }

        private void detachFilesBtn_Click(object sender, EventArgs e)
        {
            if (CurrentLetter != null)
            {
                foreach (MimeEntity attachment in CurrentLetter.Attachments)
                {
                    var filename = attachment.ContentDisposition.FileName ?? attachment.ContentType.Name;
                    var sfd = new SaveFileDialog();

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        filename = $"{Path.GetDirectoryName(sfd.FileName)}\\{filename}";
                        
                        using (var stream = File.Create(filename))
                        {
                            if (attachment is MessagePart)
                            {
                                var rfc822 = (MessagePart) attachment;
                                rfc822.Message.WriteTo(stream);
                            }
                            else
                            {
                                var part = (MimePart) attachment;
                                part.Content.DecodeTo(stream);
                            }
                        }
                    }
                }
            }
        }

        private void decryptMsgBtn_Click(object sender, EventArgs e)
        {
            var userId = StudMail.UserId;
            var msg = CurrentLetter;
            var books = DBRSABooks.GetBooks(DBConnection.Connection, userId);
            var body = string.IsNullOrEmpty(msg.TextBody) ? msg.HtmlBody : msg.TextBody;
            var decryptedTxt = "";
            bool isFound = false;

            try
            {
                foreach (var book in books)
                {
                    if (book.Email == msg.From[0].ToString())
                    {
                        decryptedTxt = MailHelper.ReturnMsg(body, book.OwnPrivate);

                        if (decryptedTxt != null)
                        {
                            SaveMsgLocal(decryptedTxt);
                            isFound = true;
                        }

                        break;
                    }
                }

                MessageBox.Show(isFound ? decryptedTxt : body, "Расшифрованное сообщение");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Непредвиденная ошибка");
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            // curPage = Math.Max(--curPage, 0);
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            // curPage = Math.Min(++curPage * 50, StudMail.CurrentFolder.Count);
        }

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
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (currentPaths.Contains(ofd.FileName))
                {
                    MessageBox.Show("Данный файл уже загружен");
                    return;
                }

                attachFilesList.Items.Add(Path.GetFileName(ofd.FileName));
                currentPaths.Add(ofd.FileName);
            }
        }

        private void detachLastFileBtn_Click(object sender, EventArgs e)
        {
            if (attachFilesList.Items.Count != 0)
            {
                attachFilesList.Items.RemoveAt(attachFilesList.Items.Count - 1);
                currentPaths.RemoveAt(attachFilesList.Items.Count - 1);
            }
        }

        private void encryptMsgBtn_Click(object sender, EventArgs e)
        {
            var msg = !isEncryptMsg ? "Не шифровать сообщение" : "Зашифровать сообщение";
            tooltipHelper.SetToolTip(encryptMsgBtn, msg);
            isEncryptMsg = !isEncryptMsg;
        }

        // TODO:
        private void keySignMsgBtn_Click(object sender, EventArgs e)
        {

        }

        // TODO:
        private void letterSendBtn_Click(object sender, EventArgs e)
        {
            lock (MailClient.ObjLock)
            {
                if (MailClient.CurrentNetwork == NetworkStatus.Disconnected)
                {
                    MessageBox.Show("Отсутствует интернет! Отправка письма невозможна!");
                    return;
                }
            }

            // Зашифровать текст сообщения TripleDES
            // Получить ключ и вектор сообщения TripleDES
            // Зашифровать ключ при помощи RSA и получить ключи
            // Получить ЭЦП и ключи
            // Сформировать конечную строку - зашифрованный текст&зашифрованный ключ&вектор&ЭЦП
            // Сформировать сообщение MimeMessage
            // Отправить сообщение на сервер
            // Сохранить сообщение в БД в зашифрованном виде

            var msg = new MimeMessage();
            var to = receiverEmailTxt.Text.Trim();
            var subject = themeSendTxt.Text.Trim();
            var body = msgSendTxt.Text.Trim();
            var receivers = to.Split(';');
            var userId = StudMail.UserId;
            var books = DBRSABooks.GetBooks(DBConnection.Connection, userId);

            if (string.IsNullOrEmpty(to))
            {
                checkInputPrv.SetError(receiverEmailTxt, "Заполните данное поле");
                return;
            }

            try
            {
                msg.From.Add(new MailboxAddress(StudMail.CurrentUser.Email));

                foreach (var item in receivers) msg.To.Add(new MailboxAddress(item));

                msg.Subject = subject;

                var found = false;

                // Находим для каждого адресата свой ключ
                foreach (var receiver in msg.To)
                {
                    if (!isEncryptMsg)
                    {
                        var mailMsg = MailHelper.GenMsg(msg, body, currentPaths);

                        if (StudMail.SendLetter(mailMsg))
                        {
                            MessageBox.Show($"Сообщение отправлено адресату: {receiver.ToString()}");
                        }
                        else
                        {
                            MessageBox.Show($"Не удалось отправить сообщение адресату: {receiver.ToString()}");
                        }
                    }
                    else
                    {
                        foreach (var book in books)
                        {
                            if (book.Email == receiver.ToString())
                            {
                                if (book.EmailPublic != "")
                                {
                                    var mailMsg = MailHelper.GenEncryptedMsg(msg, body, currentPaths, book);

                                    if (StudMail.SendLetter(mailMsg))
                                    {
                                        MessageBox.Show($"Сообщение отправлено адресату: {receiver.ToString()}");
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Не удалось отправить сообщение адресату: {receiver.ToString()}");
                                    }

                                    found = true;
                                }

                                // Нужно ещё записать в БД в зашифрованном виде, но не хватает uid
                                break;
                            }
                        }

                        if (!found)
                        {
                            MessageBox.Show($"Вы не имеете публичного ключа {receiver.ToString()}");
                        }
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Произошла непредвиденная ошибка\n" + err.Message);
            }
        }

        #endregion

        #region Обработка вкладки ключей

        private void addKeysBtn_Click(object sender, EventArgs e)
        {
            var email = keysEmailTxt.Text.Trim(' ');
            var privateKey = keysPrivateTxt.Text.Trim(' ');
            var publicKey = keysPublicTxt.Text.Trim(' ');
            var privateECPKey = keysPrivateSignTxt.Text.Trim(' ');
            var publicECPKey = keysPublicSignTxt.Text.Trim(' ');
            var remoteKey = keysRemoteTxt.Text.Trim(' ');
            var remoteECPKey = keysRemoteSignTxt.Text.Trim(' ');
            RSABookInfo book;

            if (string.IsNullOrEmpty(email))
            {
                checkInputPrv.SetError(keysEmailTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(privateKey))
            {
                checkInputPrv.SetError(keysPrivateTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(publicKey))
            {
                checkInputPrv.SetError(keysPublicTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(privateECPKey))
            {
                checkInputPrv.SetError(keysPrivateSignTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(publicECPKey))
            {
                checkInputPrv.SetError(keysPublicSignTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(remoteKey))
            {
                checkInputPrv.SetError(keysRemoteTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(remoteECPKey))
            {
                checkInputPrv.SetError(keysRemoteSignTxt, "Заполните данное поле");
                return;
            }

            book = new RSABookInfo()
            {
                UserId = StudMail.UserId.ToString(),
                Email = email,
                OwnPrivate = privateKey,
                OwnPublic = publicKey,
                OwnPrivateECP = privateECPKey,
                OwnPublicECP = publicECPKey,
                EmailPublic = remoteKey,
                EmailPublicECP = remoteECPKey
            };

            if (!DBRSABooks.Add(DBConnection.Connection, book))
            {
                checkInputPrv.SetError(keysEmailTxt, "Данная запись уже существует");
                return;
            }

            updateBooksWorker.RunWorkerAsync();
        }

        private void removeKeysBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < keysTable.Rows.Count; i++)
            {
                var selected = (bool) keysTable.Rows[i].Cells["selectedKeyCol"].EditedFormattedValue;
                var email = (string) keysTable.Rows[i].Cells["emailCol"].Value;
                var userId = StudMail.UserId;

                if (selected) DBRSABooks.Remove(DBConnection.Connection, email, userId);
            }

            updateBooksWorker.RunWorkerAsync();
        }

        private void genKeyBtn_Click(object sender, EventArgs e)
        {
            var keys = RSA.GenKeys(RSAKeySize.Key2048);
            keysPrivateTxt.Text = keys.PrivateKey;
            keysPublicTxt.Text = keys.PublicKey;
        }

        private void genKeySignBtn_Click(object sender, EventArgs e)
        {
            var keys = DSA.GenKeyPair();
            keysPrivateSignTxt.Text = Convert.ToBase64String(keys.PrivateKey);
            keysPublicSignTxt.Text = Convert.ToBase64String(keys.PublicKey);
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
            e.Result = DBRSABooks.GetBooks(DBConnection.Connection, StudMail.UserId);
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

            updateServersWorker.RunWorkerAsync();
        }

        private void removeServersBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < serversTable.Rows.Count; i++)
            {
                var selected = (bool) serversTable.Rows[i].Cells["selectedServerCol"].EditedFormattedValue;
                var domain = (string) serversTable.Rows[i].Cells["domainCol"].Value;

                if (selected) DBServers.Remove(DBConnection.Connection, domain);
            }

            updateServersWorker.RunWorkerAsync();
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
