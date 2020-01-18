using MailClient.DB;
using MailClient.Helpers;
using MailKit.Net.Smtp;
using System;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace MailClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DBConnection.DBConnect();
            DBConnection.Open();
        }

        // TODO:
        private void signInBtn_Click(object sender, EventArgs e)
        {
            var email = emailTxt.Text.Trim(' ');
            var password = passwordTxt.Text;
            ServerInfo mailServer;
            UserInfo user = new UserInfo();
            int serverId;

            if (string.IsNullOrEmpty(email))
            {
                checkInputPrv.SetError(emailTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                checkInputPrv.SetError(passwordTxt, "Заполните данное поле");
                return;
            }

            if (!CheckHelper.IsValidEmail(email))
            {
                checkInputPrv.SetError(emailTxt, "Неверный адрес");
                return;
            }

            var domain = AuthHelper.GetDomain(emailTxt.Text);
            mailServer = DBServers.GetServerInfo(DBConnection.Connection, domain);

            // Проверка поддерживаемых серверов

            if (mailServer == null) // Если не нашли соответствующий сервер
            {
                MessageBox.Show("Данный сервер не поддерживается на данный момент");
                return;
            }

            serverId = (int) mailServer.Id;

            // Проверка соединения если нашли поддерживаемый сервер

            if (isNetwork())    // Если есть соединение
            {
                try
                {
                    using (var client = new SmtpClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, ex) => true;
                        client.Connect(mailServer.SmtpHost, (int) mailServer.SmtpPort, mailServer.IsSsl);
                        client.Authenticate(emailTxt.Text, passwordTxt.Text);
                        client.Disconnect(true);

                        // Регистрируем или перезаписываем пользователя в базе данных

                        user = DBUsers.AuthUser(DBConnection.Connection, email, password, serverId);
                    }
                }
                catch (SQLiteException)
                {
                    checkInputPrv.SetError(passwordTxt, "Неверный email или пароль");
                    return;
                }
            }
            else    // Если всё-таки нет соединения
            {
                // Проверяем наличие данного пользователя в БД
                // Если есть, то авторизуемся локально и загружаем письма
                // Если нет, то нужно вывести ошибку

                if (DBUsers.GetLoginAccount(DBConnection.Connection, email, password, serverId) != null)
                {
                    user = DBUsers.AuthUser(DBConnection.Connection, email, password, serverId);
                }
                else
                {
                    checkInputPrv.SetError(emailTxt, "Нет соединения с интернетом, а также локальная " +
                                                     "учётная запись с такими данными не существует");
                    return;
                }
            }

            passwordTxt.Text = "";
            Hide();
            new ClientForm(user).ShowDialog(this);
            Show();
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            checkInputPrv.Clear();
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) signInBtn_Click(null, null);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isNetwork()
        {
            var ping = new Ping();
            var pingReply = ping.Send("google.com");

            return pingReply.Status.ToString().Equals("Success");
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.Close();
            Environment.Exit(0);
        }
    }
}
