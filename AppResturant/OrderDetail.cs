using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppResturant
{
    class OrderDetail : Sale , InterSql
    {
        #region Method 

       new  public void update()
        {
            string s = "UPDATE `tborderdetail` SET `fid`='" + fid + "', `price`='" + price + "',`qty`='" + qty + "' , des='" + des + "'" +
                     " WHERE oid='" + oid + "' AND fid='" + oldfid + "'";
            exc(s);
            s = "UPDATE `tbOrder` SET Ctype='" + ctype + "', uid='"+AppConfig.usid+"' WHERE oid='" + oid + "'";
            exc(s);

        }
       new public void delete()
       {
            string s = "DELETE FROM `tbOrderdetail` WHERE `oid`='" + oid + "' AND `fid`='" + fid + "'";
            exc(s);
       }
       new public void insert()
       {
            string s=  "INSERT INTO `tbOrderDetail` VALUES('" + oid + "','" + fid + "','" + price + "','" + qty + "','" + des + "')";
            exc(s);
        }
        
        #endregion

        #region Instance_Entity

        #endregion
    }
}
