using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinWallet.Class
{
    public class MyFile
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
        
        public bool CheckWalletName(string name)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if(File.Exists(Path.Combine(desktopPath, name)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ReadFile(string name)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            return File.ReadAllText(Path.Combine(desktopPath, name));
        }

        public void SaveToFile(string content, string path)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            FileStream fs = new FileStream(Path.Combine(desktopPath, path), FileMode.Create);
            byte[] data = new UTF8Encoding(true).GetBytes(content);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }
        public void SaveUnecryptedFile(string plain, string path)
        {
            SaveToFile(plain, path);
        }
        public void SaveEncryptedFile(string cipher, string password, string path)
        {
            Aes aes = new Aes();
            string encrypted = aes.Encrypt(cipher, password);
            SaveToFile(encrypted, path);
        }
    }
}
