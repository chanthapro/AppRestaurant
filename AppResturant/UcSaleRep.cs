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
    public partial class UcSaleRep : UserControl
    {
        public UcSaleRep()
        {
            InitializeComponent();
        }

        #region Object
        private OrderDetail sale { get; set; }
        private FormatClass fmt { get; set; }
        private InforClass inf { get; set; }
        #endregion

        #region Method
        private void setData()
        {
            sale.oid = int.Parse(txtOID.Text);
            sale.fid = int.Parse(cbfid.SelectedItem + "");
            sale.qty = int.Parse(txtQty.Text);
            sale.price = double.Parse(txtPrice.Text);
            sale.des = txtDes.Text;
            if (rbDelivery.Checked) sale.ctype = "ខ្ចប់";
            else sale.ctype = "តុលេខ​ " + " " + txtTableNum.Text.Replace("'","''");
        }
        private void refreshData()
        {
            if (!txtSearch.Text.Trim().Equals(""))
            {
                sale.oid = int.Parse(txtSearch.Text);
                sale.getDgv(dgv, sale.querydata + " WHERE od.oid = '" + sale.oid + "'");
            }
            else
            {
                sale.getDgv(dgv, sale.querydata);
            }
            fmt.Clear(plContain);
            txtOID.Clear();
            txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0") + " រៀល";
        }
        private void print()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int index = dgv.SelectedRows[0].Index;
                sale.ctype = dgv.Rows[index].Cells[7].Value + "";
                sale.oid = int.Parse(dgv.Rows[index].Cells[0].Value + "");
                List<InvoicePay> arr = new List<InvoicePay>();
                int No = 0;
                double total = 0;
                foreach (DataGridViewRow temp in dgv.Rows)
                {
                    if (sale.oid != int.Parse(temp.Cells[0].Value + ""))
                        continue;
                    InvoicePay item = new InvoicePay();
                    item.No = No += 1;
                    string fname = temp.Cells[2].Value + "";
                    string[] f = fname.Split(',');
                    item.fnamekh = f[0];
                    item.fnamecn = f[1];
                    item.price = double.Parse(temp.Cells[4].Value + "");
                    item.qty = int.Parse(temp.Cells[3].Value + "");
                    total += item.amount;
                    arr.Add(item);
                }

                frmInvoice p = new frmInvoice();
                p.CrsInvoice.SetDataSource(arr);
                p.CrsInvoice.SetParameterValue(0, AppConfig.uname);
                p.CrsInvoice.SetParameterValue(1, sale.oid.ToString("00000000"));
                p.CrsInvoice.SetParameterValue(2, total);
                p.CrsInvoice.SetParameterValue(3, total / 4000);
                p.CrsInvoice.SetParameterValue(4, sale.ctype);
                p.CrsInvoice.SetParameterValue(5, 0);
                p.CrsInvoice.SetParameterValue(6, 0);
                p.CrsInvoice.PrintToPrinter(1, true, 0, 0);
                

            }
        }
        #endregion

        #region Button Event
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                setData();
                sale.start();
                sale.insert();
                sale.commit();
                fmt.Clear(plContain);
                txtPrice.Clear();
                refreshData();
                dgv.ClearSelection();
                

            }
            catch (Exception)
            {
                sale.rollback();
                new frmMsg(inf.ErrorInput).ShowDialog();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    if (new frmMsg(inf.ComfirmUpdate).ShowDialog() == DialogResult.OK)
                    {
                        setData();
                        sale.update();
                        fmt.Clear(plContain);
                        fmt.Clear(dgv);
                        refreshData();
                    }
                }

            }
            catch (Exception ex)
            {
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    if (new frmMsg(inf.ComfirmDelete).ShowDialog() == DialogResult.OK)
                    {
                        sale.fid = int.Parse(cbfid.SelectedItem + "");
                        sale.oid = int.Parse(txtOID.Text);
                        sale.delete();
                        refreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fmt.Clear(plContain);
            txtPrice.Clear();
            dgv.ClearSelection();
            txtOID.Clear();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                print();

            }
            catch (Exception ex)
            {
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        #endregion


        private void UcSaleRep_Load(object sender, EventArgs e)
        {
            try
            {
                sale = new OrderDetail();
                inf = new InforClass();
                fmt = new FormatClass();
                sale.DataCon();
                sale.getDgv(dgv, sale.querydata);
                sale.getItemCombox(cbfid, sale.queryfid);
                sale.getItemCombox(cbfname, sale.queryfname);
                fmt.setWidthdgv(dgv, 2);
                fmt.setVisibledgv(dgv, 8);
                fmt.disableCusor(txtOID);
                fmt.setCurrencydgv(dgv, 4, 5);
                dgv.Columns[1].DefaultCellStyle.Font = new Font("Arial", 8.5F);
                txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0");
            }
            catch(Exception)
            {
                new frmMsg(inf.ErrorInput).ShowDialog();
            }
        }

     
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    txtOID.Text = dgv.Rows[index].Cells[0].Value + "";
                    cbfid.SelectedItem = dgv.Rows[index].Cells[8].Value + "";
                    sale.oldfid = int.Parse(dgv.Rows[index].Cells[8].Value + "");
                    txtPrice.Text = dgv.Rows[index].Cells[4].Value + "";
                    txtQty.Text = dgv.Rows[index].Cells[3].Value + "";
                    txtDes.Text = dgv.Rows[index].Cells[6].Value + "";
                    string c = dgv.Rows[index].Cells[7].Value + "";
                    string[] oc = c.Split(' ');
                    if (oc[0].Equals("តុលេខ"))
                    {
                        rbTable.Checked = true;
                        txtTableNum.Text = oc[1];
                    }
                    else
                    {
                        rbDelivery.Checked = true;
                        txtTableNum.Clear();
                    }
                      
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                cbfname.SelectedIndex = cbfid.SelectedIndex;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void txtOID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

     

        private void cbfid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    cbfid.SelectedItem = cbfid.Text;
                    sale.fid = int.Parse(cbfid.SelectedItem + "");
                    txtPrice.Text = sale.getPrice(sale.queryPrice) + "";
                    txtQty.Focus();                  
                }
            }
            catch(Exception)
            {
                new frmMsg(inf.ErrorInput).ShowDialog();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    setData();
                    btnAdd_Click(sender, e);
                }
            }
            catch(Exception)
            {
                new frmMsg(inf.ErrorInput).ShowDialog();
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim().Equals(""))
                {
                    sale.getDgv(dgv, sale.querydata);
                }
                else
                {
                    sale.oid = int.Parse(txtSearch.Text);
                    sale.getDgv(dgv, sale.querydata + " WHERE od.oid = '" + sale.oid + "'");
                }                               
                txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0") + " រៀល";
            }
            catch (Exception ex)
            {
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
                
        }

        private void dtF_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtF.Value > dtTo.Value)
                    return;
                else
                {
                    sale.getDgv(dgv, sale.querydata + " WHERE odate BETWEEN '" + dtF.Value.ToString("yyy-MM-dd HH:mm:ss") + "'AND '" + dtTo.Value.ToString("yyy-MM-dd HH:mm:ss") + "'");
                    txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0")+" រៀល";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
