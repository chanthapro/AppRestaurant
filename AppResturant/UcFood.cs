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
    public partial class UcFood : UserControl
    {
        public UcFood()
        {
            InitializeComponent();
        }
        #region Object

        private Food food = new Food();
        private FormatClass fmt = new FormatClass();
        #endregion
        #region Method
        public void setData()
        {
            food.fnamekh = txtFnameKH.Text;
            food.fnamecn = txtFnameCN.Text;
            food.fnameen = txtfnameEN.Text;
            food.price = double.Parse(txtPrice.Text);
        }
        #endregion 

        private void UcFood_Load(object sender, EventArgs e)
        {
            try
            {
                food.DataCon();
                food.getDgv(dgv, food.queryDgv);
                fmt.setWidthdgv(dgv, 1);
                fmt.setHeader(dgv);
                fmt.setCurrencydgv(dgv, 4);
                dgv.Columns[0].Width -= 100;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                setData();
                food.start();
                food.insert();
                food.commit();
                food.getDgv(dgv, food.queryDgv);
                fmt.Clear(plContain);
            }
            catch(Exception ex)
            {
                food.rollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    int index = dgv.SelectedRows[0].Index;
                    txtFid.Text = dgv.Rows[index].Cells[0].Value + "";
                    txtFnameKH.Text = dgv.Rows[index].Cells[1].Value + "";
                    txtFnameCN.Text = dgv.Rows[index].Cells[2].Value + "";
                    txtfnameEN.Text = dgv.Rows[index].Cells[3].Value + "";
                    txtPrice.Text = double.Parse(dgv.Rows[index].Cells[4].Value.ToString()).ToString("###0");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    food.fid = int.Parse(txtFid.Text);
                    setData();
                    food.update();
                    food.getDgv(dgv, food.queryDgv);
                    fmt.Clear(plContain);
                    dgv.ClearSelection();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fmt.Clear(plContain);
        }
    }
}
