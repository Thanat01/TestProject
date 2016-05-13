using OStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Service
{
    public class AuthorizationService : IDisposable
    {

        private AT.Business.Authorization _authorization;
        public AuthorizationService(int shopId)
        {
            _authorization = new AT.Business.Authorization(shopId);
        }


        public AuthorizationModel InternalSingIn(string userName, string password)
        {
            try
            {
                return _authorization.InternalSingIn(userName, password);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AuthorizationModel ExternalSingIn(string externalSystem, string externalUserId)
        {
            try
            {
                return _authorization.ExternalSingIn(externalSystem, externalUserId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_authorization != null)
                _authorization = null;
        }

        #endregion
    }
}
