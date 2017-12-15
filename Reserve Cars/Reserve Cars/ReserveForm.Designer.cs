namespace Reserve_Cars
{
    partial class CarReserver
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Reservebutton = new System.Windows.Forms.Button();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarGearbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeCarsLabel = new System.Windows.Forms.Label();
            this.CarCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(840, 295);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Reservebutton
            // 
            this.Reservebutton.Location = new System.Drawing.Point(12, 295);
            this.Reservebutton.Name = "Reservebutton";
            this.Reservebutton.Size = new System.Drawing.Size(124, 23);
            this.Reservebutton.TabIndex = 4;
            this.Reservebutton.Text = "Reserve selected Car";
            this.Reservebutton.UseVisualStyleBackColor = true;
            this.Reservebutton.Click += new System.EventHandler(this.Reservebutton_Click);
            // 
            // CarGridView
            // 
            this.CarGridView.AllowUserToResizeColumns = false;
            this.CarGridView.AllowUserToResizeRows = false;
            this.CarGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarId,
            this.CarBrand,
            this.CarModel,
            this.CarPS,
            this.CarSeats,
            this.CarSpeed,
            this.CarPrice,
            this.CarFuel,
            this.CarGearbox,
            this.CarColour});
            this.CarGridView.Location = new System.Drawing.Point(12, 25);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowHeadersVisible = false;
            this.CarGridView.Size = new System.Drawing.Size(903, 264);
            this.CarGridView.TabIndex = 5;
            this.CarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CarId
            // 
            this.CarId.HeaderText = "id";
            this.CarId.Name = "CarId";
            this.CarId.ReadOnly = true;
            this.CarId.Visible = false;
            // 
            // CarBrand
            // 
            this.CarBrand.HeaderText = "Brand";
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.HeaderText = "Model";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // CarPS
            // 
            this.CarPS.HeaderText = "PS";
            this.CarPS.Name = "CarPS";
            this.CarPS.ReadOnly = true;
            // 
            // CarSeats
            // 
            this.CarSeats.HeaderText = "Seats";
            this.CarSeats.Name = "CarSeats";
            this.CarSeats.ReadOnly = true;
            // 
            // CarSpeed
            // 
            this.CarSpeed.HeaderText = "Max V.";
            this.CarSpeed.Name = "CarSpeed";
            this.CarSpeed.ReadOnly = true;
            // 
            // CarPrice
            // 
            this.CarPrice.HeaderText = "Price";
            this.CarPrice.Name = "CarPrice";
            this.CarPrice.ReadOnly = true;
            // 
            // CarFuel
            // 
            this.CarFuel.HeaderText = "Fuel";
            this.CarFuel.Name = "CarFuel";
            this.CarFuel.ReadOnly = true;
            // 
            // CarGearbox
            // 
            this.CarGearbox.HeaderText = "Gearbox";
            this.CarGearbox.Name = "CarGearbox";
            this.CarGearbox.ReadOnly = true;
            // 
            // CarColour
            // 
            this.CarColour.HeaderText = "Colour";
            this.CarColour.Name = "CarColour";
            this.CarColour.ReadOnly = true;
            // 
            // FreeCarsLabel
            // 
            this.FreeCarsLabel.AutoSize = true;
            this.FreeCarsLabel.Location = new System.Drawing.Point(12, 9);
            this.FreeCarsLabel.Name = "FreeCarsLabel";
            this.FreeCarsLabel.Size = new System.Drawing.Size(55, 13);
            this.FreeCarsLabel.TabIndex = 6;
            this.FreeCarsLabel.Text = "Free Cars:";
            // 
            // CarCheckBox
            // 
            this.CarCheckBox.AutoSize = true;
            this.CarCheckBox.Location = new System.Drawing.Point(142, 299);
            this.CarCheckBox.Name = "CarCheckBox";
            this.CarCheckBox.Size = new System.Drawing.Size(121, 17);
            this.CarCheckBox.TabIndex = 7;
            this.CarCheckBox.Text = "Show reserved Cars";
            this.CarCheckBox.UseVisualStyleBackColor = true;
            this.CarCheckBox.CheckedChanged += new System.EventHandler(this.CarCheckBox_CheckedChanged);
            // 
            // CarReserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 330);
            this.Controls.Add(this.CarCheckBox);
            this.Controls.Add(this.FreeCarsLabel);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.Reservebutton);
            this.Controls.Add(this.Exitbutton);
            this.Name = "CarReserver";
            this.Text = "CarReserver";
            this.Load += new System.EventHandler(this.CarReserver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Reservebutton;
        private System.Windows.Forms.DataGridView CarGridView;
        private System.Windows.Forms.Label FreeCarsLabel;
        private System.Windows.Forms.CheckBox CarCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarFuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarGearbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarColour;
    }
}

