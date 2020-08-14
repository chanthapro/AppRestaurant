using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppResturant
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Object
        private Sale sale { get; set; }
        private Files file { get; set; }
        
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPass.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                
                sale = new Sale();
                file = new Files();
                sale.DataCon();
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtID.Text.Replace("'", "''");
                string pass = txtPass.Text.Replace("'", "''");
                if (sale.getLogin(user, pass))
                {
                    this.Hide();
                    new frmMain(this).ShowDialog();
                    
                }
                else
                {
                    new frmMsg("គណនីមិនត្រឹមត្រូវ").ShowDialog();
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
