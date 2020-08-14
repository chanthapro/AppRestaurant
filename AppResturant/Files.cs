using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AppResturant
{
    class Files
    {
        public void ErrorLog(string str)
        {
            string path = Application.StartupPath;
            string txtFile = path+"\\errorlog.txt";
            if (!File.Exists(txtFile))
            {
                FileStream fs = File.Create(txtFile);
            }
            File.AppendAllText(txtFile," Date: " + DateTime.Now + "\r\n");
            File.AppendAllText(txtFile, str+"\r\n");
            File.AppendAllText(txtFile, "---------------------------------------------\r\n\r\n");

        }
    }
}
