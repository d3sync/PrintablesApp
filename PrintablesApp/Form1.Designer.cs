namespace PrintablesApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSPP = new System.Windows.Forms.Button();
            this.txtPrintOne = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtAA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.rtbStamp = new System.Windows.Forms.RichTextBox();
            this.btnResetStamp = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStaySafe = new System.Windows.Forms.Button();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printDocument4 = new System.Drawing.Printing.PrintDocument();
            this.printDocument5 = new System.Drawing.Printing.PrintDocument();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.printDocument6 = new System.Drawing.Printing.PrintDocument();
            this.printDocument7 = new System.Drawing.Printing.PrintDocument();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.handle_wcDocument = new System.Drawing.Printing.PrintDocument();
            this.handle_wcupDocument = new System.Drawing.Printing.PrintDocument();
            this.printDocument8 = new System.Drawing.Printing.PrintDocument();
            this.button6 = new System.Windows.Forms.Button();
            this.printDocument9 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSPP);
            this.groupBox1.Controls.Add(this.txtPrintOne);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnPrepare);
            this.groupBox1.Controls.Add(this.txtAD);
            this.groupBox1.Controls.Add(this.txtAA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Misbehavin\'", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(711, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Δέματα";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(102, 76);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(302, 26);
            this.txtPhone.TabIndex = 18;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Τηλέφωνο";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ημερομηνία";
            // 
            // btnSPP
            // 
            this.btnSPP.Font = new System.Drawing.Font("Misbehavin\'", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPP.Location = new System.Drawing.Point(575, 52);
            this.btnSPP.Name = "btnSPP";
            this.btnSPP.Size = new System.Drawing.Size(112, 55);
            this.btnSPP.TabIndex = 12;
            this.btnSPP.Text = "Εκτ. Σελίδας";
            this.btnSPP.UseVisualStyleBackColor = true;
            this.btnSPP.Click += new System.EventHandler(this.btnSPP_Click);
            // 
            // txtPrintOne
            // 
            this.txtPrintOne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrintOne.Location = new System.Drawing.Point(575, 21);
            this.txtPrintOne.Name = "txtPrintOne";
            this.txtPrintOne.Size = new System.Drawing.Size(112, 26);
            this.txtPrintOne.TabIndex = 11;
            this.txtPrintOne.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(437, 81);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 26);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Καθαρισμός";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Misbehavin\'", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(437, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 56);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Πριντ ΙΤ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrepare
            // 
            this.btnPrepare.Font = new System.Drawing.Font("Misbehavin\'", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepare.Location = new System.Drawing.Point(327, 20);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(106, 87);
            this.btnPrepare.TabIndex = 8;
            this.btnPrepare.Text = "Προετοιμασία";
            this.btnPrepare.UseVisualStyleBackColor = true;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(102, 47);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(302, 26);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Διεύθυνση";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Αποστολή από";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(102, 16);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(302, 26);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtAD
            // 
            this.txtAD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAD.Location = new System.Drawing.Point(144, 52);
            this.txtAD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(148, 26);
            this.txtAD.TabIndex = 3;
            // 
            // txtAA
            // 
            this.txtAA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAA.Location = new System.Drawing.Point(144, 21);
            this.txtAA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAA.Name = "txtAA";
            this.txtAA.Size = new System.Drawing.Size(148, 26);
            this.txtAA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Αριθ Δεμάτων";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αρ. Αποστολής";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 566);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1065, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetStamp);
            this.groupBox2.Controls.Add(this.rtbStamp);
            this.groupBox2.Controls.Add(this.btnUnlock);
            this.groupBox2.Controls.Add(this.btnLock);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Location = new System.Drawing.Point(5, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ρυθμίσεις Καταστήματος";
            // 
            // btnLock
            // 
            this.btnLock.Enabled = false;
            this.btnLock.Location = new System.Drawing.Point(975, 15);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(73, 23);
            this.btnLock.TabIndex = 19;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(975, 99);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(73, 23);
            this.btnUnlock.TabIndex = 20;
            this.btnUnlock.Text = "UnLock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // rtbStamp
            // 
            this.rtbStamp.Enabled = false;
            this.rtbStamp.Location = new System.Drawing.Point(422, 16);
            this.rtbStamp.Name = "rtbStamp";
            this.rtbStamp.ReadOnly = true;
            this.rtbStamp.Size = new System.Drawing.Size(531, 96);
            this.rtbStamp.TabIndex = 21;
            this.rtbStamp.Text = "";
            this.rtbStamp.TextChanged += new System.EventHandler(this.rtbStamp_TextChanged);
            // 
            // btnResetStamp
            // 
            this.btnResetStamp.Enabled = false;
            this.btnResetStamp.Location = new System.Drawing.Point(975, 48);
            this.btnResetStamp.Name = "btnResetStamp";
            this.btnResetStamp.Size = new System.Drawing.Size(75, 45);
            this.btnResetStamp.TabIndex = 22;
            this.btnResetStamp.Text = "Reset Stamp";
            this.btnResetStamp.UseVisualStyleBackColor = true;
            this.btnResetStamp.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(212, 17);
            this.toolStripStatusLabel1.Text = "Created by d3sync - http://tools.idle.gr";
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnStaySafe);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(725, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 240);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Covid19";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Proper Use of Mask";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Οδηγίες για Covid 19";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStaySafe
            // 
            this.btnStaySafe.Location = new System.Drawing.Point(6, 93);
            this.btnStaySafe.Name = "btnStaySafe";
            this.btnStaySafe.Size = new System.Drawing.Size(148, 66);
            this.btnStaySafe.TabIndex = 2;
            this.btnStaySafe.Text = "Stay Safe";
            this.btnStaySafe.UseVisualStyleBackColor = true;
            this.btnStaySafe.Click += new System.EventHandler(this.btnStaySafe_Click);
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // printDocument4
            // 
            this.printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument4_PrintPage);
            // 
            // printDocument5
            // 
            this.printDocument5.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument5_PrintPage);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "Μόνο 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "Mandatory Mask";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(176, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "Mandatory Mask 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // printDocument6
            // 
            this.printDocument6.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument6_PrintPage);
            // 
            // printDocument7
            // 
            this.printDocument7.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument7_PrintPage);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Location = new System.Drawing.Point(725, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 95);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fragile";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(176, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 66);
            this.button10.TabIndex = 1;
            this.button10.Text = "Handle w/ Care Side Up";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(148, 66);
            this.button11.TabIndex = 0;
            this.button11.Text = "Handle with care";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // handle_wcDocument
            // 
            this.handle_wcDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.handle_wcDocument_PrintPage);
            // 
            // handle_wcupDocument
            // 
            this.handle_wcupDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.handle_wcupDocument_PrintPage);
            // 
            // printDocument8
            // 
            this.printDocument8.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument8_PrintPage);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "Μόνο 1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printDocument9
            // 
            this.printDocument9.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument9_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 588);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Printable\'s App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSPP;
        private System.Windows.Forms.TextBox txtPrintOne;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtAA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.RichTextBox rtbStamp;
        private System.Windows.Forms.Button btnResetStamp;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStaySafe;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Drawing.Printing.PrintDocument printDocument4;
        private System.Drawing.Printing.PrintDocument printDocument5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument6;
        private System.Drawing.Printing.PrintDocument printDocument7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Drawing.Printing.PrintDocument handle_wcDocument;
        private System.Drawing.Printing.PrintDocument handle_wcupDocument;
        private System.Drawing.Printing.PrintDocument printDocument8;
        private System.Windows.Forms.Button button6;
        private System.Drawing.Printing.PrintDocument printDocument9;
    }
}

