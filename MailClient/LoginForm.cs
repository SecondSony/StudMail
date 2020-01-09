using MailClient.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTxt.Text))
            {
                checkInputPrv.SetError(emailTxt, "Заполните данное поле");
                return;
            }

            if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                checkInputPrv.SetError(passwordTxt, "Заполните данное поле");
                return;
            }

            if (!AuthHelper.IsValidEmail(emailTxt.Text))
            {
                checkInputPrv.SetError(emailTxt, "Неверный адрес");
                return;
            }

            passwordTxt.Text = "";
            Hide();
            new ClientForm().ShowDialog(this);
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
    }
}
