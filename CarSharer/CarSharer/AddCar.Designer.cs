namespace CarSharer
{
    partial class AddCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.pslabel = new System.Windows.Forms.Label();
            this.psComboBox = new System.Windows.Forms.ComboBox();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maxSpeedLabel = new System.Windows.Forms.Label();
            this.maxSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gearboxLabel = new System.Windows.Forms.Label();
            this.gearboxComboBox = new System.Windows.Forms.ComboBox();
            this.colourLabel = new System.Windows.Forms.Label();
            this.colourComboBox = new System.Windows.Forms.ComboBox();
            this.licenseClassLabel = new System.Windows.Forms.Label();
            this.licenseClasseComboBox = new System.Windows.Forms.ComboBox();
            this.fuelComboBox = new System.Windows.Forms.ComboBox();
            this.fuelLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(25, 62);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(70, 25);
            this.brandLabel.TabIndex = 0;
            this.brandLabel.Text = "Brand:";
            this.brandLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(95, 66);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 1;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(225, 62);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(72, 25);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model:";
            // 
            // modelComboBox
            // 
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(295, 66);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(121, 21);
            this.modelComboBox.TabIndex = 3;
            // 
            // pslabel
            // 
            this.pslabel.AutoSize = true;
            this.pslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pslabel.Location = new System.Drawing.Point(25, 97);
            this.pslabel.Name = "pslabel";
            this.pslabel.Size = new System.Drawing.Size(45, 25);
            this.pslabel.TabIndex = 4;
            this.pslabel.Text = "PS:";
            // 
            // psComboBox
            // 
            this.psComboBox.FormattingEnabled = true;
            this.psComboBox.Location = new System.Drawing.Point(95, 101);
            this.psComboBox.Name = "psComboBox";
            this.psComboBox.Size = new System.Drawing.Size(121, 21);
            this.psComboBox.TabIndex = 5;
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsLabel.Location = new System.Drawing.Point(225, 97);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(69, 25);
            this.seatsLabel.TabIndex = 6;
            this.seatsLabel.Text = "Seats:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(295, 101);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maxSpeedLabel
            // 
            this.maxSpeedLabel.AutoSize = true;
            this.maxSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxSpeedLabel.Location = new System.Drawing.Point(25, 166);
            this.maxSpeedLabel.Name = "maxSpeedLabel";
            this.maxSpeedLabel.Size = new System.Drawing.Size(119, 25);
            this.maxSpeedLabel.TabIndex = 8;
            this.maxSpeedLabel.Text = "Max.Speed:";
            // 
            // maxSpeedNumericUpDown
            // 
            this.maxSpeedNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxSpeedNumericUpDown.Location = new System.Drawing.Point(145, 170);
            this.maxSpeedNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxSpeedNumericUpDown.Name = "maxSpeedNumericUpDown";
            this.maxSpeedNumericUpDown.Size = new System.Drawing.Size(144, 20);
            this.maxSpeedNumericUpDown.TabIndex = 9;
            this.maxSpeedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gearboxLabel
            // 
            this.gearboxLabel.AutoSize = true;
            this.gearboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearboxLabel.Location = new System.Drawing.Point(25, 201);
            this.gearboxLabel.Name = "gearboxLabel";
            this.gearboxLabel.Size = new System.Drawing.Size(93, 25);
            this.gearboxLabel.TabIndex = 14;
            this.gearboxLabel.Text = "Gearbox:";
            // 
            // gearboxComboBox
            // 
            this.gearboxComboBox.FormattingEnabled = true;
            this.gearboxComboBox.Location = new System.Drawing.Point(165, 205);
            this.gearboxComboBox.Name = "gearboxComboBox";
            this.gearboxComboBox.Size = new System.Drawing.Size(121, 21);
            this.gearboxComboBox.TabIndex = 15;
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourLabel.Location = new System.Drawing.Point(25, 236);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(76, 25);
            this.colourLabel.TabIndex = 16;
            this.colourLabel.Text = "Colour:";
            // 
            // colourComboBox
            // 
            this.colourComboBox.FormattingEnabled = true;
            this.colourComboBox.Location = new System.Drawing.Point(165, 240);
            this.colourComboBox.Name = "colourComboBox";
            this.colourComboBox.Size = new System.Drawing.Size(121, 21);
            this.colourComboBox.TabIndex = 17;
            // 
            // licenseClassLabel
            // 
            this.licenseClassLabel.AutoSize = true;
            this.licenseClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseClassLabel.Location = new System.Drawing.Point(25, 271);
            this.licenseClassLabel.Name = "licenseClassLabel";
            this.licenseClassLabel.Size = new System.Drawing.Size(141, 25);
            this.licenseClassLabel.TabIndex = 18;
            this.licenseClassLabel.Text = "License Class:";
            // 
            // licenseClasseComboBox
            // 
            this.licenseClasseComboBox.FormattingEnabled = true;
            this.licenseClasseComboBox.Location = new System.Drawing.Point(165, 275);
            this.licenseClasseComboBox.Name = "licenseClasseComboBox";
            this.licenseClasseComboBox.Size = new System.Drawing.Size(121, 21);
            this.licenseClasseComboBox.TabIndex = 19;
            // 
            // fuelComboBox
            // 
            this.fuelComboBox.FormattingEnabled = true;
            this.fuelComboBox.Location = new System.Drawing.Point(295, 135);
            this.fuelComboBox.Name = "fuelComboBox";
            this.fuelComboBox.Size = new System.Drawing.Size(121, 21);
            this.fuelComboBox.TabIndex = 23;
            // 
            // fuelLabel
            // 
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelLabel.Location = new System.Drawing.Point(225, 131);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(56, 25);
            this.fuelLabel.TabIndex = 22;
            this.fuelLabel.Text = "Fuel:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(95, 135);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(25, 131);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(62, 25);
            this.priceLabel.TabIndex = 20;
            this.priceLabel.Text = "Price:";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(341, 304);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 24;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 349);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.fuelComboBox);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.licenseClasseComboBox);
            this.Controls.Add(this.licenseClassLabel);
            this.Controls.Add(this.colourComboBox);
            this.Controls.Add(this.colourLabel);
            this.Controls.Add(this.gearboxComboBox);
            this.Controls.Add(this.gearboxLabel);
            this.Controls.Add(this.maxSpeedNumericUpDown);
            this.Controls.Add(this.maxSpeedLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.psComboBox);
            this.Controls.Add(this.pslabel);
            this.Controls.Add(this.modelComboBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.brandLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "AddCar";
            this.Padding = new System.Windows.Forms.Padding(20, 62, 20, 19);
            this.Text = "AddCar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label pslabel;
        private System.Windows.Forms.ComboBox psComboBox;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label maxSpeedLabel;
        private System.Windows.Forms.NumericUpDown maxSpeedNumericUpDown;
        private System.Windows.Forms.Label gearboxLabel;
        private System.Windows.Forms.ComboBox gearboxComboBox;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ComboBox colourComboBox;
        private System.Windows.Forms.Label licenseClassLabel;
        private System.Windows.Forms.ComboBox licenseClasseComboBox;
        private System.Windows.Forms.ComboBox fuelComboBox;
        private System.Windows.Forms.Label fuelLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button confirmButton;
    }
}