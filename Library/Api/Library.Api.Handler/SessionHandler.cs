using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Library.Api.Handler
{
    public abstract class SessionHandler
    {
        private static HttpSessionState _session = HttpContext.Current.Session;

        public static void Set<T>(string name, T obj)
        {

            _session[name] = obj;
        }

        public static T Get<T>(string name)
        {
            var obj = _session[name];
            return (T)obj;
        }

        public static bool IsExist(string name)
        {
            return _session[name] != null;
        }

        public static void Remove(string name)
        {
            if (IsExist(name))
                _session.Remove(name);
        }
    }
}