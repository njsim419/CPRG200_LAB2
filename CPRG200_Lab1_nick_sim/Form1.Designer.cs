namespace CPRG200_Lab1_nick_sim
{
    partial class Form1
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
            this.button_clear = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.customertypebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalCostBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kwhused = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kwhcostbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kwhIncludedBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.baseRateBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.peakKwhRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.peakKwhIncluded = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.peakBaseRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.peakKwhUsed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nonPeakTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.peakTotal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.totalCostIndustrial = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nonpeakKwhRate = new System.Windows.Forms.TextBox();
            this.nonpeakKwhUsed = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nonpeakBaseRate = new System.Windows.Forms.TextBox();
            this.nonpeakKwhIncluded = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Account_No = new System.Windows.Forms.TextBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.CustomerTotal = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(478, 41);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(111, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(624, 431);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(84, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // customertypebox
            // 
            this.customertypebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customertypebox.FormattingEnabled = true;
            this.customertypebox.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.customertypebox.Location = new System.Drawing.Point(568, 135);
            this.customertypebox.Name = "customertypebox";
            this.customertypebox.Size = new System.Drawing.Size(138, 21);
            this.customertypebox.TabIndex = 3;
            this.customertypebox.SelectedIndexChanged += new System.EventHandler(this.customertypebox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "City Power Billing";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalCostBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kwhused);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.kwhcostbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.kwhIncludedBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.baseRateBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // totalCostBox
            // 
            this.totalCostBox.Location = new System.Drawing.Point(541, 42);
            this.totalCostBox.Name = "totalCostBox";
            this.totalCostBox.ReadOnly = true;
            this.totalCostBox.Size = new System.Drawing.Size(129, 20);
            this.totalCostBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Cost:";
            // 
            // kwhused
            // 
            this.kwhused.Location = new System.Drawing.Point(97, 14);
            this.kwhused.Name = "kwhused";
            this.kwhused.Size = new System.Drawing.Size(100, 20);
            this.kwhused.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total kWH Used:";
            // 
            // kwhcostbox
            // 
            this.kwhcostbox.Location = new System.Drawing.Point(589, 13);
            this.kwhcostbox.Name = "kwhcostbox";
            this.kwhcostbox.ReadOnly = true;
            this.kwhcostbox.Size = new System.Drawing.Size(81, 20);
            this.kwhcostbox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "kWh Cost:";
            // 
            // kwhIncludedBox
            // 
            this.kwhIncludedBox.Location = new System.Drawing.Point(439, 13);
            this.kwhIncludedBox.Name = "kwhIncludedBox";
            this.kwhIncludedBox.ReadOnly = true;
            this.kwhIncludedBox.Size = new System.Drawing.Size(81, 20);
            this.kwhIncludedBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "kWh Included:";
            // 
            // baseRateBox
            // 
            this.baseRateBox.Location = new System.Drawing.Point(269, 14);
            this.baseRateBox.Name = "baseRateBox";
            this.baseRateBox.ReadOnly = true;
            this.baseRateBox.Size = new System.Drawing.Size(81, 20);
            this.baseRateBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Base Rate:";
            // 
            // peakKwhRate
            // 
            this.peakKwhRate.Location = new System.Drawing.Point(441, 13);
            this.peakKwhRate.Name = "peakKwhRate";
            this.peakKwhRate.ReadOnly = true;
            this.peakKwhRate.Size = new System.Drawing.Size(79, 20);
            this.peakKwhRate.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "kWh Cost:";
            // 
            // peakKwhIncluded
            // 
            this.peakKwhIncluded.Location = new System.Drawing.Point(441, 39);
            this.peakKwhIncluded.Name = "peakKwhIncluded";
            this.peakKwhIncluded.ReadOnly = true;
            this.peakKwhIncluded.Size = new System.Drawing.Size(79, 20);
            this.peakKwhIncluded.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "kWh Included:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // peakBaseRate
            // 
            this.peakBaseRate.Location = new System.Drawing.Point(269, 39);
            this.peakBaseRate.Name = "peakBaseRate";
            this.peakBaseRate.ReadOnly = true;
            this.peakBaseRate.Size = new System.Drawing.Size(81, 20);
            this.peakBaseRate.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Base Rate:";
            // 
            // peakKwhUsed
            // 
            this.peakKwhUsed.Location = new System.Drawing.Point(97, 39);
            this.peakKwhUsed.Name = "peakKwhUsed";
            this.peakKwhUsed.Size = new System.Drawing.Size(100, 20);
            this.peakKwhUsed.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total kWh Used:";
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(595, 41);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(111, 23);
            this.button_calculate.TabIndex = 0;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nonPeakTotal);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.peakTotal);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.totalCostIndustrial);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nonpeakKwhRate);
            this.groupBox2.Controls.Add(this.nonpeakKwhUsed);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.nonpeakBaseRate);
            this.groupBox2.Controls.Add(this.nonpeakKwhIncluded);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.peakKwhRate);
            this.groupBox2.Controls.Add(this.peakKwhUsed);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.peakBaseRate);
            this.groupBox2.Controls.Add(this.peakKwhIncluded);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(11, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 178);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // nonPeakTotal
            // 
            this.nonPeakTotal.Location = new System.Drawing.Point(569, 99);
            this.nonPeakTotal.Name = "nonPeakTotal";
            this.nonPeakTotal.ReadOnly = true;
            this.nonPeakTotal.Size = new System.Drawing.Size(100, 20);
            this.nonPeakTotal.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(529, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Total:";
            // 
            // peakTotal
            // 
            this.peakTotal.Location = new System.Drawing.Point(570, 38);
            this.peakTotal.Name = "peakTotal";
            this.peakTotal.ReadOnly = true;
            this.peakTotal.Size = new System.Drawing.Size(100, 20);
            this.peakTotal.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(526, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Total Cost:";
            // 
            // totalCostIndustrial
            // 
            this.totalCostIndustrial.Location = new System.Drawing.Point(541, 141);
            this.totalCostIndustrial.Name = "totalCostIndustrial";
            this.totalCostIndustrial.ReadOnly = true;
            this.totalCostIndustrial.Size = new System.Drawing.Size(129, 20);
            this.totalCostIndustrial.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Total kWh Used:";
            // 
            // nonpeakKwhRate
            // 
            this.nonpeakKwhRate.Location = new System.Drawing.Point(441, 73);
            this.nonpeakKwhRate.Name = "nonpeakKwhRate";
            this.nonpeakKwhRate.ReadOnly = true;
            this.nonpeakKwhRate.Size = new System.Drawing.Size(79, 20);
            this.nonpeakKwhRate.TabIndex = 18;
            // 
            // nonpeakKwhUsed
            // 
            this.nonpeakKwhUsed.Location = new System.Drawing.Point(97, 99);
            this.nonpeakKwhUsed.Name = "nonpeakKwhUsed";
            this.nonpeakKwhUsed.Size = new System.Drawing.Size(100, 20);
            this.nonpeakKwhUsed.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(376, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "kWh Cost:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Base Rate:";
            // 
            // nonpeakBaseRate
            // 
            this.nonpeakBaseRate.Location = new System.Drawing.Point(269, 99);
            this.nonpeakBaseRate.Name = "nonpeakBaseRate";
            this.nonpeakBaseRate.ReadOnly = true;
            this.nonpeakBaseRate.Size = new System.Drawing.Size(81, 20);
            this.nonpeakBaseRate.TabIndex = 14;
            // 
            // nonpeakKwhIncluded
            // 
            this.nonpeakKwhIncluded.Location = new System.Drawing.Point(441, 99);
            this.nonpeakKwhIncluded.Name = "nonpeakKwhIncluded";
            this.nonpeakKwhIncluded.ReadOnly = true;
            this.nonpeakKwhIncluded.Size = new System.Drawing.Size(79, 20);
            this.nonpeakKwhIncluded.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(356, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "kWh Included:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Non Peak Hours:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Peak Hours:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addCustomer);
            this.groupBox3.Controls.Add(this.textName);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.Account_No);
            this.groupBox3.Location = new System.Drawing.Point(11, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 61);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(142, 135);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(101, 23);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.Text = "Search Customer";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(474, 19);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(101, 23);
            this.addCustomer.TabIndex = 4;
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(350, 20);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(118, 20);
            this.textName.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(263, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Account Name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Account Number:";
            // 
            // Account_No
            // 
            this.Account_No.Location = new System.Drawing.Point(105, 22);
            this.Account_No.Name = "Account_No";
            this.Account_No.Size = new System.Drawing.Size(114, 20);
            this.Account_No.TabIndex = 0;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(327, 41);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(147, 23);
            this.Btn_Generate.TabIndex = 10;
            this.Btn_Generate.Text = "Generate Account Number";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // CustomerTotal
            // 
            this.CustomerTotal.AutoSize = true;
            this.CustomerTotal.Location = new System.Drawing.Point(12, 431);
            this.CustomerTotal.Name = "CustomerTotal";
            this.CustomerTotal.Size = new System.Drawing.Size(59, 13);
            this.CustomerTotal.TabIndex = 12;
            this.CustomerTotal.Text = "Customers:";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(139, 431);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(58, 13);
            this.TotalCost.TabIndex = 13;
            this.TotalCost.Text = "Total Cost:";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(15, 135);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(121, 21);
            this.customerBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.CustomerTotal);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customertypebox);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ComboBox customertypebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kwhcostbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kwhIncludedBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baseRateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kwhused;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalCostBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.TextBox peakKwhRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox peakKwhIncluded;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox peakBaseRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox peakKwhUsed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox totalCostIndustrial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox nonpeakKwhRate;
        private System.Windows.Forms.TextBox nonpeakKwhUsed;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox nonpeakBaseRate;
        private System.Windows.Forms.TextBox nonpeakKwhIncluded;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox nonPeakTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox peakTotal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Account_No;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Label CustomerTotal;
        private System.Windows.Forms.Label TotalCost;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox customerBox;
    }
}

