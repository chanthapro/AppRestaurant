using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppResturant
{
    class Food : AppConfig, InterSql
    {

        #region Class Instance
        public int fid { get; set; }
        public string fnamekh { get; set; }
        public string fnamecn { get; set; }
        public string fnameen { get; set; }
        public double price { get; set; }
        public int qty { get; set; }
        public double amount { get { return qty * price; } }
        public double Total { get; set; }

        #endregion

        #region Implement
        public void delete()
        {
            string s = "DELTE FROM tbFood WHERE fid='" + fid + "'";
            exc(s);
        }

        public void insert()
        {
            string s = " INSERT INTO `tbFood` (`price`,`fnamekh`,`fnamecn`,`fnameen`) " +
                       " VALUES('" + price + "','" + fnamekh + "','" + fnamecn + "','" + fnameen + "')";
            exc(s);
        }

        public void update()
        {
            string s = " UPDATE `tbFood` SET `price`='" + price + "',`fnamekh`='" + fnamekh + "'," +
                     " `fnamecn`='" + fnamecn + "',`fnameen`='" + fnameen + "'" +
                     " WHERE fid='" + fid + "'";
            exc(s);
        }
        #endregion

        #region Query Instance
        public string queryDgv { get { return "SELECT fid AS លេខកូតម្ហូប , fnamekh AS ឈ្មោះម្ហូបជាភាសាខ្មែរ ,fnamecn AS ឈ្មោះម្ហូបជាភាសាចិន​ ,fnameen AS ឈ្មោះម្ហូបជាភាសាអង់គេ្លស​ , price AS តម្លៃដើម FROM `tbFood`"; } }
        public string queryPrice { get { return "SELECT price FROM `tbFood` WHERE fid='" + fid + "'"; } }
        #endregion
    }
}
