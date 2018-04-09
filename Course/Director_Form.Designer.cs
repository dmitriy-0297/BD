namespace Course
{
    partial class Director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Director));
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand = new System.Data.OleDb.OleDbCommand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Customers = new System.Windows.Forms.TabPage();
            this.dgCustomers = new System.Windows.Forms.DataGrid();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.EnterPhoneSuppliers = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.EnterSupplierStatus = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.dgSuppliers = new System.Windows.Forms.DataGrid();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SuplierStatus = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SupplierPhone = new System.Windows.Forms.TextBox();
            this.SuplierFIO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.PassiveSeller = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ActiveSeller = new System.Windows.Forms.TextBox();
            this.StatusSeller = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SalarySeller = new System.Windows.Forms.TextBox();
            this.IDSellerOrPhone = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dgSellers = new System.Windows.Forms.DataGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Status = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lable3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Customers.BackgroundImage")));
            this.Customers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Customers.Controls.Add(this.dgCustomers);
            this.Customers.Location = new System.Drawing.Point(4, 23);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(455, 289);
            this.Customers.TabIndex = 6;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // dgCustomers
            // 
            this.dgCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgCustomers.CaptionVisible = false;
            this.dgCustomers.DataMember = "";
            this.dgCustomers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgCustomers.Location = new System.Drawing.Point(27, 17);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.Size = new System.Drawing.Size(394, 227);
            this.dgCustomers.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.EnterPhoneSuppliers);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.EnterSupplierStatus);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(455, 289);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Editing Suppliers";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(80, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 14);
            this.label13.TabIndex = 4;
            this.label13.Text = "Phone";
            // 
            // EnterPhoneSuppliers
            // 
            this.EnterPhoneSuppliers.Location = new System.Drawing.Point(133, 51);
            this.EnterPhoneSuppliers.Name = "EnterPhoneSuppliers";
            this.EnterPhoneSuppliers.Size = new System.Drawing.Size(121, 20);
            this.EnterPhoneSuppliers.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(179, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Enter Status";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(77, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 14);
            this.label12.TabIndex = 1;
            this.label12.Text = "Status";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // EnterSupplierStatus
            // 
            this.EnterSupplierStatus.FormattingEnabled = true;
            this.EnterSupplierStatus.Items.AddRange(new object[] {
            "Working",
            "On holiday",
            "Dismissed"});
            this.EnterSupplierStatus.Location = new System.Drawing.Point(133, 77);
            this.EnterSupplierStatus.Name = "EnterSupplierStatus";
            this.EnterSupplierStatus.Size = new System.Drawing.Size(121, 22);
            this.EnterSupplierStatus.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.dgSuppliers);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(455, 289);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Suppliers";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(363, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgSuppliers
            // 
            this.dgSuppliers.BackgroundColor = System.Drawing.Color.White;
            this.dgSuppliers.CaptionVisible = false;
            this.dgSuppliers.DataMember = "";
            this.dgSuppliers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSuppliers.Location = new System.Drawing.Point(18, 13);
            this.dgSuppliers.Name = "dgSuppliers";
            this.dgSuppliers.Size = new System.Drawing.Size(420, 218);
            this.dgSuppliers.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage4.Controls.Add(this.SuplierStatus);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.SupplierPhone);
            this.tabPage4.Controls.Add(this.SuplierFIO);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(455, 289);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Supplier";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SuplierStatus
            // 
            this.SuplierStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Working",
            "Dismissed",
            "On holiday"});
            this.SuplierStatus.FormattingEnabled = true;
            this.SuplierStatus.Items.AddRange(new object[] {
            "Working",
            "On holiday",
            "Dismissed"});
            this.SuplierStatus.Location = new System.Drawing.Point(120, 118);
            this.SuplierStatus.Name = "SuplierStatus";
            this.SuplierStatus.Size = new System.Drawing.Size(121, 22);
            this.SuplierStatus.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(204, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(44, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(44, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 14);
            this.label10.TabIndex = 5;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(44, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "FIO";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.Location = new System.Drawing.Point(120, 92);
            this.SupplierPhone.Name = "SupplierPhone";
            this.SupplierPhone.Size = new System.Drawing.Size(121, 20);
            this.SupplierPhone.TabIndex = 2;
            this.SupplierPhone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SuplierFIO
            // 
            this.SuplierFIO.Location = new System.Drawing.Point(120, 66);
            this.SuplierFIO.Name = "SuplierFIO";
            this.SuplierFIO.Size = new System.Drawing.Size(121, 20);
            this.SuplierFIO.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.PassiveSeller);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.ActiveSeller);
            this.tabPage2.Controls.Add(this.StatusSeller);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SalarySeller);
            this.tabPage2.Controls.Add(this.IDSellerOrPhone);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(455, 289);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Editing Seller";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(274, 204);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(78, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 15;
            this.label15.Text = "PassiveSeller";
            // 
            // PassiveSeller
            // 
            this.PassiveSeller.Location = new System.Drawing.Point(151, 208);
            this.PassiveSeller.Name = "PassiveSeller";
            this.PassiveSeller.Size = new System.Drawing.Size(100, 20);
            this.PassiveSeller.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(274, 178);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(85, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 14);
            this.label14.TabIndex = 12;
            this.label14.Text = "ActiveSeller";
            // 
            // ActiveSeller
            // 
            this.ActiveSeller.Location = new System.Drawing.Point(151, 181);
            this.ActiveSeller.Name = "ActiveSeller";
            this.ActiveSeller.Size = new System.Drawing.Size(100, 20);
            this.ActiveSeller.TabIndex = 11;
            // 
            // StatusSeller
            // 
            this.StatusSeller.AutoCompleteCustomSource.AddRange(new string[] {
            "Working",
            "Dismissed",
            "On holiday"});
            this.StatusSeller.FormattingEnabled = true;
            this.StatusSeller.Items.AddRange(new object[] {
            "Working",
            "On holiday",
            "Dismissed"});
            this.StatusSeller.Location = new System.Drawing.Point(151, 59);
            this.StatusSeller.Name = "StatusSeller";
            this.StatusSeller.Size = new System.Drawing.Size(121, 22);
            this.StatusSeller.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(197, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Enter Salary";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(101, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Enter Status";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(81, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enter Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(80, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(73, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eneter Phone";
            // 
            // SalarySeller
            // 
            this.SalarySeller.BackColor = System.Drawing.Color.White;
            this.SalarySeller.Location = new System.Drawing.Point(151, 85);
            this.SalarySeller.Name = "SalarySeller";
            this.SalarySeller.Size = new System.Drawing.Size(121, 20);
            this.SalarySeller.TabIndex = 3;
            // 
            // IDSellerOrPhone
            // 
            this.IDSellerOrPhone.BackColor = System.Drawing.Color.White;
            this.IDSellerOrPhone.ForeColor = System.Drawing.Color.Black;
            this.IDSellerOrPhone.Location = new System.Drawing.Point(151, 33);
            this.IDSellerOrPhone.Name = "IDSellerOrPhone";
            this.IDSellerOrPhone.Size = new System.Drawing.Size(121, 20);
            this.IDSellerOrPhone.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dgSellers);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(455, 289);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Sellers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(359, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgSellers
            // 
            this.dgSellers.BackgroundColor = System.Drawing.Color.White;
            this.dgSellers.CaptionVisible = false;
            this.dgSellers.DataMember = "";
            this.dgSellers.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgSellers.Location = new System.Drawing.Point(20, 28);
            this.dgSellers.Name = "dgSellers";
            this.dgSellers.ParentRowsVisible = false;
            this.dgSellers.Size = new System.Drawing.Size(414, 215);
            this.dgSellers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.Status);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.Lable3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.Phone);
            this.tabPage3.Controls.Add(this.Salary);
            this.tabPage3.Controls.Add(this.FIO);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.ForeColor = System.Drawing.Color.Red;
            this.tabPage3.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(455, 289);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Add Seller";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Working",
            "On holiday",
            "Dismissed"});
            this.Status.Location = new System.Drawing.Point(100, 98);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(121, 22);
            this.Status.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(211, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(44, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(44, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // Lable3
            // 
            this.Lable3.AutoSize = true;
            this.Lable3.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lable3.ForeColor = System.Drawing.Color.Red;
            this.Lable3.Location = new System.Drawing.Point(44, 78);
            this.Lable3.Name = "Lable3";
            this.Lable3.Size = new System.Drawing.Size(37, 14);
            this.Lable3.TabIndex = 7;
            this.Lable3.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "FIO";
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.Location = new System.Drawing.Point(100, 124);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(121, 20);
            this.Phone.TabIndex = 4;
            // 
            // Salary
            // 
            this.Salary.BackColor = System.Drawing.Color.White;
            this.Salary.Location = new System.Drawing.Point(100, 72);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(121, 20);
            this.Salary.TabIndex = 2;
            // 
            // FIO
            // 
            this.FIO.BackColor = System.Drawing.Color.White;
            this.FIO.Location = new System.Drawing.Point(100, 46);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(121, 20);
            this.FIO.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(483, 350);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Director";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Director";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Director_FormClosing);
            this.Load += new System.EventHandler(this.Director_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSellers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private string strConn;
        private System.Data.OleDb.OleDbDataAdapter dAdapter;
        private System.Data.DataSet dSet;
        private System.Data.DataSet dSet1;
        private System.Data.DataSet dSet3;
        private System.Data.DataSet dSet4;
        private System.Data.DataSet dSet2;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Data.OleDb.OleDbCommand oleDbCommand;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGrid dgCustomers;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EnterPhoneSuppliers;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox EnterSupplierStatus;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGrid dgSuppliers;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox SuplierStatus;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SupplierPhone;
        private System.Windows.Forms.TextBox SuplierFIO;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox StatusSeller;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SalarySeller;
        private System.Windows.Forms.TextBox IDSellerOrPhone;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGrid dgSellers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lable3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ActiveSeller;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox PassiveSeller;
    }
}