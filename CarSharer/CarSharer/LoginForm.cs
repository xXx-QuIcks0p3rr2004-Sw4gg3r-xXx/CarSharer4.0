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
            DbController.ValidatePasscode(UsernameTextBox.Text, PasscodeTextBox.Text);
        }

        private void PasscodeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                UsernameTextBox.Focus();
            }
        }


        private void PasscodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(PasscodeTextBox.Text))
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
                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    UsernameTextBox.Focus();
                }
                else
                {
                    LoginTile_Click(null, EventArgs.Empty);
                }
            }
        }
    }
}
