using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinWallet.Class
{
    public class File
    {
        public string ReturnFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else
            {
                return null;
            }
        }
        public void SaveUnecryptedFile(string content)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fullPath = Path.Combine(desktopPath, "default_wallet.dat");
            FileStream fs = new FileStream(fullPath, FileMode.Create);

            byte[] data = new UTF8Encoding(true).GetBytes(content);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }
    }
}
