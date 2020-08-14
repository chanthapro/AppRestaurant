using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppResturant
{
    class PayClass:Sale
    {
       public int pay { get; set; }
       new public void insert()
        {
            string s = "INSERT INTO tbpayment (oid) VALUES('" + oid + "')";
            exc(s);
        }
        new public void delete()
        {
            string s="DELETE FROM tbpayment WHERE oid='"+oid+"'";
            exc(s);
        }
    }
}
