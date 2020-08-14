using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppResturant
{
    class Sale : Food
    {

        #region Method
        
        public void insertOrder(DataGridView dgv)
        {
            string s = "INSERT INTO `tbOrder`(`ODate`,`uid`,`ctype`) VALUES ('" + date.ToString("yyy-MM-dd HH:mm:ss") + "','" + AppConfig.usid + "','" + ctype + "')";
            exc(s);
            lastid = getLastID();
            foreach(DataGridViewRow temp in dgv.Rows)
            {
                fid = int.Parse(temp.Cells[0].Value + "");
                price = double.Parse(temp.Cells[2].Value + "");
                qty = int.Parse(temp.Cells[3].Value + "");
                des = temp.Cells[5].Value + "";
                s = "INSERT INTO `tbOrderDetail` VALUES('" + lastid + "','" + fid + "','" + price + "','" + qty + "','" + des + "')";
                exc(s);
            }
        }
        #endregion

        #region Query
        public string queryfname { get { return "SELECT CONCAT(fnamekh,' , ',fnamecn) FROM `tbFood` ORDER BY fid "; } }
        public string queryfid { get { return "SELECT fid FROM `tbFood` ORDER BY fid "; } }
        public string querydata { get {
                return "SELECT od.oid AS លេខវិក័យបត្រ ," +
                    " odate AS ថ្ងៃខែឆ្នាំ ," +
                    " CONCAT(fnamekh,',', fnamecn) AS ឈ្មោះម្ហូប ," +
                    " qty AS ចំនួន," +
                    " od.price AS តម្លៃដើម," +
                    " qty * od.price AS តម្លៃសុរប ," +
                    " des AS សំគាល់ ," +
                    " ctype AS អថិជន ," +
                    " od.fid" +
                    " FROM tborder o" +
                    " INNER JOIN tborderdetail od" +
                    " ON o.oid=od.oid" +
                    " INNER JOIN tbfood f" +
                    " ON f.fid=od.fid ";
                         } }
        #endregion

        #region Instane Sale
        public string des { get; set; }
        public DateTime date { get; set; }
        public string ctype { get; set; }
        public int lastid { get; set; }
        public int oid { get; set; }
        public int oldfid { get; set; }
        
        #endregion
    }
    
}
