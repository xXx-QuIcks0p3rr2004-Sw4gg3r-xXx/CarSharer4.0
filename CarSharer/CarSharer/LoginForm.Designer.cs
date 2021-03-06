﻿namespace CarSharer
{
    partial class LoginForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.passcodeLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasscodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginTile = new MetroFramework.Controls.MetroTile();
            this.CreatAccountTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(23, 63);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 19);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passcodeLabel
            // 
            this.passcodeLabel.AutoSize = true;
            this.passcodeLabel.Location = new System.Drawing.Point(23, 93);
            this.passcodeLabel.Name = "passcodeLabel";
            this.passcodeLabel.Size = new System.Drawing.Size(62, 19);
            this.passcodeLabel.TabIndex = 1;
            this.passcodeLabel.Text = "Passcode";
            // 
            // UsernameTextBox
            // 
            // 
            // 
            // 
            this.UsernameTextBox.CustomButton.Image = null;
            this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.UsernameTextBox.CustomButton.Name = "";
            this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBox.CustomButton.TabIndex = 1;
            this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBox.CustomButton.UseSelectable = true;
            this.UsernameTextBox.CustomButton.Visible = false;
            this.UsernameTextBox.Lines = new string[0];
            this.UsernameTextBox.Location = new System.Drawing.Point(175, 60);
            this.UsernameTextBox.MaxLength = 32767;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.SelectionLength = 0;
            this.UsernameTextBox.SelectionStart = 0;
            this.UsernameTextBox.ShortcutsEnabled = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(75, 23);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameTextBox_KeyDown);
            // 
            // PasscodeTextBox
            // 
            // 
            // 
            // 
            this.PasscodeTextBox.CustomButton.Image = null;
            this.PasscodeTextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.PasscodeTextBox.CustomButton.Name = "";
            this.PasscodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasscodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasscodeTextBox.CustomButton.TabIndex = 1;
            this.PasscodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasscodeTextBox.CustomButton.UseSelectable = true;
            this.PasscodeTextBox.CustomButton.Visible = false;
            this.PasscodeTextBox.Lines = new string[0];
            this.PasscodeTextBox.Location = new System.Drawing.Point(175, 89);
            this.PasscodeTextBox.MaxLength = 32767;
            this.PasscodeTextBox.Name = "PasscodeTextBox";
            this.PasscodeTextBox.PasswordChar = '\0';
            this.PasscodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasscodeTextBox.SelectedText = "";
            this.PasscodeTextBox.SelectionLength = 0;
            this.PasscodeTextBox.SelectionStart = 0;
            this.PasscodeTextBox.ShortcutsEnabled = true;
            this.PasscodeTextBox.Size = new System.Drawing.Size(75, 23);
            this.PasscodeTextBox.TabIndex = 3;
            this.PasscodeTextBox.UseSelectable = true;
            this.PasscodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasscodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PasscodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasscodeTextBox_KeyDown);
            // 
            // LoginTile
            // 
            this.LoginTile.ActiveControl = null;
            this.LoginTile.Location = new System.Drawing.Point(175, 141);
            this.LoginTile.Name = "LoginTile";
            this.LoginTile.Size = new System.Drawing.Size(75, 39);
            this.LoginTile.TabIndex = 4;
            this.LoginTile.Text = "Login";
            this.LoginTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginTile.UseSelectable = true;
            this.LoginTile.Click += new System.EventHandler(this.LoginTile_Click);
            // 
            // CreatAccountTile
            // 
            this.CreatAccountTile.ActiveControl = null;
            this.CreatAccountTile.Location = new System.Drawing.Point(23, 141);
            this.CreatAccountTile.Name = "CreatAccountTile";
            this.CreatAccountTile.Size = new System.Drawing.Size(146, 39);
            this.CreatAccountTile.TabIndex = 5;
            this.CreatAccountTile.Text = "Create Account";
            this.CreatAccountTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreatAccountTile.UseSelectable = true;
            this.CreatAccountTile.Click += new System.EventHandler(this.CreatAccountTile_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.CreatAccountTile);
            this.Controls.Add(this.LoginTile);
            this.Controls.Add(this.PasscodeTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.passcodeLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passcodeLabel;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroTextBox PasscodeTextBox;
        private MetroFramework.Controls.MetroTile LoginTile;
        private MetroFramework.Controls.MetroTile CreatAccountTile;
    }
}

