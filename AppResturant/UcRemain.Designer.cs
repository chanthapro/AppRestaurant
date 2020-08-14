namespace AppResturant
{
    partial class UcRemain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRemain));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv = new MetroFramework.Controls.MetroGrid();
            this.plContain = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbTable = new MaterialSkin.Controls.MaterialRadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rbDelivery = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtTableNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbfid = new System.Windows.Forms.ComboBox();
            this.cbfname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.RichTextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.btnDeletePay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.plContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(168, 276);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 31);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "ស្វែងរកលេខវិក័យបត្រ៖";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(5, 316);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1357, 323);
            this.dgv.TabIndex = 27;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // plContain
            // 
            this.plContain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.plContain.Controls.Add(this.btnDeletePay);
            this.plContain.Controls.Add(this.btnPay);
            this.plContain.Controls.Add(this.btnClear);
            this.plContain.Controls.Add(this.label6);
            this.plContain.Controls.Add(this.btnPrint);
            this.plContain.Controls.Add(this.txtOID);
            this.plContain.Controls.Add(this.btnDelete);
            this.plContain.Controls.Add(this.btnUpdate);
            this.plContain.Controls.Add(this.label10);
            this.plContain.Controls.Add(this.btnAdd);
            this.plContain.Controls.Add(this.rbTable);
            this.plContain.Controls.Add(this.label9);
            this.plContain.Controls.Add(this.rbDelivery);
            this.plContain.Controls.Add(this.txtTableNum);
            this.plContain.Controls.Add(this.label8);
            this.plContain.Controls.Add(this.label1);
            this.plContain.Controls.Add(this.label4);
            this.plContain.Controls.Add(this.label2);
            this.plContain.Controls.Add(this.label3);
            this.plContain.Controls.Add(this.txtQty);
            this.plContain.Controls.Add(this.txtPrice);
            this.plContain.Controls.Add(this.cbfid);
            this.plContain.Controls.Add(this.cbfname);
            this.plContain.Controls.Add(this.label5);
            this.plContain.Controls.Add(this.txtDes);
            this.plContain.Location = new System.Drawing.Point(2, 14);
            this.plContain.Name = "plContain";
            this.plContain.Size = new System.Drawing.Size(1360, 256);
            this.plContain.TabIndex = 26;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(564, 192);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(140, 52);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "បង់ប្រាក់";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(882, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 52);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "បន្ថែមថ្មី";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "លេខវិក័យបត្រ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Fuchsia;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(723, 192);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 52);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "ព្រីន";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtOID
            // 
            this.txtOID.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOID.Location = new System.Drawing.Point(124, 12);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(317, 37);
            this.txtOID.TabIndex = 1;
            this.txtOID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOID_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(882, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 52);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "លុប";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(723, 113);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 52);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "កែប្រែ";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "លេខតុ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(564, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "រក្សាទុក";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbTable
            // 
            this.rbTable.AutoSize = true;
            this.rbTable.Depth = 0;
            this.rbTable.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTable.Location = new System.Drawing.Point(204, 61);
            this.rbTable.Margin = new System.Windows.Forms.Padding(0);
            this.rbTable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTable.Name = "rbTable";
            this.rbTable.Ripple = true;
            this.rbTable.Size = new System.Drawing.Size(25, 30);
            this.rbTable.TabIndex = 21;
            this.rbTable.TabStop = true;
            this.rbTable.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(152, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "ខ្ចប់";
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Depth = 0;
            this.rbDelivery.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDelivery.Location = new System.Drawing.Point(124, 61);
            this.rbDelivery.Margin = new System.Windows.Forms.Padding(0);
            this.rbDelivery.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDelivery.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Ripple = true;
            this.rbDelivery.Size = new System.Drawing.Size(25, 30);
            this.rbDelivery.TabIndex = 19;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.UseVisualStyleBackColor = true;
            // 
            // txtTableNum
            // 
            this.txtTableNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTableNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableNum.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableNum.ForeColor = System.Drawing.Color.White;
            this.txtTableNum.Location = new System.Drawing.Point(294, 61);
            this.txtTableNum.Name = "txtTableNum";
            this.txtTableNum.Size = new System.Drawing.Size(147, 30);
            this.txtTableNum.TabIndex = 18;
            this.txtTableNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "អតថិជន";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "លេខកូតម្ហូប";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(901, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "តម្លៃ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "ឈ្មោះម្ហូប";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(901, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "ចំនួន";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(1008, 12);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(317, 37);
            this.txtQty.TabIndex = 12;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1008, 58);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(317, 37);
            this.txtPrice.TabIndex = 13;
            // 
            // cbfid
            // 
            this.cbfid.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfid.FormattingEnabled = true;
            this.cbfid.Location = new System.Drawing.Point(565, 9);
            this.cbfid.Name = "cbfid";
            this.cbfid.Size = new System.Drawing.Size(317, 37);
            this.cbfid.TabIndex = 14;
            this.cbfid.SelectedIndexChanged += new System.EventHandler(this.cbfid_SelectedIndexChanged);
            this.cbfid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbfid_KeyPress);
            // 
            // cbfname
            // 
            this.cbfname.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfname.FormattingEnabled = true;
            this.cbfname.Location = new System.Drawing.Point(565, 58);
            this.cbfname.Name = "cbfname";
            this.cbfname.Size = new System.Drawing.Size(317, 37);
            this.cbfname.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "សំគាល់";
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(124, 113);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(317, 108);
            this.txtDes.TabIndex = 16;
            this.txtDes.Text = "";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1124, 645);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(238, 37);
            this.txtTotal.TabIndex = 31;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1019, 648);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "ទឹកប្រាក់សរុប";
            // 
            // cbPayment
            // 
            this.cbPayment.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Items.AddRange(new object[] {
            "មិនទាន់បង់ប្រាក់",
            "បង់ប្រាក់រួច"});
            this.cbPayment.Location = new System.Drawing.Point(1109, 275);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(253, 32);
            this.cbPayment.TabIndex = 25;
            this.cbPayment.SelectedIndexChanged += new System.EventHandler(this.cbPayment_SelectedIndexChanged);
            this.cbPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOID_KeyPress);
            // 
            // btnDeletePay
            // 
            this.btnDeletePay.BackColor = System.Drawing.Color.Red;
            this.btnDeletePay.FlatAppearance.BorderSize = 0;
            this.btnDeletePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePay.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePay.ForeColor = System.Drawing.Color.White;
            this.btnDeletePay.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePay.Image")));
            this.btnDeletePay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePay.Location = new System.Drawing.Point(1167, 192);
            this.btnDeletePay.Name = "btnDeletePay";
            this.btnDeletePay.Size = new System.Drawing.Size(177, 52);
            this.btnDeletePay.TabIndex = 25;
            this.btnDeletePay.Text = "មិនទាន់បង់ប្រាក់";
            this.btnDeletePay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePay.UseVisualStyleBackColor = false;
            this.btnDeletePay.Click += new System.EventHandler(this.btnDeletePay_Click);
            // 
            // UcRemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.plContain);
            this.Name = "UcRemain";
            this.Size = new System.Drawing.Size(1366, 700);
            this.Load += new System.EventHandler(this.UcRemain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.plContain.ResumeLayout(false);
            this.plContain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroGrid dgv;
        private System.Windows.Forms.Panel plContain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialRadioButton rbTable;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialRadioButton rbDelivery;
        private System.Windows.Forms.TextBox txtTableNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbfid;
        private System.Windows.Forms.ComboBox cbfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtDes;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Button btnDeletePay;
    }
}
