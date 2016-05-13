using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Service
{
    public class LocationService: IDisposable
    {

        private PM.Business.Location _location;

        public LocationService(int shopId, int userId)
        {
            _location = new Business.Location(shopId, userId);
        }

        public List<OStore.Model.Base.ProvinceModel> GetProvinces()
        {
            try
            {
                return _location.GetProvinces();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<OStore.Model.Base.DistrictModel> GetDistricts()
        {
            try
            {
                return _location.GetDistricts();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OStore.Model.Base.SubDistrictModel> GetSubDistrict()
        {
            try
            {
                return _location.GetSubDistrict();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<OStore.Model.Base.PostalCodeModel> GetPostalCodes()
        {
            try
            {
                return _location.GetPostalCodes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (_location != null)
            {
                _location = null;
            }
        }

        #endregion
    }
}
