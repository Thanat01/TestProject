using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Providers
{
    public class ConfigurationProvider
    {
        private static ConfigurationProvider _instance;
        public static ConfigurationProvider Instance
        {
            get { return _instance ?? (_instance = new ConfigurationProvider()); }
        }

        internal string PMHostUrl
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["PMHostUrl"] != null)
                    return System.Configuration.ConfigurationManager.AppSettings["PMHostUrl"].ToString();
                else
                    throw new Exception("PMHostUrl Configuration not found.");
            }
        }
        internal string ATHostUrl
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["ATHostUrl"] != null)
                    return System.Configuration.ConfigurationManager.AppSettings["ATHostUrl"].ToString();
                else
                    throw new Exception("ATHostUrl Configuration not found.");
            }
        }
        internal string PMPublicKey
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["PMPublicKey"] != null)
                    return System.Configuration.ConfigurationManager.AppSettings["PMPublicKey"].ToString();
                else
                    throw new Exception("PMPublicKey Configuration not found.");
            }
        }
        internal string ATPublicKey
        {
            get
            {
                if (System.Configuration.ConfigurationManager.AppSettings["ATPublicKey"] != null)
                    return System.Configuration.ConfigurationManager.AppSettings["ATPublicKey"].ToString();
                else
                    throw new Exception("ATPublicKey Configuration not found.");
            }
        }
    }
}