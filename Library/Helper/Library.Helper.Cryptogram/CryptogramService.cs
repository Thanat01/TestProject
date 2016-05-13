using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace Library.Helper.Cryptogram
{
    public class CryptogramService
    {
        private string _PublicKey;

        public CryptogramService(string publicKey) { _PublicKey = publicKey; }

        /// <summary>
        /// Encryption data
        /// </summary>
        /// <param name="value">The data to encryption</param>
        /// <returns>Encryption data</returns>
        public string Encryption(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Have no data to encryption.");

                MemoryStream msEncrypt = new MemoryStream();
                System.Security.Cryptography.RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider();

                RC2.Key = Encoding.ASCII.GetBytes(_PublicKey);
                byte[] iv = { 25, 53, 21, 22, 25, 25, 20, 10 };
                RC2.IV = iv;
                System.Security.Cryptography.ICryptoTransform myEncryptor = RC2.CreateEncryptor();

                //Convert string to Int start
                StringBuilder newValue = new StringBuilder();
                foreach (char x in value)
                {
                    newValue.Append((int)x + ",");
                }
                string groupString = newValue.ToString().Substring(0, newValue.Length - 1);
                //end

                //byte[] pwd = Encoding.ASCII.GetBytes(value);
                byte[] pwd = Encoding.ASCII.GetBytes(groupString);

                CryptoStream myCryptoStream = new CryptoStream(msEncrypt, myEncryptor, CryptoStreamMode.Write);
                myCryptoStream.Write(pwd, 0, pwd.Length);
                myCryptoStream.Close();

                return Convert.ToBase64String(msEncrypt.ToArray());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Decryption
        /// </summary>
        /// <param name="value">Encryption data</param>
        /// <returns>Decryption data</returns>
        public string Decryption(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Have no data to decryption.");

                MemoryStream msDecrypt = new MemoryStream();
                System.Security.Cryptography.RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider();
                RC2.Key = Encoding.ASCII.GetBytes(_PublicKey);
                byte[] iv = { 25, 53, 21, 22, 25, 25, 20, 10 };
                RC2.IV = iv;

                System.Security.Cryptography.ICryptoTransform myDecryptor = RC2.CreateDecryptor();
                byte[] pwd = Convert.FromBase64String(value);
                CryptoStream cCryptoStream = new CryptoStream(msDecrypt, myDecryptor, CryptoStreamMode.Write);
                cCryptoStream.Write(pwd, 0, pwd.Length);
                cCryptoStream.Close();

                List<int> groupString = Encoding.ASCII.GetString(msDecrypt.ToArray()).ToString().Split(',').ToList().Select(int.Parse).ToList();

                StringBuilder newValue = new StringBuilder();
                foreach (int x in groupString)
                {
                    newValue.Append(Convert.ToChar(x));
                }
                //return Encoding.ASCII.GetString(msDecrypt.ToArray());
                return newValue.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
