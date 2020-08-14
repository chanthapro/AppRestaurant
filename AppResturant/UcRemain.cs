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
    public partial class UcRemain : UserControl
    {
        public UcRemain()
        {
            InitializeComponent();
        }
        #region Object
        private OrderDetail sale { get; set; }
        private FormatClass fmt { get; set; }
        private InforClass inf { get; set; }
        private PayClass pc { get; set; }
        private Files file { get; set; }

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
            else sale.ctype = "តុលេខ" + " " + txtTableNum.Text.Replace("'", "''");
        }
        private void refreshData()
        {
            if (cbPayment.SelectedIndex == 0)
            {
                if(txtSearch.Text.Trim().Equals(""))
                    sale.getDgv(dgv, sale.querydata + " WHERE od.oid NOT IN(SELECT oid FROM tbpayment) ORDER BY od.oid");
                else
                {
                    sale.oid = int.Parse(txtOID.Text);
                    sale.getDgv(dgv, sale.querydata + " WHERE od.oid  NOT IN(SELECT oid FROM tbpayment) AND od.oid='"+sale.oid+"' ORDER BY od.oid");
                }
            }
            else
            {
                if (txtSearch.Text.Trim().Equals(""))
                    sale.getDgv(dgv, sale.querydata + " WHERE od.oid  IN(SELECT oid FROM tbpayment) ORDER BY od.oid");
                else
                {
                    sale.oid = int.Parse(txtOID.Text);
                    sale.getDgv(dgv, sale.querydata + " WHERE od.oid  IN(SELECT oid FROM tbpayment) AND od.oid='" + sale.oid + "' ORDER BY od.oid");
                }
               
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
                p.CrsInvoice.SetParameterValue(5, frmPayment.ReturnD*4000);
                p.CrsInvoice.SetParameterValue(6, frmPayment.ReturnD);
                p.CrsInvoice.PrintToPrinter(1, true, 0, 0);
           
            }
        }
        #endregion

        #region WinForm Event
        private void UcRemain_Load(object sender, EventArgs e)
        {
            try
            {
                sale = new OrderDetail();
                fmt = new FormatClass();
                inf = new InforClass();
                file = new Files();
                pc = new PayClass();
                sale.getDgv(dgv, sale.querydata + " WHERE od.oid NOT IN(SELECT oid FROM tbpayment)");
                sale.getItemCombox(cbfid, sale.queryfid);
                sale.getItemCombox(cbfname, sale.queryfname);
                fmt.setWidthdgv(dgv, 2);
                fmt.setVisibledgv(dgv, 8);
                fmt.disableCusor(txtOID);
                fmt.setCurrencydgv(dgv, 4, 5);
                txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0");
                cbPayment.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        #endregion

        #region Button Event

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
            catch (Exception ex)
            {
                sale.rollback();
                file.ErrorLog(ex.ToString());
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
                file.ErrorLog(ex.ToString());
                new frmMsg(inf.ErrorInput).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fmt.Clear(plContain);
            txtPrice.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                frmPayment.ReturnD = 0;
                print();

            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPayment.SelectedIndex == 0)
                {
                    if (dgv.SelectedRows.Count > 0)
                    {
                        int index = dgv.SelectedRows[0].Index;
                        pc.oid = int.Parse(dgv.Rows[index].Cells[0].Value + "");
                        decimal total = 0;
                        foreach(DataGridViewRow temp in dgv.Rows)
                        {
                            if (pc.oid != int.Parse(temp.Cells[0].Value+""))
                                continue;

                            total += decimal.Parse(temp.Cells[5].Value + "");
 
                        }

                        if (new frmPayment((int)total).ShowDialog() == DialogResult.OK)
                        {
                            
                            pc.insert();
                            print();
                            refreshData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.Message);
                new frmMsg(ex.ToString()).ShowDialog();
            }
        }
        #endregion

        #region ComboBox Event
        private void cbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPayment.SelectedIndex == 0)
                {
                    btnDeletePay.Visible = false;
                    refreshData();
                    txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0") + " រៀល";
                }
                else
                {
                    refreshData();
                    txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0") + " រៀល";
                    btnDeletePay.Visible = true;
                }
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void cbfid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.CheckQty(e, sender as ComboBox);
                if (e.KeyChar == 13)
                {
                    cbfid.SelectedItem = cbfid.Text;
                    sale.fid = int.Parse(cbfid.SelectedItem + "");
                    txtPrice.Text = sale.getPrice(sale.queryPrice) + "";
                    txtQty.Focus();
                }
            }
            catch (Exception)
            {
                new frmMsg(inf.ErrorInput).ShowDialog();
            }
        }
        private void cbfid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbfname.SelectedIndex = cbfid.SelectedIndex;
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TextBox Event
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPayment.SelectedIndex == 0)
                {
                    if (txtSearch.Text.Trim().Equals(""))
                    {
                        sale.getDgv(dgv, sale.querydata + "WHERE od.oid NOT IN(SELECT oid FROM tbpayment)");
                    }
                    else
                    {
                        sale.oid = int.Parse(txtSearch.Text);
                        sale.getDgv(dgv, sale.querydata + " WHERE od.oid NOT IN(SELECT oid FROM tbpayment) AND od.oid='" + sale.oid + "' ");
                    }
                }
                else
                {
                    if (txtSearch.Text.Trim().Equals(""))
                    {
                        sale.getDgv(dgv, sale.querydata + "WHERE od.oid  IN(SELECT oid FROM tbpayment)");
                    }
                    else
                    {
                        sale.oid = int.Parse(txtSearch.Text);
                        sale.getDgv(dgv, sale.querydata + " WHERE od.oid  IN(SELECT oid FROM tbpayment) AND od.oid='" + sale.oid + "' ");
                    }
                }
                txtTotal.Text = fmt.getTotal(dgv, 5).ToString("#,##0") + " រៀល";
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            fmt.CheckQty(e, txtSearch);
        }
        private void txtOID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(inf.ErrorInput).ShowDialog();
            }
        }
        #endregion

        #region Datagridview Event
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
            catch (Exception ex)
            {
                file.ErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        private void btnDeletePay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPayment.SelectedIndex == 1)
                {
                    if (dgv.SelectedRows.Count > 0)
                    {
                        if (new frmMsg(inf.Comfirm).ShowDialog() == DialogResult.OK)
                        {
                            pc.oid = int.Parse(txtOID.Text);
                            pc.delete();
                            refreshData();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
