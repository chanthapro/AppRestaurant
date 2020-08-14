using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppResturant
{
    public partial class UcReport : UserControl
    {
        public UcReport()
        {
            InitializeComponent();
        }
        #region Method
        public void setUc(UserControl uc)
        {
            uc.Size = new Size(1366,700);
            uc.Location = new Point(0,0);
            this.Controls.Add(uc);
            uc.BringToFront();
        }
        #endregion
        #region Object
        private Files file { get; set; }
        #endregion
        private void UcReport_Load(object sender, EventArgs e)
        {
            try
            {
                file = new Files();
                plExpense.Visible = false;
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            try
            {
                plExpense.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                UcSaleRep = new UcSaleRep();
                setUc(UcSaleRep);
                plExpense.Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddNewExp_Click(object sender, EventArgs e)
        {
            try
            {
                UcImport = new UcImport();
                setUc(UcImport);
                plExpense.Visible = false;
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}
