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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Car_ID");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Brand");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Model");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Reserved");
            this.Savebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.CarList = new System.Windows.Forms.ListView();
            this.Car_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reservebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(627, 543);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 0;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(708, 543);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // CarList
            // 
            this.CarList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Car_ID});
            this.CarList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.CarList.Location = new System.Drawing.Point(12, 12);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(771, 525);
            this.CarList.TabIndex = 3;
            this.CarList.UseCompatibleStateImageBehavior = false;
            // 
            // Reservebutton
            // 
            this.Reservebutton.Location = new System.Drawing.Point(12, 543);
            this.Reservebutton.Name = "Reservebutton";
            this.Reservebutton.Size = new System.Drawing.Size(124, 23);
            this.Reservebutton.TabIndex = 4;
            this.Reservebutton.Text = "Reserve selected Car";
            this.Reservebutton.UseVisualStyleBackColor = true;
            // 
            // CarReserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 578);
            this.Controls.Add(this.Reservebutton);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Savebutton);
            this.Name = "CarReserver";
            this.Text = "CarReserver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.ListView CarList;
        private System.Windows.Forms.ColumnHeader Car_ID;
        private System.Windows.Forms.Button Reservebutton;
    }
}

