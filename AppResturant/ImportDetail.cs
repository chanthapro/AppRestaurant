using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppResturant
{
    class ImportDetail : Import, InterImport
    {
        public double dQty { get; set; }
        public void insertImport()
        {
            string s = "INSERT INTO `tbimport`(`impdate`,`uid`) VALUES('" + date.ToString("yyy-MM-dd HH:mm:ss") + "','" + AppConfig.usid + "')";
            exc(s);
            impid = getLastID();
        }

        public void insertImportDetail()
        {
            string s = "INSERT INTO `tbimportdetail` VALUES('" + impid + "','" + fid + "','" + dQty + "','" + price + "')";
            exc(s);
        }

        public void updateImport()
        {
            string s = "UPDATE `tbimport` SET `impdate`='" + date.ToString("yyy - MM - dd HH: mm:ss") + "',uid='" + AppConfig.usid + "' WHERE `impid`='"+impid+"' AND `fid`='"+fid+"'";
            exc(s);
        }

        public void updateImportDetail()
        {
            string s = "UPDATE `tbimportdetail` SET `fid`='" + fid + "',`qty`='" + dQty + "',`price`='" + price + "' WHERE `impid`='" + impid + "' AND `fid`='"+fid+"'";
            exc(s);
        }
        new public void insert()
        {
            insertImport();
            insertImportDetail();
        }
        new public void update()
        {
            updateImport();
            updateImportDetail();
        }
        new public void delete()
        {
            string s = "DELETE FROM `tbimportdetail` WHERE `impid`='" + impid + "' AND `fid`='" + fid + "'";
            exc(s);
        }

    }
}
