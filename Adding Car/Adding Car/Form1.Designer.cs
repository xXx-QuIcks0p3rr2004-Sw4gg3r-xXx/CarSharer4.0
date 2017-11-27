namespace Adding_Car
{
    partial class addACar
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
            this.addButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.seatsComboBox = new System.Windows.Forms.ComboBox();
            this.gearboxLabel = new System.Windows.Forms.Label();
            this.gearboxComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(643, 496);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(562, 496);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // brandLabel
            // 
            this.brandLabel.Location = new System.Drawing.Point(40, 18);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(78, 21);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand:";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(124, 18);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 3;
            // 
            // seatsLabel
            // 
            this.seatsLabel.Location = new System.Drawing.Point(40, 51);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(78, 23);
            this.seatsLabel.TabIndex = 4;
            this.seatsLabel.Text = "Seats:";
            this.seatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seatsComboBox
            // 
            this.seatsComboBox.FormattingEnabled = true;
            this.seatsComboBox.Location = new System.Drawing.Point(124, 53);
            this.seatsComboBox.Name = "seatsComboBox";
            this.seatsComboBox.Size = new System.Drawing.Size(121, 21);
            this.seatsComboBox.TabIndex = 5;
            // 
            // gearboxLabel
            // 
            this.gearboxLabel.Location = new System.Drawing.Point(40, 87);
            this.gearboxLabel.Name = "gearboxLabel";
            this.gearboxLabel.Size = new System.Drawing.Size(78, 23);
            this.gearboxLabel.TabIndex = 6;
            this.gearboxLabel.Text = "Gearbox:";
            this.gearboxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gearboxComboBox
            // 
            this.gearboxComboBox.FormattingEnabled = true;
            this.gearboxComboBox.Location = new System.Drawing.Point(124, 89);
            this.gearboxComboBox.Name = "gearboxComboBox";
            this.gearboxComboBox.Size = new System.Drawing.Size(121, 21);
            this.gearboxComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Maximum Speed:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxSpeedNumericUpDown
            // 
            this.maxSpeedNumericUpDown.Location = new System.Drawing.Point(125, 127);
            this.maxSpeedNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxSpeedNumericUpDown.Name = "maxSpeedNumericUpDown";
            this.maxSpeedNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maxSpeedNumericUpDown.TabIndex = 9;
            this.maxSpeedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 531);
            this.Controls.Add(this.maxSpeedNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gearboxComboBox);
            this.Controls.Add(this.gearboxLabel);
            this.Controls.Add(this.seatsComboBox);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.addButton);
            this.Name = "addACar";
            this.Text = "Add a Car";
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.ComboBox seatsComboBox;
        private System.Windows.Forms.Label gearboxLabel;
        private System.Windows.Forms.ComboBox gearboxComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxSpeedNumericUpDown;
    }
}

