using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace BitcoinWallet.Class
{
    /// <summary>
    /// Used for encrypting and decrypting wallet.dat file.
    /// </summary>
    public class Aes
    {
        private String File { get; set; }
        private String Secret { get; set; }

        public Aes(string file, string password)
        {
            File = file;
            Secret = password;
        }

        private static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            RNGCryptoServiceProvider rngcsp = new RNGCryptoServiceProvider();
            for(int i = 0; i < 10; i++)
            {
                rngcsp.GetBytes(salt);
            }
            return salt;
        }

        public void Encrypt()
        {
            var pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullPath = Path.Combine(pathToDesktop, "wallet.dat");

            byte[] salt = GenerateSalt();
            byte[] passwordByte = Encoding.UTF8.GetBytes(Secret);
            var key = new Rfc2898DeriveBytes(passwordByte, salt, 50000);

            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Mode = CipherMode.CBC;

            FileStream fsEncrypt = new FileStream(fullPath, FileMode.Create);
            fsEncrypt.Write(salt, 0, salt.Length);
            CryptoStream cs = new CryptoStream(fsEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fs = new FileStream(File, FileMode.Open);
            byte[] buffer = new byte[1048576];
            int read;

            while((read = fs.Read(buffer, 0,  buffer.Length)) > 0)
            {
                cs.Write(buffer, 0, read);
            }

            cs.Close();
            fs.Close();
            fsEncrypt.Close();
        }

        public string Decrypt()
        {
            byte[] passwordByte = Encoding.UTF8.GetBytes(Secret);
            byte[] salt = new byte[32];

            FileStream fsDecrypt = new FileStream(File, FileMode.Open);
            fsDecrypt.Read(salt, 0, salt.Length);

            var key = new Rfc2898DeriveBytes(passwordByte, salt, 50000);
            RijndaelManaged aes = new RijndaelManaged();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] buffer = new byte[1048576];
            cs.Read(buffer, 0, buffer.Length);

            return Encoding.UTF8.GetString(buffer);
        }
    }
}
