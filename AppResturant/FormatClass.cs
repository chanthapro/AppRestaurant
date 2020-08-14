using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppResturant
{
    class FormatClass
    {
        public void Clear(Control c)
        {
            foreach(Control temp in c.Controls){
                if (temp is TextBox)
                {
                    if (temp.TabIndex != 1)
                        ((TextBox)temp).Clear();
                }
                else if (temp is ComboBox)
                    ((ComboBox)temp).SelectedIndex = -1;
                else if (temp is RichTextBox)
                    ((RichTextBox)temp).Clear();
                else if (temp is DataGridView)
                    ((DataGridView)temp).ClearSelection();
            }
        }
        public void setWidthdgv(DataGridView dgv,int fill)
        {
            int width = dgv.Width / dgv.ColumnCount;
            for(int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = width;
            }
            dgv.Columns[fill].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void setHeader(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void setCurrencydgv(DataGridView dgv,params int[] index)
        {
           for(int i = 0; i < index.Length; i++)
            {
                dgv.Columns[index[i]].DefaultCellStyle.Format = String.Format("#,##0");
            }
        }
        public double getTotal(DataGridView dgv,int index)
        {
            double total = 0;
            for(int i = 0; i < dgv.RowCount; i++)
            {
                total += double.Parse(dgv.Rows[i].Cells[index].Value + "");
            }
            return total;
        }
        public void setVisibledgv(DataGridView dgv,params int[] index)
        {
            for(int i = 0; i < index.Length; i++)
            {
                dgv.Columns[index[i]].Visible = false;
            }
        }
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        public void disableCusor(TextBox txt)
        {
            txt.GotFocus += (s1, e1) => { HideCaret(txt.Handle); };
            txt.Cursor = Cursors.Arrow;
        }
        public void disableCusor(ComboBox txt)
        {
            txt.GotFocus += (s1, e1) => { HideCaret(txt.Handle); };
            txt.Cursor = Cursors.Arrow;
        }
        public void checkpoint(KeyPressEventArgs e, TextBox txt)
        {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.')
                {
                    
                    string point = e.KeyChar.ToString();
                    if (e.KeyChar.ToString().Equals(point))
                    {
                        if (txt.Text.IndexOf('.') < 0 && txt.Text.Length > 0)
                            e.Handled = false;
                        else
                            e.Handled = true;
                    }
                }
               
        }
        public void CheckQty(KeyPressEventArgs e, TextBox txt)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar.Equals('0'))
                {
                    if (txt.Text.Length <= 0)
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
        }
        public void CheckQty(KeyPressEventArgs e, ComboBox txt)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar.Equals('0'))
            {
                if (txt.Text.Length <= 0)
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }
    }
}
