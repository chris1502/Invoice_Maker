namespace Invoice_Writer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtGoodsValue = new System.Windows.Forms.TextBox();
            this.invoiceDetails = new System.Windows.Forms.TextBox();
            this.txtVatRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtInvoiceNumber = new System.Windows.Forms.NumericUpDown();
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber)).BeginInit();
            this.invoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1134, 767);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1134, 709);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "USER INFO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1134, 738);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Αρ. Ταυτ./ID No.";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ΤΙΜΟΛΟΓΙΟ/INVOICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Αρ. Τιμολογιου/Invoice No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(655, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ΔΙΑ ΤΗΝ ΚΑΤΩΘΙ ΤΟΙΣ ΜΕΤΡΗΤΟΙΣ/ΕΠΙ ΠΙΣΤΟΣΕΙ / FOR THE UNDERMENTION GOODS CASH/CRED" +
    "IT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 668);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ημερ./Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Αγοραστής - Παραλήπτης";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 713);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ολικόν-Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(787, 683);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Φ.Π.Α-VAT 5%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(748, 656);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Αξία Εμπ.-Goods Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(708, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Αρ. Εγγρ. Φ.Π.Α/VAT No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Όνομα/Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Διευθυνση/Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(112, 29);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerName.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(871, 710);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(871, 683);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(100, 20);
            this.txtVAT.TabIndex = 14;
            // 
            // txtGoodsValue
            // 
            this.txtGoodsValue.Location = new System.Drawing.Point(871, 653);
            this.txtGoodsValue.Name = "txtGoodsValue";
            this.txtGoodsValue.Size = new System.Drawing.Size(100, 20);
            this.txtGoodsValue.TabIndex = 15;
            // 
            // invoiceDetails
            // 
            this.invoiceDetails.Location = new System.Drawing.Point(301, 210);
            this.invoiceDetails.Multiline = true;
            this.invoiceDetails.Name = "invoiceDetails";
            this.invoiceDetails.Size = new System.Drawing.Size(408, 48);
            this.invoiceDetails.TabIndex = 16;
            this.invoiceDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVatRegistrationNumber
            // 
            this.txtVatRegistrationNumber.Location = new System.Drawing.Point(862, 23);
            this.txtVatRegistrationNumber.Name = "txtVatRegistrationNumber";
            this.txtVatRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.txtVatRegistrationNumber.TabIndex = 18;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(125, 111);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(176, 68);
            this.txtCustomerAddress.TabIndex = 19;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(112, 67);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(110, 20);
            this.txtCustomerID.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 668);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantity,
            this.description,
            this.multy,
            this.amount});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(29, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 368);
            this.dataGridView1.TabIndex = 22;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Location = new System.Drawing.Point(842, 61);
            this.txtInvoiceNumber.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.Size = new System.Drawing.Size(120, 20);
            this.txtInvoiceNumber.TabIndex = 23;
            this.txtInvoiceNumber.ThousandsSeparator = true;
            this.txtInvoiceNumber.ValueChanged += new System.EventHandler(this.txtInvoiceNumber_ValueChanged);
            // 
            // invoicePanel
            // 
            this.invoicePanel.AllowDrop = true;
            this.invoicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicePanel.AutoScroll = true;
            this.invoicePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.invoicePanel.Controls.Add(this.txtInvoiceNumber);
            this.invoicePanel.Controls.Add(this.dataGridView1);
            this.invoicePanel.Controls.Add(this.dateTimePicker1);
            this.invoicePanel.Controls.Add(this.txtCustomerID);
            this.invoicePanel.Controls.Add(this.txtCustomerAddress);
            this.invoicePanel.Controls.Add(this.txtVatRegistrationNumber);
            this.invoicePanel.Controls.Add(this.invoiceDetails);
            this.invoicePanel.Controls.Add(this.txtGoodsValue);
            this.invoicePanel.Controls.Add(this.txtVAT);
            this.invoicePanel.Controls.Add(this.txtTotal);
            this.invoicePanel.Controls.Add(this.txtCustomerName);
            this.invoicePanel.Controls.Add(this.label12);
            this.invoicePanel.Controls.Add(this.label11);
            this.invoicePanel.Controls.Add(this.label10);
            this.invoicePanel.Controls.Add(this.label9);
            this.invoicePanel.Controls.Add(this.label8);
            this.invoicePanel.Controls.Add(this.label7);
            this.invoicePanel.Controls.Add(this.label6);
            this.invoicePanel.Controls.Add(this.label5);
            this.invoicePanel.Controls.Add(this.label4);
            this.invoicePanel.Controls.Add(this.label3);
            this.invoicePanel.Controls.Add(this.label2);
            this.invoicePanel.Controls.Add(this.label1);
            this.invoicePanel.Location = new System.Drawing.Point(12, 12);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(1089, 786);
            this.invoicePanel.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.HeaderText = "Ποσόν/Amount";
            this.amount.Name = "amount";
            this.amount.Width = 85;
            // 
            // multy
            // 
            this.multy.HeaderText = "@";
            this.multy.Name = "multy";
            this.multy.Width = 40;
            // 
            // description
            // 
            this.description.HeaderText = "Περιγραφή - Description";
            this.description.Name = "description";
            this.description.Width = 665;
            // 
            // quantity
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.HeaderText = "Ποσότης/Quantity";
            this.quantity.Name = "quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1302, 815);
            this.Controls.Add(this.invoicePanel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNumber)).EndInit();
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtGoodsValue;
        private System.Windows.Forms.TextBox invoiceDetails;
        private System.Windows.Forms.TextBox txtVatRegistrationNumber;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown txtInvoiceNumber;
        private System.Windows.Forms.Panel invoicePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn multy;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}

