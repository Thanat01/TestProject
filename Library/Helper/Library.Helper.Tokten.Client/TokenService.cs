using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helper.Token.Client
{
    public class TokenService
    {
        private string _PublicKey { get; set; }
        private string _Splitor = "(^-^)";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key">Public key. Charactors without _ - :</param>
        public TokenService(string publicKey)
        {
            _PublicKey = publicKey;
        }

        public string GenerateToken(int shopId, int userId, string userName, string password, DateTime? expiredDate)
        {
            try
            {
                string token = string.Empty;

                if (expiredDate == null)
                    expiredDate = DateTime.Now.AddYears(100);

                string value = expiredDate.Value.ToString("yyyy-MM-dd_HH:mm:ss", new System.Globalization.CultureInfo("en-US"));
                string privateKey = string.Format("{0}|{1}|{2}|{3}", shopId, userId, userName, password);

                token = string.Format("{0}{1}{2}{1}{3}", _PublicKey, _Splitor, privateKey, value);

                return new Cryptogram.CryptogramService(_PublicKey).Encryption(token);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
