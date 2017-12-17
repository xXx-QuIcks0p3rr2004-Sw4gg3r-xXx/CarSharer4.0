using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace CarSharer
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginTile_Click(object sender, EventArgs e)
        {
            if (DbController.ValidatePasscode(UsernameTextBox.Text, PasscodeTextBox.Text))
            {
                MainForm myMainForm = new MainForm(this, true);
                myMainForm.Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "The username or passcode is not valid.");
            }
        }

        private void PasscodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                UsernameTextBox.Focus();
            }
            else
            {
                LoginTile_Click(null, EventArgs.Empty);
            }
        }


        private void PasscodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    PasscodeTextBox.Focus();
                }
                else
                {
                    LoginTile_Click(null, EventArgs.Empty);
                }
            }
        }

        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(PasscodeTextBox.Text))
                {
                    UsernameTextBox.Focus();
                }
                else
                {
                    LoginTile_Click(null, EventArgs.Empty);
                }
            }
        }

        private void CreatAccountTile_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm(this);
            this.Hide();
            createAccountForm.Show();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginTile_Click(null, EventArgs.Empty);
            }
        }
    }
}
