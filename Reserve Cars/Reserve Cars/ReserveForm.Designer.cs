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
            this.Savebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Reservebutton = new System.Windows.Forms.Button();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.CarBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarGearbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(799, 295);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 0;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(880, 295);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
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
            this.CarGridView.BackgroundColor = System.Drawing.Color.White;
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarBrand,
            this.CarModel,
            this.CarPS,
            this.CarSeats,
            this.CarSpeed,
            this.CarPrice,
            this.CarFuel,
            this.CarGearbox,
            this.CarColour});
            this.CarGridView.Location = new System.Drawing.Point(12, 12);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.Size = new System.Drawing.Size(943, 277);
            this.CarGridView.TabIndex = 5;
            this.CarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // CarReserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 330);
            this.Controls.Add(this.CarGridView);
            this.Controls.Add(this.Reservebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Savebutton);
            this.Name = "CarReserver";
            this.Text = "CarReserver";
            this.Load += new System.EventHandler(this.CarReserver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Reservebutton;
        private System.Windows.Forms.DataGridView CarGridView;
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

