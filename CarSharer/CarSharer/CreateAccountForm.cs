using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace CarSharer
{
    public partial class CreateAccountForm : MetroForm
    {
        private LoginForm currentloginForm;

        public CreateAccountForm(LoginForm loginForm)
        {
            InitializeComponent();
            currentloginForm = loginForm;
        }

        private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            currentloginForm.Show();
        }

        private void ProceedTile_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(UsernameTextBox.Text) && string.IsNullOrEmpty(NameTextBox.Text) && string.IsNullOrEmpty(EmailTextBox.Text) && string.IsNullOrEmpty(PasscodeTextBox.Text)))
            {
                DbController.InsertAccount(UsernameTextBox.Text, NameTextBox.Text, DateofbirthDateTime.Value, EmailTextBox.Text, PasscodeTextBox.Text, this);

                currentloginForm.Show();
                this.Close();
            }
            else MetroMessageBox.Show(this, "You have to give us some more information.");
        }
    }
}
