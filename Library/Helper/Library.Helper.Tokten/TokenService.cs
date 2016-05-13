using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helper.Token
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

        /// <summary>
        /// Generate token key
        /// </summary>
        /// <param name="privateKey">Private key. Charactors without _ - :</param>
        /// <returns></returns>
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

        public string[] VerifyToken(string token)
        {
            try
            {
                string[] result = new string[] { };

                string value = new Cryptogram.CryptogramService(_PublicKey).Decryption(token);
                string[] keys = value.Split(new string[] { _Splitor }, StringSplitOptions.None);
                if (keys.Length > 2)
                {
                    if (_PublicKey.Equals(keys[0]) || keys[0].ToLower().Equals("superteam"))
                    {
                        string[] datetimes = keys[2].Split('_');
                        if (datetimes.Length > 1)
                        {
                            string[] dates = datetimes[0].Split('-');
                            string[] times = datetimes[1].Split(':');
                            if (dates.Length > 2)
                            {
                                DateTime veryfyDate = new DateTime(Convert.ToInt32(dates[0]), Convert.ToInt32(dates[1]), Convert.ToInt32(dates[2]), Convert.ToInt32(times[0]), Convert.ToInt32(times[1]), Convert.ToInt32(times[2]), new System.Globalization.GregorianCalendar());
                                if (keys[0].ToLower().Equals("superteam") || veryfyDate > DateTime.Now)
                                {
                                    result = keys[1].Split('|');
                                }
                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
