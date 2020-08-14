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
    public partial class UcImport : UserControl
    {
        public UcImport()
        {
            InitializeComponent();
        }
        #region Object
        private ImportDetail imp { get; set; }
        private Files file { get; set; }
        private FormatClass fmt { get; set; }
        private InforClass inf { get; set; }

        #endregion
        #region Method
        private void setData()
        {
            if (!checkData())
                return;
            imp.fid = int.Parse(cbfid.SelectedItem + "");
            imp.fnamekh = cbfname.SelectedItem + "";
            imp.qty = int.Parse(txtQty.Text);
            imp.price = double.Parse(txtPrice.Text);                      
        }
        private void addData()
        {
            setData();
            if (dgv.RowCount > 0)
            {
                foreach(DataGridViewRow temp in dgv.Rows)
                {
                    if (imp.fid.Equals(int.Parse(temp.Cells[0].Value + "")))
                    {
                        int oldqty = int.Parse(temp.Cells[2].Value + "");
                        temp.Cells[3].Value = oldqty + imp.qty;
                        temp.Cells[2].Value = imp.price;
                        temp.Cells[4].Value = (oldqty + imp.qty) * imp.price;
                        fmt.Clear(plContain);
                        return;
                    }
                }
            }
            object[] row = { imp.fid, imp.fnamekh, imp.qty, imp.qty,imp.amount };
            dgv.Rows.Add(row);
            fmt.Clear(plContain);
            updatetotal();
           
        }
        private bool checkData()
        {
            if (cbfid.SelectedIndex < 0 || cbfname.SelectedIndex < 0 ||
                txtQty.Text.Trim().Equals("") || txtPrice.Text.Trim().Equals(""))
            {
                new frmMsg(inf.ErrorSetData).ShowDialog();
                return false;
            }
            return true;
        }
        private void updatetotal()
        {
            txtTotal.Text = fmt.getTotal(dgv, 4).ToString("#,##0") + " រៀល";
            txtCountFood.Text = dgv.RowCount+"";
        }
        private void print()
        {
            if (dgv.RowCount > 0)
            {
                List<ImportDetail> arr = new List<ImportDetail>();
                foreach(DataGridViewRow temp in dgv.Rows)
                {
                    ImportDetail item = new ImportDetail();
                    item.fnamekh = temp.Cells[1].Value + "";
                    item.dQty = double.Parse(temp.Cells[3].Value + "");
                    item.price = double.Parse(temp.Cells[2].Value + "");
                    arr.Add(item);
                    
                }
            }
        }
        #endregion 
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UcImport_Load(object sender, EventArgs e)
        {
            try
            {
                imp = new ImportDetail();
                fmt = new FormatClass();
                file = new Files();
                inf = new InforClass();
                imp.getItemCombox(cbfid, imp.queryfid);
                imp.getItemCombox(cbfname, imp.queryfname);
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addData();
                cbfid.Focus();
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        #region Combobox Event
        private void cbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbfname.SelectedIndex = cbfid.SelectedIndex;

            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        private void cbfname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbfid.SelectedIndex = cbfname.SelectedIndex;

            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        #endregion

        private void cbfid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.CheckQty(e,cbfid);
                if (e.KeyChar == 13)
                {
                    cbfid.SelectedItem = cbfid.Text;
                    txtQty.Focus();
                }

            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.checkpoint(e, txtQty);
                if (e.KeyChar == 13)
                {
                    txtPrice.Focus();
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.checkpoint(e, txtPrice);
                if (e.KeyChar == 13)
                {
                    btnAdd_Click(sender, e);

                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    cbfid.SelectedItem = dgv.Rows[index].Cells[0].Value + "";
                    txtQty.Text = dgv.Rows[index].Cells[3].Value + "";
                    txtPrice.Text = dgv.Rows[index].Cells[2].Value + "";
                    setData();
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    setData();
                    dgv.Rows[index].Cells[0].Value = imp.fid;
                    dgv.Rows[index].Cells[1].Value = imp.fnamekh;
                    dgv.Rows[index].Cells[2].Value = imp.price;
                    dgv.Rows[index].Cells[3].Value = imp.qty;
                    dgv.Rows[index].Cells[4].Value = imp.amount;
                    fmt.Clear(plContain);
                    updatetotal();
                    btnClear_Click(sender, e);
                }

            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);
                    updatetotal();
                    btnClear_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fmt.Clear(plContain);
            dgv.ClearSelection();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    imp.start();
                    //insert
                    imp.insertImport();
                    //insert detail
                    foreach(DataGridViewRow temp in dgv.Rows)
                    {
                        imp.fid = int.Parse(temp.Cells[0].Value + "");
                        imp.price = int.Parse(temp.Cells[2].Value + "");
                        imp.dQty = double.Parse(temp.Cells[3].Value + "");
                        imp.insertImportDetail();
                    }                   
                    imp.commit();
                }
            }
            catch(Exception ex)
            {
                imp.rollback();
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
    }
}
