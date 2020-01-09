using System;
using System.Collections.Generic;
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

        public ClientForm()
        {
            InitializeComponent();

            boxesList.Items.Add("asdgf");
            boxesList.Items.Add("asdgf");
            boxesList.Items.Add("asdgf");
            lettersList.Items.Add("qwerty");
            lettersList.Items.Add("qwerty");
            lettersList.Items.Add("qwerty");

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


        #endregion

        #region Обработка вкладки серверов

        private void addServerBtn_Click(object sender, EventArgs e)
        {

        }

        private void removeServersBtn_Click(object sender, EventArgs e)
        {

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

        #endregion
    }
}
