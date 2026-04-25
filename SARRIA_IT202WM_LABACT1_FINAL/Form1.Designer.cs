namespace SARRIA_IT202WM_LABACT1_FINAL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.txtAssignedSlot = new System.Windows.Forms.TextBox();
            this.txtHoursParked = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlParkingStatus = new System.Windows.Forms.GroupBox();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOvertimeVal = new System.Windows.Forms.Label();
            this.lblSlotDisplay = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblVehicleInfo = new System.Windows.Forms.Label();
            this.lblPlateDisplay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblServiceVal = new System.Windows.Forms.Label();
            this.lblStandardVal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.lblChangeVal = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlParkingStatus.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVehicleType);
            this.groupBox1.Controls.Add(this.txtAssignedSlot);
            this.groupBox1.Controls.Add(this.txtHoursParked);
            this.groupBox1.Controls.Add(this.txtPlateNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehicle Registration";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "Car - 50 per hour",
            "Motorcycle - 30 per hour",
            "Van - 70 per hour"});
            this.cmbVehicleType.Location = new System.Drawing.Point(22, 100);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(158, 21);
            this.cmbVehicleType.TabIndex = 8;
            // 
            // txtAssignedSlot
            // 
            this.txtAssignedSlot.Location = new System.Drawing.Point(22, 178);
            this.txtAssignedSlot.Name = "txtAssignedSlot";
            this.txtAssignedSlot.Size = new System.Drawing.Size(158, 20);
            this.txtAssignedSlot.TabIndex = 7;
            // 
            // txtHoursParked
            // 
            this.txtHoursParked.Location = new System.Drawing.Point(22, 139);
            this.txtHoursParked.Name = "txtHoursParked";
            this.txtHoursParked.Size = new System.Drawing.Size(158, 20);
            this.txtHoursParked.TabIndex = 6;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(22, 61);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(158, 20);
            this.txtPlateNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assigned Slot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Parked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(32, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlParkingStatus
            // 
            this.pnlParkingStatus.Controls.Add(this.button36);
            this.pnlParkingStatus.Controls.Add(this.button37);
            this.pnlParkingStatus.Controls.Add(this.button38);
            this.pnlParkingStatus.Controls.Add(this.button39);
            this.pnlParkingStatus.Controls.Add(this.button40);
            this.pnlParkingStatus.Controls.Add(this.button31);
            this.pnlParkingStatus.Controls.Add(this.button32);
            this.pnlParkingStatus.Controls.Add(this.button33);
            this.pnlParkingStatus.Controls.Add(this.button34);
            this.pnlParkingStatus.Controls.Add(this.button35);
            this.pnlParkingStatus.Controls.Add(this.button26);
            this.pnlParkingStatus.Controls.Add(this.button27);
            this.pnlParkingStatus.Controls.Add(this.button28);
            this.pnlParkingStatus.Controls.Add(this.button29);
            this.pnlParkingStatus.Controls.Add(this.button30);
            this.pnlParkingStatus.Controls.Add(this.button21);
            this.pnlParkingStatus.Controls.Add(this.button22);
            this.pnlParkingStatus.Controls.Add(this.button23);
            this.pnlParkingStatus.Controls.Add(this.button24);
            this.pnlParkingStatus.Controls.Add(this.button25);
            this.pnlParkingStatus.Controls.Add(this.button16);
            this.pnlParkingStatus.Controls.Add(this.button17);
            this.pnlParkingStatus.Controls.Add(this.button18);
            this.pnlParkingStatus.Controls.Add(this.button19);
            this.pnlParkingStatus.Controls.Add(this.button20);
            this.pnlParkingStatus.Controls.Add(this.button11);
            this.pnlParkingStatus.Controls.Add(this.button12);
            this.pnlParkingStatus.Controls.Add(this.button13);
            this.pnlParkingStatus.Controls.Add(this.button14);
            this.pnlParkingStatus.Controls.Add(this.button15);
            this.pnlParkingStatus.Controls.Add(this.button10);
            this.pnlParkingStatus.Controls.Add(this.button9);
            this.pnlParkingStatus.Controls.Add(this.button8);
            this.pnlParkingStatus.Controls.Add(this.button7);
            this.pnlParkingStatus.Controls.Add(this.button6);
            this.pnlParkingStatus.Location = new System.Drawing.Point(257, 52);
            this.pnlParkingStatus.Name = "pnlParkingStatus";
            this.pnlParkingStatus.Size = new System.Drawing.Size(347, 484);
            this.pnlParkingStatus.TabIndex = 2;
            this.pnlParkingStatus.TabStop = false;
            this.pnlParkingStatus.Text = "Parking Status";
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.LimeGreen;
            this.button36.ForeColor = System.Drawing.Color.White;
            this.button36.Location = new System.Drawing.Point(277, 379);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(46, 31);
            this.button36.TabIndex = 34;
            this.button36.Text = "G5";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.LimeGreen;
            this.button37.ForeColor = System.Drawing.Color.White;
            this.button37.Location = new System.Drawing.Point(213, 379);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(46, 31);
            this.button37.TabIndex = 33;
            this.button37.Text = "G4";
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.LimeGreen;
            this.button38.ForeColor = System.Drawing.Color.White;
            this.button38.Location = new System.Drawing.Point(149, 379);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(46, 31);
            this.button38.TabIndex = 32;
            this.button38.Text = "G3";
            this.button38.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.LimeGreen;
            this.button39.ForeColor = System.Drawing.Color.White;
            this.button39.Location = new System.Drawing.Point(85, 379);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(46, 31);
            this.button39.TabIndex = 31;
            this.button39.Text = "G2";
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.LimeGreen;
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.Location = new System.Drawing.Point(22, 379);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(46, 31);
            this.button40.TabIndex = 30;
            this.button40.Text = "G1";
            this.button40.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.LimeGreen;
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(277, 330);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(46, 31);
            this.button31.TabIndex = 29;
            this.button31.Text = "F5";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.LimeGreen;
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(213, 330);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(46, 31);
            this.button32.TabIndex = 28;
            this.button32.Text = "F4";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.LimeGreen;
            this.button33.ForeColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(149, 330);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(46, 31);
            this.button33.TabIndex = 27;
            this.button33.Text = "F3";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.LimeGreen;
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(85, 330);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(46, 31);
            this.button34.TabIndex = 26;
            this.button34.Text = "F2";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.LimeGreen;
            this.button35.ForeColor = System.Drawing.Color.White;
            this.button35.Location = new System.Drawing.Point(22, 330);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(46, 31);
            this.button35.TabIndex = 25;
            this.button35.Text = "F1";
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LimeGreen;
            this.button26.ForeColor = System.Drawing.Color.White;
            this.button26.Location = new System.Drawing.Point(277, 278);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(46, 31);
            this.button26.TabIndex = 24;
            this.button26.Text = "E5";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.LimeGreen;
            this.button27.ForeColor = System.Drawing.Color.White;
            this.button27.Location = new System.Drawing.Point(213, 278);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(46, 31);
            this.button27.TabIndex = 23;
            this.button27.Text = "E4";
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.LimeGreen;
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(149, 278);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(46, 31);
            this.button28.TabIndex = 22;
            this.button28.Text = "E3";
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.LimeGreen;
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(85, 278);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(46, 31);
            this.button29.TabIndex = 21;
            this.button29.Text = "E2";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.LimeGreen;
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(22, 278);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(46, 31);
            this.button30.TabIndex = 20;
            this.button30.Text = "E1";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LimeGreen;
            this.button21.ForeColor = System.Drawing.Color.White;
            this.button21.Location = new System.Drawing.Point(277, 228);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(46, 31);
            this.button21.TabIndex = 19;
            this.button21.Text = "D5";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LimeGreen;
            this.button22.ForeColor = System.Drawing.Color.White;
            this.button22.Location = new System.Drawing.Point(213, 228);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(46, 31);
            this.button22.TabIndex = 18;
            this.button22.Text = "D4";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LimeGreen;
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(149, 228);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 31);
            this.button23.TabIndex = 17;
            this.button23.Text = "D3";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LimeGreen;
            this.button24.ForeColor = System.Drawing.Color.White;
            this.button24.Location = new System.Drawing.Point(85, 228);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(46, 31);
            this.button24.TabIndex = 16;
            this.button24.Text = "D2";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.LimeGreen;
            this.button25.ForeColor = System.Drawing.Color.White;
            this.button25.Location = new System.Drawing.Point(22, 228);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(46, 31);
            this.button25.TabIndex = 15;
            this.button25.Text = "D1";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LimeGreen;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(277, 179);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(46, 31);
            this.button16.TabIndex = 14;
            this.button16.Text = "C5";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LimeGreen;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(213, 179);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(46, 31);
            this.button17.TabIndex = 13;
            this.button17.Text = "C4";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LimeGreen;
            this.button18.ForeColor = System.Drawing.Color.White;
            this.button18.Location = new System.Drawing.Point(149, 179);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(46, 31);
            this.button18.TabIndex = 12;
            this.button18.Text = "C3";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LimeGreen;
            this.button19.ForeColor = System.Drawing.Color.White;
            this.button19.Location = new System.Drawing.Point(85, 179);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(46, 31);
            this.button19.TabIndex = 11;
            this.button19.Text = "C2";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LimeGreen;
            this.button20.ForeColor = System.Drawing.Color.White;
            this.button20.Location = new System.Drawing.Point(22, 179);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(46, 31);
            this.button20.TabIndex = 10;
            this.button20.Text = "C1";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LimeGreen;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(277, 130);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 31);
            this.button11.TabIndex = 9;
            this.button11.Text = "B5";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LimeGreen;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(213, 130);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 31);
            this.button12.TabIndex = 8;
            this.button12.Text = "B4";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LimeGreen;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(149, 130);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 31);
            this.button13.TabIndex = 7;
            this.button13.Text = "B3";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LimeGreen;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(85, 130);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(46, 31);
            this.button14.TabIndex = 6;
            this.button14.Text = "B2";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LimeGreen;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(22, 130);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 31);
            this.button15.TabIndex = 5;
            this.button15.Text = "B1";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LimeGreen;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(277, 81);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 31);
            this.button10.TabIndex = 4;
            this.button10.Text = "A5";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LimeGreen;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(213, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 31);
            this.button9.TabIndex = 3;
            this.button9.Text = "A4";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LimeGreen;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(149, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 31);
            this.button8.TabIndex = 2;
            this.button8.Text = "A3";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(85, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 31);
            this.button7.TabIndex = 1;
            this.button7.Text = "A2";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(22, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "A1";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOvertimeVal);
            this.groupBox4.Controls.Add(this.lblSlotDisplay);
            this.groupBox4.Controls.Add(this.lblDuration);
            this.groupBox4.Controls.Add(this.lblVehicleInfo);
            this.groupBox4.Controls.Add(this.lblPlateDisplay);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(627, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 176);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Transaction";
            // 
            // lblOvertimeVal
            // 
            this.lblOvertimeVal.AutoSize = true;
            this.lblOvertimeVal.Location = new System.Drawing.Point(123, 136);
            this.lblOvertimeVal.Name = "lblOvertimeVal";
            this.lblOvertimeVal.Size = new System.Drawing.Size(67, 13);
            this.lblOvertimeVal.TabIndex = 18;
            this.lblOvertimeVal.Text = "__________";
            // 
            // lblSlotDisplay
            // 
            this.lblSlotDisplay.AutoSize = true;
            this.lblSlotDisplay.Location = new System.Drawing.Point(123, 109);
            this.lblSlotDisplay.Name = "lblSlotDisplay";
            this.lblSlotDisplay.Size = new System.Drawing.Size(67, 13);
            this.lblSlotDisplay.TabIndex = 17;
            this.lblSlotDisplay.Text = "__________";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(123, 82);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(67, 13);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "__________";
            // 
            // lblVehicleInfo
            // 
            this.lblVehicleInfo.AutoSize = true;
            this.lblVehicleInfo.Location = new System.Drawing.Point(123, 53);
            this.lblVehicleInfo.Name = "lblVehicleInfo";
            this.lblVehicleInfo.Size = new System.Drawing.Size(67, 13);
            this.lblVehicleInfo.TabIndex = 15;
            this.lblVehicleInfo.Text = "__________";
            // 
            // lblPlateDisplay
            // 
            this.lblPlateDisplay.AutoSize = true;
            this.lblPlateDisplay.Location = new System.Drawing.Point(123, 26);
            this.lblPlateDisplay.Name = "lblPlateDisplay";
            this.lblPlateDisplay.Size = new System.Drawing.Size(67, 13);
            this.lblPlateDisplay.TabIndex = 14;
            this.lblPlateDisplay.Text = "__________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Overtime Fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Slot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vehicle Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plate Number";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTotalVal);
            this.groupBox5.Controls.Add(this.lblServiceVal);
            this.groupBox5.Controls.Add(this.lblStandardVal);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(627, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(220, 130);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fee Calculaton";
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Location = new System.Drawing.Point(123, 92);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(67, 13);
            this.lblTotalVal.TabIndex = 24;
            this.lblTotalVal.Text = "__________";
            // 
            // lblServiceVal
            // 
            this.lblServiceVal.AutoSize = true;
            this.lblServiceVal.Location = new System.Drawing.Point(123, 62);
            this.lblServiceVal.Name = "lblServiceVal";
            this.lblServiceVal.Size = new System.Drawing.Size(67, 13);
            this.lblServiceVal.TabIndex = 23;
            this.lblServiceVal.Text = "__________";
            // 
            // lblStandardVal
            // 
            this.lblStandardVal.AutoSize = true;
            this.lblStandardVal.Location = new System.Drawing.Point(123, 33);
            this.lblStandardVal.Name = "lblStandardVal";
            this.lblStandardVal.Size = new System.Drawing.Size(67, 13);
            this.lblStandardVal.TabIndex = 19;
            this.lblStandardVal.Text = "__________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 102);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Total";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Service Charge";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Standard Fee";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.rtbReceipt);
            this.groupBox6.Controls.Add(this.lblChangeVal);
            this.groupBox6.Controls.Add(this.txtPayAmount);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.cmbDiscount);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Location = new System.Drawing.Point(867, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(245, 483);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Payments and Receipts";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 29);
            this.button5.TabIndex = 28;
            this.button5.Text = "Clear Form";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 29);
            this.button4.TabIndex = 27;
            this.button4.Text = "Generate Receipt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Process Payment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.Location = new System.Drawing.Point(20, 107);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.Size = new System.Drawing.Size(207, 242);
            this.rtbReceipt.TabIndex = 26;
            this.rtbReceipt.Text = "";
            // 
            // lblChangeVal
            // 
            this.lblChangeVal.AutoSize = true;
            this.lblChangeVal.Location = new System.Drawing.Point(104, 80);
            this.lblChangeVal.Name = "lblChangeVal";
            this.lblChangeVal.Size = new System.Drawing.Size(67, 13);
            this.lblChangeVal.TabIndex = 25;
            this.lblChangeVal.Text = "__________";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(107, 49);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(121, 20);
            this.txtPayAmount.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 80);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Change";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Pay Amount";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "Senior Citizen",
            "Employee"});
            this.cmbDiscount.Location = new System.Drawing.Point(107, 20);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(121, 21);
            this.cmbDiscount.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "Discount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 603);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlParkingStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Smart Parking Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnlParkingStatus.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAssignedSlot;
        private System.Windows.Forms.TextBox txtHoursParked;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox pnlParkingStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOvertimeVal;
        private System.Windows.Forms.Label lblSlotDisplay;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblVehicleInfo;
        private System.Windows.Forms.Label lblPlateDisplay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblServiceVal;
        private System.Windows.Forms.Label lblStandardVal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.Label lblChangeVal;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}

