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
    public partial class UcSale : UserControl
    {
        public UcSale()
        {
            InitializeComponent();
        }
       
        #region Object
        Sale sale = new Sale();
        FormatClass fmt = new FormatClass();
        private InforClass inf { get; set; }
        private PayClass pc { get; set; }
        private Files file { get; set; }
        #endregion

        #region Method
        private void addData()
        {
            if (cbfname.SelectedIndex < 0)
            {
                cbfid.Focus();
                return;
            }
            setData();
            foreach(DataGridViewRow temp in dgv.Rows)
            {
                if (temp.Cells[0].Value + "" == sale.fid+"")
                {
                    int oldqty = int.Parse(temp.Cells[3].Value + "");
                    temp.Cells[3].Value = sale.qty + oldqty;
                    temp.Cells[4].Value = (sale.qty+oldqty) * sale.price;
                    temp.Cells[5].Value = sale.des;
                    refreshdata();
                    return;
                }
            }
            object[] row = { sale.fid, sale.fnamekh, sale.price, sale.qty, sale.amount, sale.des };
            dgv.Rows.Add(row);
            refreshdata();
        }
        private void setData()
        {
            sale.fid = int.Parse(cbfid.SelectedItem + "");
            sale.fnamekh = cbfname.SelectedItem + "";
            sale.price = double.Parse(txtPrice.Text);
            sale.qty = int.Parse(txtQty.Text);
            sale.des = txtDes.Text;
        }
        private void refreshdata()
        {
            fmt.Clear(plContain);
            cbfid.Focus();
            txtCountFood.Text = dgv.RowCount + "";
            sale.Total += sale.amount;
            txtTotal.Text = fmt.getTotal(dgv, 4).ToString("#,##0") + " រៀល";
            dgv.ClearSelection();
        }
        private void print(int copy)
        {

            List<InvoicePay> arr = new List<InvoicePay>();
            int No = 0;
            double total = fmt.getTotal(dgv, 4);
            sale.oid = sale.lastid;
            foreach(DataGridViewRow temp in dgv.Rows)
            {
                InvoicePay item = new InvoicePay();
                item.No = No += 1;
                string fname = temp.Cells[1].Value + "";
                string[] f = fname.Split(',');
                item.fnamekh = f[0];
                item.fnamecn = f[1];
                item.price = double.Parse(temp.Cells[2].Value + "");
                item.qty = int.Parse(temp.Cells[3].Value + "");
                arr.Add(item);
            }
            frmInvoice p = new frmInvoice();
            p.CrsInvoice.SetDataSource(arr);
            p.CrsInvoice.SetParameterValue(0, AppConfig.uname);
            p.CrsInvoice.SetParameterValue(1, sale.oid.ToString("00000000"));
            p.CrsInvoice.SetParameterValue(2, total);
            p.CrsInvoice.SetParameterValue(3, total / 4000);
            p.CrsInvoice.SetParameterValue(4, sale.ctype);
            p.CrsInvoice.SetParameterValue(5, frmPayment.ReturnD * 4000);
            p.CrsInvoice.SetParameterValue(6, frmPayment.ReturnD);
            for (int i = 0; i < copy; i++)
            {
                p.CrsInvoice.PrintToPrinter(1, false, 0, 0);
            }


        }
        private void checktype()
        {
            if (rbDelivery.Checked)
            {
                sale.ctype = "ខ្ទប់";
            }
            else
            {
                if (txtTableNum.Text.Trim().Equals(""))
                {
                    new frmMsg(inf.ErroCustomer).ShowDialog();
                    return;
                }
                else
                {
                    sale.ctype = "តុលេខ " + txtTableNum.Text;
                }
            }
        }
        #endregion

        #region RadioButton Event
        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDelivery.Checked)
                {
                    txtTableNum.Enabled = false;
                    txtTableNum.Clear();
                    sale.ctype = "ខ្ទប់";
                }
                else
                {
                    txtTableNum.Enabled = true;
                    sale.ctype = "តុលេខ " + txtTableNum.Text;
                }
                   
            }
            catch(Exception ex)
            {
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        #endregion

        #region Form Event
        private void ucFood_Load(object sender, EventArgs e)
        {
            try
            {
                sale.DataCon();
                inf = new InforClass();
                pc = new PayClass();
                file = new Files();
                sale.getItemCombox(cbfname, sale.queryfname);
                sale.getItemCombox(cbfid, sale.queryfid);
                rbDelivery.Checked = true;
                txtTableNum.Focus();
            }
            catch(Exception ex)
            {
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        #endregion

        #region TextBox Event
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                fmt.CheckQty(e,txtQty);
                if (txtQty.Text.Trim().Equals(""))
                    return;
                if (e.KeyChar == 13)
                {
                    addData();
                }
            }
            catch(Exception)
            {
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
                    cbfid.SelectedItem = dgv.Rows[index].Cells[0].Value + "";
                    txtPrice.Text = dgv.Rows[index].Cells[2].Value + "";
                    txtQty.Text = dgv.Rows[index].Cells[3].Value + "";
                    txtDes.Text = dgv.Rows[index].Cells[5].Value + "";
                  
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        #endregion

        #region Button Event
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    setData();
                    dgv.Rows[index].Cells[0].Value = sale.fid;
                    dgv.Rows[index].Cells[1].Value = sale.fnamekh;
                    dgv.Rows[index].Cells[2].Value = sale.price;
                    dgv.Rows[index].Cells[3].Value = sale.qty;
                    dgv.Rows[index].Cells[4].Value = sale.amount;
                    dgv.Rows[index].Cells[5].Value = sale.des;
                    txtTotal.Text = fmt.getTotal(dgv, 4).ToString("#,##0") + " រៀល";
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    dgv.Rows.RemoveAt(index);
                    refreshdata();
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    if (rbTable.Checked)
                    {
                        if (txtTableNum.Text.Trim().Equals(""))
                        {
                            new frmMsg(inf.ErroCustomer).ShowDialog();
                            return;
                        }
                    }
                    if (new frmPayment((int)fmt.getTotal(dgv,4)).ShowDialog() == DialogResult.OK)
                    {

                        #region Initialize Value
                        checktype();
                        sale.date = DateTime.Now;
                        #endregion

                        #region InsertData
                        sale.start();
                        sale.insertOrder(dgv);
                        pc.oid = sale.lastid;
                        pc.insert();
                        sale.commit();
                        #endregion

                        #region PrintInvoice
                        print(2);
                        #endregion

                        #region ClearScreen
                        fmt.Clear(plContain);
                        dgv.Rows.Clear();
                        refreshdata();
                        txtTableNum.Clear();
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                sale.rollback();
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addData();
            }
            catch (Exception)
            {
                new frmMsg(inf.ErrorSetData).ShowDialog();
            }
        }

        private void btnPrintTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.RowCount > 0)
                {
                    if (rbTable.Checked)
                    {
                        if (txtTableNum.Text.Trim().Equals(""))
                        {
                            new frmMsg(inf.ErroCustomer).ShowDialog();
                            return;
                        }
                    }
                    #region Initialize Value
                    checktype();
                    sale.date = DateTime.Now;
                    #endregion

                    #region InsertData
                    sale.start();
                    sale.insertOrder(dgv);
                    sale.commit();
                    #endregion

                    #region PrintInvoice
                    frmPayment.ReturnD = 0;
                    print(1);
                    #endregion

                    #region ClearScreen
                    fmt.Clear(plContain);
                    dgv.Rows.Clear();
                    refreshdata();
                    txtTableNum.Clear();
                    #endregion
                }

            }
            catch (Exception ex)
            {
                sale.rollback();
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        #endregion

        #region Combobox Event
        private void cbfname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbfid.SelectedIndex = cbfname.SelectedIndex;
                if (cbfid.SelectedIndex >= 0 && cbfname.SelectedIndex >= 0)
                {
                    sale.fid = int.Parse(cbfid.SelectedItem + "");
                    txtPrice.Text = sale.getPrice(sale.queryPrice) + "";
                }
            }
            catch(Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        private void cbfid_Leave(object sender, EventArgs e)
        {
            try
            {
                cbfid.SelectedItem = cbfid.Text;
                if (cbfid.SelectedIndex < 0)
                {
                    fmt.Clear(plContain);
                }
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
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
                file.ErrorLog(ex.ToString());
                new frmMsg(ex.Message).ShowDialog();
            }
        }
        private void cbfid_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                #region CheckDataQty
                fmt.CheckQty(e, cbfid);
                #endregion

                #region Initailize Value
                if (e.KeyChar == 13)
                {
                    cbfid.SelectedItem = cbfid.Text.Trim();
                    if (cbfid.SelectedIndex >= 0 && cbfname.SelectedIndex >= 0)
                    {
                        sale.fid = int.Parse(cbfid.Text);                       
                        
                        txtQty.Clear();
                        txtQty.Focus();
                    }
                    else
                    {
                        new frmMsg(inf.ErrorInput).ShowDialog();
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                file.ErrorLog(ex.ToString());
                new frmMsg(inf.ErrorSetData).ShowDialog();
            }
        }



        #endregion

        private void txtTableNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtTableNum.Text.Trim().Equals(""))
                    return;
                cbfid.Focus();
            }
        }

      
    }
}
