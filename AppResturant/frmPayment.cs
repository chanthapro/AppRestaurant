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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        public frmPayment(int pay)
        {
            this.pay = pay;
            InitializeComponent();
        }
        #region Object
        private Files file { get; set; }
        private InforClass inf { get; set; }
        private FormatClass fmt { get; set; }
        #endregion
        #region Properties
        private int exreate { get { return 4000; } }
        private int Rmoney { get; set; }
        private double Dmoney { get; set; }
        private int refund { get; set; }
        private int change { get; set; }
        private int total { get { return 124000; } }
        public static double ReturnD { get; set; }
        private double ReturnR { get; set; }
        private int pay { get; set; }
        #endregion
        private void frmPayment_Load(object sender, EventArgs e)
        {
            try
            {
                file = new Files();
                fmt = new FormatClass();
                fmt.disableCusor(txtReturnD);
                fmt.disableCusor(txtReturnR);
                lblTotal.Text = pay.ToString("#,##0") + " រៀល";
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.No;
                this.Dispose();
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgetR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                if (txt.Text.Trim().Length <= 0)
                    return;
                Rmoney = int.Parse(txtgetR.Text);
                Dmoney = double.Parse(txtgetD.Text);
                change = int.Parse((Dmoney * exreate) + "");
                refund = (Rmoney + change) - pay;
                ReturnD = (double)refund / exreate;
                if (refund >= 0)
                {
                    btnOk.BackColor = Color.Green;
                    btnOk.Text = "បង់ប្រាក់";
                    txtReturnD.Text = String.Format("{0:C}", ReturnD);
                    txtReturnR.Text = refund.ToString("#,##0") + " រៀល";
                }
                else
                {
                    btnOk.BackColor = Color.Red;
                    btnOk.Text = "មិនគ្រប់ចំនួន";
                    txtReturnR.Text = 0.ToString("#,##0") + " រៀល";
                    txtReturnD.Text = String.Format("{0:C}", 0);
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgetR_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.CheckQty(e,txt:sender as TextBox);
                if (e.KeyChar == 13)
                {
                    if (btnOk.BackColor == Color.Green)
                    {
                        btnOk_Click(sender, e);
                    }
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtReturnR_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = true;
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgetD_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                if (txt.Text.Trim().Equals(""))
                    txt.Text = "0";
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgetD_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.checkpoint(e, txtgetD);
                if (btnOk.BackColor == Color.Green)
                {
                    btnOk_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOk.BackColor == Color.Green)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void txtgetR_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = sender as TextBox;
                if (txt.Text.Trim().Equals("") || txt.Text.Trim().Equals("0"))
                    txt.Clear();
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
    }
}
