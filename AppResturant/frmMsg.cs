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
    public partial class frmMsg : MetroFramework.Forms.MetroForm
    {
        public frmMsg()
        {
            InitializeComponent();
        }
        public frmMsg(string text)
        {
            InitializeComponent();
            txt.Text = text;
        }
        FormatClass fmt = new FormatClass();
        private void frmMsg_Load(object sender, EventArgs e)
        {
            try
            {
                fmt.disableCusor(txt);
                btnOk.Focus();
                txt.SelectionStart = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.No;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
