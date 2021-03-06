﻿namespace CarSharer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.vehicleTabPage = new MetroFramework.Controls.MetroTabPage();
            this.BlockButton = new System.Windows.Forms.Button();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
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
            this.CarCheckBox = new System.Windows.Forms.CheckBox();
            this.optionTabPage = new MetroFramework.Controls.MetroTabPage();
            this.ordnenComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ordnenLabel = new MetroFramework.Controls.MetroLabel();
            this.farbeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.farbeLabel = new MetroFramework.Controls.MetroLabel();
            this.leitmotivComboBox = new MetroFramework.Controls.MetroComboBox();
            this.leitmotivLabel = new MetroFramework.Controls.MetroLabel();
            this.addVehicleTabPage = new MetroFramework.Controls.MetroTabPage();
            this.priceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.statusTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fuelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.gearboxTextBox = new MetroFramework.Controls.MetroTextBox();
            this.modelTextBox = new MetroFramework.Controls.MetroTextBox();
            this.brandTextBox = new MetroFramework.Controls.MetroTextBox();
            this.seatsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.powerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.bearbeitenTile = new MetroFramework.Controls.MetroTile();
            this.entfernenTile = new MetroFramework.Controls.MetroTile();
            this.hinzufügenTile = new MetroFramework.Controls.MetroTile();
            this.priceTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gearboxTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fuelTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.statusTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.seatsTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.powerTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.brandTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.modelTextLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ReserveTile = new MetroFramework.Controls.MetroTile();
            this.DriveTile = new MetroFramework.Controls.MetroTile();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.vehicleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.optionTabPage.SuspendLayout();
            this.addVehicleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.vehicleTabPage);
            this.tabControl.Controls.Add(this.optionTabPage);
            this.tabControl.Controls.Add(this.addVehicleTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 83);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(920, 423);
            this.tabControl.TabIndex = 1;
            this.tabControl.UseSelectable = true;
            // 
            // vehicleTabPage
            // 
            this.vehicleTabPage.Controls.Add(this.Exitbutton);
            this.vehicleTabPage.Controls.Add(this.DriveTile);
            this.vehicleTabPage.Controls.Add(this.ReserveTile);
            this.vehicleTabPage.Controls.Add(this.BlockButton);
            this.vehicleTabPage.Controls.Add(this.AdminCheckBox);
            this.vehicleTabPage.Controls.Add(this.CarGridView);
            this.vehicleTabPage.Controls.Add(this.CarCheckBox);
            this.vehicleTabPage.HorizontalScrollbarBarColor = true;
            this.vehicleTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.vehicleTabPage.HorizontalScrollbarSize = 10;
            this.vehicleTabPage.Location = new System.Drawing.Point(4, 38);
            this.vehicleTabPage.Name = "vehicleTabPage";
            this.vehicleTabPage.Size = new System.Drawing.Size(912, 381);
            this.vehicleTabPage.TabIndex = 4;
            this.vehicleTabPage.Text = "Fahrzeuge";
            this.vehicleTabPage.VerticalScrollbarBarColor = true;
            this.vehicleTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.vehicleTabPage.VerticalScrollbarSize = 10;
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(486, 297);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(104, 23);
            this.BlockButton.TabIndex = 17;
            this.BlockButton.Text = "Block selected Car";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(384, 301);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(96, 17);
            this.AdminCheckBox.TabIndex = 16;
            this.AdminCheckBox.Text = "ADMIN-Modus";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            this.AdminCheckBox.CheckedChanged += new System.EventHandler(this.AdminCheckBox_CheckedChanged);
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
            this.CarGridView.Location = new System.Drawing.Point(3, 5);
            this.CarGridView.MultiSelect = false;
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.ReadOnly = true;
            this.CarGridView.RowHeadersVisible = false;
            this.CarGridView.Size = new System.Drawing.Size(903, 277);
            this.CarGridView.TabIndex = 13;
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
            // CarCheckBox
            // 
            this.CarCheckBox.AutoSize = true;
            this.CarCheckBox.Location = new System.Drawing.Point(132, 301);
            this.CarCheckBox.Name = "CarCheckBox";
            this.CarCheckBox.Size = new System.Drawing.Size(121, 17);
            this.CarCheckBox.TabIndex = 14;
            this.CarCheckBox.Text = "Show reserved Cars";
            this.CarCheckBox.UseVisualStyleBackColor = true;
            this.CarCheckBox.CheckedChanged += new System.EventHandler(this.CarCheckBox_CheckedChanged);
            // 
            // optionTabPage
            // 
            this.optionTabPage.Controls.Add(this.ordnenComboBox);
            this.optionTabPage.Controls.Add(this.ordnenLabel);
            this.optionTabPage.Controls.Add(this.farbeComboBox);
            this.optionTabPage.Controls.Add(this.farbeLabel);
            this.optionTabPage.Controls.Add(this.leitmotivComboBox);
            this.optionTabPage.Controls.Add(this.leitmotivLabel);
            this.optionTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTabPage.HorizontalScrollbarBarColor = true;
            this.optionTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.optionTabPage.HorizontalScrollbarSize = 10;
            this.optionTabPage.Location = new System.Drawing.Point(4, 38);
            this.optionTabPage.Name = "optionTabPage";
            this.optionTabPage.Size = new System.Drawing.Size(887, 320);
            this.optionTabPage.TabIndex = 6;
            this.optionTabPage.Text = "Optionen";
            this.optionTabPage.VerticalScrollbarBarColor = true;
            this.optionTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.optionTabPage.VerticalScrollbarSize = 10;
            // 
            // ordnenComboBox
            // 
            this.ordnenComboBox.FormattingEnabled = true;
            this.ordnenComboBox.ItemHeight = 23;
            this.ordnenComboBox.Items.AddRange(new object[] {
            "aufsteigend",
            "absteigend"});
            this.ordnenComboBox.Location = new System.Drawing.Point(102, 73);
            this.ordnenComboBox.Name = "ordnenComboBox";
            this.ordnenComboBox.Size = new System.Drawing.Size(121, 29);
            this.ordnenComboBox.TabIndex = 7;
            this.ordnenComboBox.UseSelectable = true;
            // 
            // ordnenLabel
            // 
            this.ordnenLabel.AutoSize = true;
            this.ordnenLabel.Location = new System.Drawing.Point(30, 76);
            this.ordnenLabel.Name = "ordnenLabel";
            this.ordnenLabel.Size = new System.Drawing.Size(69, 19);
            this.ordnenLabel.TabIndex = 6;
            this.ordnenLabel.Text = "Ordnen   :";
            // 
            // farbeComboBox
            // 
            this.farbeComboBox.FormattingEnabled = true;
            this.farbeComboBox.ItemHeight = 23;
            this.farbeComboBox.Items.AddRange(new object[] {
            "Standard",
            "Schwarz",
            "Weiß",
            "Silber / Grau",
            "Blau",
            "Grün",
            "Hellgrün",
            "Seegrün",
            "Orange",
            "Braun",
            "Pink",
            "Magenta",
            "Violett",
            "Rot",
            "Gelb"});
            this.farbeComboBox.Location = new System.Drawing.Point(435, 24);
            this.farbeComboBox.Name = "farbeComboBox";
            this.farbeComboBox.Size = new System.Drawing.Size(121, 29);
            this.farbeComboBox.TabIndex = 5;
            this.farbeComboBox.UseSelectable = true;
            this.farbeComboBox.SelectedIndexChanged += new System.EventHandler(this.FarbeComboBox_SelectedIndexChanged);
            // 
            // farbeLabel
            // 
            this.farbeLabel.AutoSize = true;
            this.farbeLabel.BackColor = System.Drawing.Color.White;
            this.farbeLabel.Location = new System.Drawing.Point(383, 27);
            this.farbeLabel.Name = "farbeLabel";
            this.farbeLabel.Size = new System.Drawing.Size(49, 19);
            this.farbeLabel.TabIndex = 4;
            this.farbeLabel.Text = "Farbe :";
            // 
            // leitmotivComboBox
            // 
            this.leitmotivComboBox.FormattingEnabled = true;
            this.leitmotivComboBox.ItemHeight = 23;
            this.leitmotivComboBox.Items.AddRange(new object[] {
            "Hell",
            "Dunkel"});
            this.leitmotivComboBox.Location = new System.Drawing.Point(102, 24);
            this.leitmotivComboBox.Name = "leitmotivComboBox";
            this.leitmotivComboBox.Size = new System.Drawing.Size(121, 29);
            this.leitmotivComboBox.TabIndex = 3;
            this.leitmotivComboBox.UseSelectable = true;
            this.leitmotivComboBox.SelectedIndexChanged += new System.EventHandler(this.LeitmotivComboBox_SelectedIndexChanged);
            // 
            // leitmotivLabel
            // 
            this.leitmotivLabel.AutoSize = true;
            this.leitmotivLabel.BackColor = System.Drawing.Color.White;
            this.leitmotivLabel.Location = new System.Drawing.Point(30, 27);
            this.leitmotivLabel.Name = "leitmotivLabel";
            this.leitmotivLabel.Size = new System.Drawing.Size(69, 19);
            this.leitmotivLabel.TabIndex = 2;
            this.leitmotivLabel.Text = "Leitmotiv :";
            // 
            // addVehicleTabPage
            // 
            this.addVehicleTabPage.Controls.Add(this.priceTextBox);
            this.addVehicleTabPage.Controls.Add(this.statusTextBox);
            this.addVehicleTabPage.Controls.Add(this.fuelTextBox);
            this.addVehicleTabPage.Controls.Add(this.gearboxTextBox);
            this.addVehicleTabPage.Controls.Add(this.modelTextBox);
            this.addVehicleTabPage.Controls.Add(this.brandTextBox);
            this.addVehicleTabPage.Controls.Add(this.seatsTextBox);
            this.addVehicleTabPage.Controls.Add(this.powerTextBox);
            this.addVehicleTabPage.Controls.Add(this.bearbeitenTile);
            this.addVehicleTabPage.Controls.Add(this.entfernenTile);
            this.addVehicleTabPage.Controls.Add(this.hinzufügenTile);
            this.addVehicleTabPage.Controls.Add(this.priceTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.gearboxTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.fuelTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.statusTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.seatsTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.powerTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.brandTextLabel1);
            this.addVehicleTabPage.Controls.Add(this.modelTextLabel1);
            this.addVehicleTabPage.HorizontalScrollbarBarColor = true;
            this.addVehicleTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.addVehicleTabPage.HorizontalScrollbarSize = 10;
            this.addVehicleTabPage.Location = new System.Drawing.Point(4, 38);
            this.addVehicleTabPage.Name = "addVehicleTabPage";
            this.addVehicleTabPage.Size = new System.Drawing.Size(887, 320);
            this.addVehicleTabPage.TabIndex = 7;
            this.addVehicleTabPage.Text = "Farzeuge hinzufügen";
            this.addVehicleTabPage.VerticalScrollbarBarColor = true;
            this.addVehicleTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.addVehicleTabPage.VerticalScrollbarSize = 10;
            // 
            // priceTextBox
            // 
            // 
            // 
            // 
            this.priceTextBox.CustomButton.Image = null;
            this.priceTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.priceTextBox.CustomButton.Name = "";
            this.priceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.priceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.priceTextBox.CustomButton.TabIndex = 1;
            this.priceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.priceTextBox.CustomButton.UseSelectable = true;
            this.priceTextBox.CustomButton.Visible = false;
            this.priceTextBox.Lines = new string[0];
            this.priceTextBox.Location = new System.Drawing.Point(144, 239);
            this.priceTextBox.MaxLength = 32767;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.SelectionLength = 0;
            this.priceTextBox.SelectionStart = 0;
            this.priceTextBox.ShortcutsEnabled = true;
            this.priceTextBox.Size = new System.Drawing.Size(118, 23);
            this.priceTextBox.TabIndex = 42;
            this.priceTextBox.UseSelectable = true;
            this.priceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.priceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // statusTextBox
            // 
            // 
            // 
            // 
            this.statusTextBox.CustomButton.Image = null;
            this.statusTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.statusTextBox.CustomButton.Name = "";
            this.statusTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.statusTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.statusTextBox.CustomButton.TabIndex = 1;
            this.statusTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.statusTextBox.CustomButton.UseSelectable = true;
            this.statusTextBox.CustomButton.Visible = false;
            this.statusTextBox.Lines = new string[0];
            this.statusTextBox.Location = new System.Drawing.Point(144, 210);
            this.statusTextBox.MaxLength = 32767;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.PasswordChar = '\0';
            this.statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statusTextBox.SelectedText = "";
            this.statusTextBox.SelectionLength = 0;
            this.statusTextBox.SelectionStart = 0;
            this.statusTextBox.ShortcutsEnabled = true;
            this.statusTextBox.Size = new System.Drawing.Size(118, 23);
            this.statusTextBox.TabIndex = 41;
            this.statusTextBox.UseSelectable = true;
            this.statusTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.statusTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fuelTextBox
            // 
            // 
            // 
            // 
            this.fuelTextBox.CustomButton.Image = null;
            this.fuelTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.fuelTextBox.CustomButton.Name = "";
            this.fuelTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.fuelTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fuelTextBox.CustomButton.TabIndex = 1;
            this.fuelTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fuelTextBox.CustomButton.UseSelectable = true;
            this.fuelTextBox.CustomButton.Visible = false;
            this.fuelTextBox.Lines = new string[0];
            this.fuelTextBox.Location = new System.Drawing.Point(144, 162);
            this.fuelTextBox.MaxLength = 32767;
            this.fuelTextBox.Name = "fuelTextBox";
            this.fuelTextBox.PasswordChar = '\0';
            this.fuelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fuelTextBox.SelectedText = "";
            this.fuelTextBox.SelectionLength = 0;
            this.fuelTextBox.SelectionStart = 0;
            this.fuelTextBox.ShortcutsEnabled = true;
            this.fuelTextBox.Size = new System.Drawing.Size(118, 23);
            this.fuelTextBox.TabIndex = 40;
            this.fuelTextBox.UseSelectable = true;
            this.fuelTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fuelTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gearboxTextBox
            // 
            // 
            // 
            // 
            this.gearboxTextBox.CustomButton.Image = null;
            this.gearboxTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.gearboxTextBox.CustomButton.Name = "";
            this.gearboxTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gearboxTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gearboxTextBox.CustomButton.TabIndex = 1;
            this.gearboxTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gearboxTextBox.CustomButton.UseSelectable = true;
            this.gearboxTextBox.CustomButton.Visible = false;
            this.gearboxTextBox.Lines = new string[0];
            this.gearboxTextBox.Location = new System.Drawing.Point(144, 133);
            this.gearboxTextBox.MaxLength = 32767;
            this.gearboxTextBox.Name = "gearboxTextBox";
            this.gearboxTextBox.PasswordChar = '\0';
            this.gearboxTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gearboxTextBox.SelectedText = "";
            this.gearboxTextBox.SelectionLength = 0;
            this.gearboxTextBox.SelectionStart = 0;
            this.gearboxTextBox.ShortcutsEnabled = true;
            this.gearboxTextBox.Size = new System.Drawing.Size(118, 23);
            this.gearboxTextBox.TabIndex = 39;
            this.gearboxTextBox.UseSelectable = true;
            this.gearboxTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gearboxTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // modelTextBox
            // 
            // 
            // 
            // 
            this.modelTextBox.CustomButton.Image = null;
            this.modelTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.modelTextBox.CustomButton.Name = "";
            this.modelTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.modelTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.modelTextBox.CustomButton.TabIndex = 1;
            this.modelTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.modelTextBox.CustomButton.UseSelectable = true;
            this.modelTextBox.CustomButton.Visible = false;
            this.modelTextBox.Lines = new string[0];
            this.modelTextBox.Location = new System.Drawing.Point(144, 17);
            this.modelTextBox.MaxLength = 32767;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.PasswordChar = '\0';
            this.modelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.modelTextBox.SelectedText = "";
            this.modelTextBox.SelectionLength = 0;
            this.modelTextBox.SelectionStart = 0;
            this.modelTextBox.ShortcutsEnabled = true;
            this.modelTextBox.Size = new System.Drawing.Size(118, 23);
            this.modelTextBox.TabIndex = 38;
            this.modelTextBox.UseSelectable = true;
            this.modelTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.modelTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // brandTextBox
            // 
            // 
            // 
            // 
            this.brandTextBox.CustomButton.Image = null;
            this.brandTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.brandTextBox.CustomButton.Name = "";
            this.brandTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.brandTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.brandTextBox.CustomButton.TabIndex = 1;
            this.brandTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.brandTextBox.CustomButton.UseSelectable = true;
            this.brandTextBox.CustomButton.Visible = false;
            this.brandTextBox.Lines = new string[0];
            this.brandTextBox.Location = new System.Drawing.Point(144, 46);
            this.brandTextBox.MaxLength = 32767;
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.PasswordChar = '\0';
            this.brandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.brandTextBox.SelectedText = "";
            this.brandTextBox.SelectionLength = 0;
            this.brandTextBox.SelectionStart = 0;
            this.brandTextBox.ShortcutsEnabled = true;
            this.brandTextBox.Size = new System.Drawing.Size(118, 23);
            this.brandTextBox.TabIndex = 37;
            this.brandTextBox.UseSelectable = true;
            this.brandTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.brandTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seatsTextBox
            // 
            // 
            // 
            // 
            this.seatsTextBox.CustomButton.Image = null;
            this.seatsTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.seatsTextBox.CustomButton.Name = "";
            this.seatsTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.seatsTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seatsTextBox.CustomButton.TabIndex = 1;
            this.seatsTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seatsTextBox.CustomButton.UseSelectable = true;
            this.seatsTextBox.CustomButton.Visible = false;
            this.seatsTextBox.Lines = new string[0];
            this.seatsTextBox.Location = new System.Drawing.Point(144, 104);
            this.seatsTextBox.MaxLength = 32767;
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.PasswordChar = '\0';
            this.seatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seatsTextBox.SelectedText = "";
            this.seatsTextBox.SelectionLength = 0;
            this.seatsTextBox.SelectionStart = 0;
            this.seatsTextBox.ShortcutsEnabled = true;
            this.seatsTextBox.Size = new System.Drawing.Size(118, 23);
            this.seatsTextBox.TabIndex = 36;
            this.seatsTextBox.UseSelectable = true;
            this.seatsTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seatsTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.seatsTextBox.TextChanged += new System.EventHandler(this.SeatsTextBox_TextChanged);
            // 
            // powerTextBox
            // 
            // 
            // 
            // 
            this.powerTextBox.CustomButton.Image = null;
            this.powerTextBox.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.powerTextBox.CustomButton.Name = "";
            this.powerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.powerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.powerTextBox.CustomButton.TabIndex = 1;
            this.powerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.powerTextBox.CustomButton.UseSelectable = true;
            this.powerTextBox.CustomButton.Visible = false;
            this.powerTextBox.Lines = new string[0];
            this.powerTextBox.Location = new System.Drawing.Point(144, 75);
            this.powerTextBox.MaxLength = 32767;
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.PasswordChar = '\0';
            this.powerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.powerTextBox.SelectedText = "";
            this.powerTextBox.SelectionLength = 0;
            this.powerTextBox.SelectionStart = 0;
            this.powerTextBox.ShortcutsEnabled = true;
            this.powerTextBox.Size = new System.Drawing.Size(118, 23);
            this.powerTextBox.TabIndex = 35;
            this.powerTextBox.UseSelectable = true;
            this.powerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.powerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.powerTextBox.TextChanged += new System.EventHandler(this.PowerTextBox_TextChanged);
            // 
            // bearbeitenTile
            // 
            this.bearbeitenTile.ActiveControl = null;
            this.bearbeitenTile.Location = new System.Drawing.Point(486, 109);
            this.bearbeitenTile.Name = "bearbeitenTile";
            this.bearbeitenTile.Size = new System.Drawing.Size(84, 38);
            this.bearbeitenTile.TabIndex = 34;
            this.bearbeitenTile.Text = "Bearbeiten";
            this.bearbeitenTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bearbeitenTile.UseSelectable = true;
            this.bearbeitenTile.Click += new System.EventHandler(this.BearbeitenTile_Click);
            // 
            // entfernenTile
            // 
            this.entfernenTile.ActiveControl = null;
            this.entfernenTile.Location = new System.Drawing.Point(486, 65);
            this.entfernenTile.Name = "entfernenTile";
            this.entfernenTile.Size = new System.Drawing.Size(84, 38);
            this.entfernenTile.TabIndex = 33;
            this.entfernenTile.Text = "Entfernen";
            this.entfernenTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.entfernenTile.UseSelectable = true;
            this.entfernenTile.Click += new System.EventHandler(this.EntfernenTile_Click);
            // 
            // hinzufügenTile
            // 
            this.hinzufügenTile.ActiveControl = null;
            this.hinzufügenTile.Location = new System.Drawing.Point(486, 21);
            this.hinzufügenTile.Name = "hinzufügenTile";
            this.hinzufügenTile.Size = new System.Drawing.Size(84, 38);
            this.hinzufügenTile.TabIndex = 32;
            this.hinzufügenTile.Text = "Hinzufügen";
            this.hinzufügenTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hinzufügenTile.UseSelectable = true;
            this.hinzufügenTile.Click += new System.EventHandler(this.HinzufügenTile_Click);
            // 
            // priceTextLabel1
            // 
            this.priceTextLabel1.AutoSize = true;
            this.priceTextLabel1.Location = new System.Drawing.Point(19, 243);
            this.priceTextLabel1.Name = "priceTextLabel1";
            this.priceTextLabel1.Size = new System.Drawing.Size(37, 19);
            this.priceTextLabel1.TabIndex = 31;
            this.priceTextLabel1.Text = "Preis";
            // 
            // gearboxTextLabel1
            // 
            this.gearboxTextLabel1.AutoSize = true;
            this.gearboxTextLabel1.Location = new System.Drawing.Point(19, 137);
            this.gearboxTextLabel1.Name = "gearboxTextLabel1";
            this.gearboxTextLabel1.Size = new System.Drawing.Size(76, 19);
            this.gearboxTextLabel1.TabIndex = 30;
            this.gearboxTextLabel1.Text = "Getriebeart";
            // 
            // fuelTextLabel1
            // 
            this.fuelTextLabel1.AutoSize = true;
            this.fuelTextLabel1.Location = new System.Drawing.Point(19, 166);
            this.fuelTextLabel1.Name = "fuelTextLabel1";
            this.fuelTextLabel1.Size = new System.Drawing.Size(78, 19);
            this.fuelTextLabel1.TabIndex = 29;
            this.fuelTextLabel1.Text = "Kraftstoffart";
            // 
            // statusTextLabel1
            // 
            this.statusTextLabel1.AutoSize = true;
            this.statusTextLabel1.Location = new System.Drawing.Point(19, 214);
            this.statusTextLabel1.Name = "statusTextLabel1";
            this.statusTextLabel1.Size = new System.Drawing.Size(43, 19);
            this.statusTextLabel1.TabIndex = 28;
            this.statusTextLabel1.Text = "Status";
            // 
            // seatsTextLabel1
            // 
            this.seatsTextLabel1.AutoSize = true;
            this.seatsTextLabel1.Location = new System.Drawing.Point(20, 108);
            this.seatsTextLabel1.Name = "seatsTextLabel1";
            this.seatsTextLabel1.Size = new System.Drawing.Size(64, 19);
            this.seatsTextLabel1.TabIndex = 27;
            this.seatsTextLabel1.Text = "Sitzplätze";
            // 
            // powerTextLabel1
            // 
            this.powerTextLabel1.AutoSize = true;
            this.powerTextLabel1.Location = new System.Drawing.Point(19, 79);
            this.powerTextLabel1.Name = "powerTextLabel1";
            this.powerTextLabel1.Size = new System.Drawing.Size(56, 19);
            this.powerTextLabel1.TabIndex = 26;
            this.powerTextLabel1.Text = "Leistung";
            // 
            // brandTextLabel1
            // 
            this.brandTextLabel1.AutoSize = true;
            this.brandTextLabel1.Location = new System.Drawing.Point(19, 50);
            this.brandTextLabel1.Name = "brandTextLabel1";
            this.brandTextLabel1.Size = new System.Drawing.Size(46, 19);
            this.brandTextLabel1.TabIndex = 25;
            this.brandTextLabel1.Text = "Marke";
            // 
            // modelTextLabel1
            // 
            this.modelTextLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.modelTextLabel1.AutoSize = true;
            this.modelTextLabel1.Location = new System.Drawing.Point(19, 21);
            this.modelTextLabel1.Name = "modelTextLabel1";
            this.modelTextLabel1.Size = new System.Drawing.Size(50, 19);
            this.modelTextLabel1.TabIndex = 24;
            this.modelTextLabel1.Text = "Modell";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // ReserveTile
            // 
            this.ReserveTile.ActiveControl = null;
            this.ReserveTile.Location = new System.Drawing.Point(3, 288);
            this.ReserveTile.Name = "ReserveTile";
            this.ReserveTile.Size = new System.Drawing.Size(123, 40);
            this.ReserveTile.TabIndex = 18;
            this.ReserveTile.Text = "Reserve Car";
            this.ReserveTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReserveTile.UseSelectable = true;
            this.ReserveTile.Click += new System.EventHandler(this.ReserveTile_Click);
            // 
            // DriveTile
            // 
            this.DriveTile.ActiveControl = null;
            this.DriveTile.Location = new System.Drawing.Point(259, 288);
            this.DriveTile.Name = "DriveTile";
            this.DriveTile.Size = new System.Drawing.Size(119, 40);
            this.DriveTile.TabIndex = 19;
            this.DriveTile.Text = "Drive Car";
            this.DriveTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DriveTile.UseSelectable = true;
            this.DriveTile.Click += new System.EventHandler(this.DriveTile_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(830, 297);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 20;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 510);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.vehicleTabPage.ResumeLayout(false);
            this.vehicleTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.optionTabPage.ResumeLayout(false);
            this.optionTabPage.PerformLayout();
            this.addVehicleTabPage.ResumeLayout(false);
            this.addVehicleTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage vehicleTabPage;
        private MetroFramework.Controls.MetroTabPage optionTabPage;
        private MetroFramework.Controls.MetroComboBox ordnenComboBox;
        private MetroFramework.Controls.MetroLabel ordnenLabel;
        private MetroFramework.Controls.MetroComboBox farbeComboBox;
        private MetroFramework.Controls.MetroLabel farbeLabel;
        private MetroFramework.Controls.MetroComboBox leitmotivComboBox;
        private MetroFramework.Controls.MetroLabel leitmotivLabel;
        private MetroFramework.Controls.MetroTabPage addVehicleTabPage;
        private MetroFramework.Controls.MetroTile bearbeitenTile;
        private MetroFramework.Controls.MetroTile entfernenTile;
        private MetroFramework.Controls.MetroTile hinzufügenTile;
        private MetroFramework.Controls.MetroLabel priceTextLabel1;
        private MetroFramework.Controls.MetroLabel gearboxTextLabel1;
        private MetroFramework.Controls.MetroLabel fuelTextLabel1;
        private MetroFramework.Controls.MetroLabel statusTextLabel1;
        private MetroFramework.Controls.MetroLabel seatsTextLabel1;
        private MetroFramework.Controls.MetroLabel powerTextLabel1;
        private MetroFramework.Controls.MetroLabel brandTextLabel1;
        private MetroFramework.Controls.MetroLabel modelTextLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox powerTextBox;
        private MetroFramework.Controls.MetroTextBox priceTextBox;
        private MetroFramework.Controls.MetroTextBox statusTextBox;
        private MetroFramework.Controls.MetroTextBox fuelTextBox;
        private MetroFramework.Controls.MetroTextBox gearboxTextBox;
        private MetroFramework.Controls.MetroTextBox modelTextBox;
        private MetroFramework.Controls.MetroTextBox brandTextBox;
        private MetroFramework.Controls.MetroTextBox seatsTextBox;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.DataGridView CarGridView;
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
        private System.Windows.Forms.CheckBox CarCheckBox;
        private MetroFramework.Controls.MetroTile ReserveTile;
        private MetroFramework.Controls.MetroTile DriveTile;
        private System.Windows.Forms.Button Exitbutton;
    }
}