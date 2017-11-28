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
            this.gearLabel = new System.Windows.Forms.Label();
            this.gearComboBox = new System.Windows.Forms.ComboBox();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.maxSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colourLabel = new System.Windows.Forms.Label();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enginePowerLabel = new System.Windows.Forms.Label();
            this.enginePowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nrofdoorsLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginePowerNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(408, 370);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(327, 370);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // brandLabel
            // 
            this.brandLabel.Location = new System.Drawing.Point(12, 18);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(106, 21);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand:";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Hundai",
            "Mercedes",
            "Porsche",
            "Volkswagen"});
            this.brandComboBox.Location = new System.Drawing.Point(125, 18);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.Sorted = true;
            this.brandComboBox.TabIndex = 3;
            // 
            // seatsLabel
            // 
            this.seatsLabel.Location = new System.Drawing.Point(12, 229);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(106, 23);
            this.seatsLabel.TabIndex = 4;
            this.seatsLabel.Text = "Seats:";
            this.seatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seatsComboBox
            // 
            this.seatsComboBox.FormattingEnabled = true;
            this.seatsComboBox.Location = new System.Drawing.Point(124, 231);
            this.seatsComboBox.Name = "seatsComboBox";
            this.seatsComboBox.Size = new System.Drawing.Size(121, 21);
            this.seatsComboBox.TabIndex = 5;
            // 
            // gearLabel
            // 
            this.gearLabel.Location = new System.Drawing.Point(12, 120);
            this.gearLabel.Name = "gearLabel";
            this.gearLabel.Size = new System.Drawing.Size(106, 23);
            this.gearLabel.TabIndex = 6;
            this.gearLabel.Text = "Gear:";
            this.gearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gearComboBox
            // 
            this.gearComboBox.FormattingEnabled = true;
            this.gearComboBox.Location = new System.Drawing.Point(125, 122);
            this.gearComboBox.Name = "gearComboBox";
            this.gearComboBox.Size = new System.Drawing.Size(121, 21);
            this.gearComboBox.TabIndex = 7;
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.Location = new System.Drawing.Point(12, 154);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(106, 27);
            this.maxSpeedLabel.TabIndex = 8;
            this.maxSpeedLabel.Text = "Maximum Speed:";
            this.maxSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxSpeedNumericUpDown
            // 
            this.maxSpeedNumericUpDown.Location = new System.Drawing.Point(125, 159);
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
            // colourLabel
            // 
            this.colourLabel.Location = new System.Drawing.Point(12, 195);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(106, 23);
            this.colourLabel.TabIndex = 10;
            this.colourLabel.Text = "Colour:";
            this.colourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colourComboBox
            // 
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Location = new System.Drawing.Point(124, 197);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(121, 21);
            this.colourComboBox.TabIndex = 11;
            // 
            // modelLabel
            // 
            this.modelLabel.Location = new System.Drawing.Point(12, 50);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(106, 23);
            this.modelLabel.TabIndex = 12;
            this.modelLabel.Text = "Model:";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 13;
            // 
            // enginePowerLabel
            // 
            this.enginePowerLabel.Location = new System.Drawing.Point(12, 86);
            this.enginePowerLabel.Name = "enginePowerLabel";
            this.enginePowerLabel.Size = new System.Drawing.Size(106, 23);
            this.enginePowerLabel.TabIndex = 14;
            this.enginePowerLabel.Text = "Engine Power:";
            this.enginePowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enginePowerNumericUpDown
            // 
            this.enginePowerNumericUpDown.Location = new System.Drawing.Point(124, 89);
            this.enginePowerNumericUpDown.Name = "enginePowerNumericUpDown";
            this.enginePowerNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.enginePowerNumericUpDown.TabIndex = 15;
            this.enginePowerNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nrofdoorsLabel
            // 
            this.nrofdoorsLabel.Location = new System.Drawing.Point(15, 263);
            this.nrofdoorsLabel.Name = "nrofdoorsLabel";
            this.nrofdoorsLabel.Size = new System.Drawing.Size(103, 23);
            this.nrofdoorsLabel.TabIndex = 16;
            this.nrofdoorsLabel.Text = "Nr. of Doors";
            this.nrofdoorsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // addACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nrofdoorsLabel);
            this.Controls.Add(this.enginePowerNumericUpDown);
            this.Controls.Add(this.enginePowerLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.maxSpeedNumericUpDown);
            this.Controls.Add(this.maxSpeedLabel);
            this.Controls.Add(this.gearComboBox);
            this.Controls.Add(this.gearLabel);
            this.Controls.Add(this.seatsComboBox);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.addButton);
            this.Name = "addACar";
            this.Text = "Add a Car";
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginePowerNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.ComboBox seatsComboBox;
        private System.Windows.Forms.Label gearLabel;
        private System.Windows.Forms.ComboBox gearComboBox;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.NumericUpDown maxSpeedNumericUpDown;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label enginePowerLabel;
        private System.Windows.Forms.NumericUpDown enginePowerNumericUpDown;
        private System.Windows.Forms.Label nrofdoorsLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

