namespace AppResturant
{
    partial class UcReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.plExpense = new System.Windows.Forms.Panel();
            this.btnOldView = new System.Windows.Forms.Button();
            this.btnAddNewExp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.plExpense.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExpense);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Location = new System.Drawing.Point(21, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 127);
            this.panel1.TabIndex = 0;
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.Location = new System.Drawing.Point(0, 61);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(212, 66);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.Text = "របាយការណ៍ចំណាយ";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(0, 0);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(212, 64);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "របាយការណ៍ចំណូល";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // plExpense
            // 
            this.plExpense.Controls.Add(this.btnOldView);
            this.plExpense.Controls.Add(this.btnAddNewExp);
            this.plExpense.Location = new System.Drawing.Point(234, 121);
            this.plExpense.Name = "plExpense";
            this.plExpense.Size = new System.Drawing.Size(212, 127);
            this.plExpense.TabIndex = 3;
            this.plExpense.Visible = false;
            // 
            // btnOldView
            // 
            this.btnOldView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOldView.FlatAppearance.BorderSize = 0;
            this.btnOldView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOldView.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldView.Location = new System.Drawing.Point(0, 61);
            this.btnOldView.Name = "btnOldView";
            this.btnOldView.Size = new System.Drawing.Size(212, 66);
            this.btnOldView.TabIndex = 2;
            this.btnOldView.Text = "របាយការណ៍ចាស់";
            this.btnOldView.UseVisualStyleBackColor = false;
            // 
            // btnAddNewExp
            // 
            this.btnAddNewExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddNewExp.FlatAppearance.BorderSize = 0;
            this.btnAddNewExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewExp.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewExp.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewExp.Name = "btnAddNewExp";
            this.btnAddNewExp.Size = new System.Drawing.Size(212, 64);
            this.btnAddNewExp.TabIndex = 1;
            this.btnAddNewExp.Text = "បញ្ចូលថ្មី";
            this.btnAddNewExp.UseVisualStyleBackColor = false;
            this.btnAddNewExp.Click += new System.EventHandler(this.btnAddNewExp_Click);
            // 
            // UcReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plExpense);
            this.Controls.Add(this.panel1);
            this.Name = "UcReport";
            this.Size = new System.Drawing.Size(1366, 700);
            this.Load += new System.EventHandler(this.UcReport_Load);
            this.panel1.ResumeLayout(false);
            this.plExpense.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Panel plExpense;
        private System.Windows.Forms.Button btnOldView;
        private System.Windows.Forms.Button btnAddNewExp;
        private UcSaleRep UcSaleRep;
        private UcImport UcImport;
    }
}
