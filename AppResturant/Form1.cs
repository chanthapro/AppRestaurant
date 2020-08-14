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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form THIS { get; set; }
        public frmMain(Form THIS)
        {
            this.THIS = THIS;
            InitializeComponent();
        }
        #region Object
        private AppConfig app = new AppConfig();
        private Files file = new Files();
        private Sale sale = new Sale();
        
        #endregion
        private void setUc(UserControl uc)
        {
            uc.Size = new Size(1366, 700);
            uc.Location = new Point(0, 68);
            this.Controls.Add(uc);
            uc.BringToFront();
        }
        private void tmDateTime_Tick(object sender, EventArgs e)
        {
            try
            {
                txtDate.Text = DateTime.Now.ToString("dd-MM-yyy");
                txtTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                app.DataCon();
                tmDateTime.Start();
          
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                UcSale = new UcSale();
                setUc(UcSale);
               
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            try
            {
                UcFood = new UcFood();
                setUc(UcFood);
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                UcReport = new UcReport();
                setUc(UcReport);
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemain_Click(object sender, EventArgs e)
        {
            try
            {
                UcRemain = new UcRemain();
                setUc(UcRemain);
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {

                THIS = new frmLogin();                
                this.Dispose();
                THIS.ShowDialog();
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
    }
}
