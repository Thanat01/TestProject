using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class Location : PM.Business.Base.LocationBase
    {
        public Location(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.Base.ProvinceModel> GetProvinces()
        {
            try
            {
                List<OStore.Model.Base.ProvinceModel> result = new List<OStore.Model.Base.ProvinceModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    result = Mapper.Map(context.Provinces.Where(p => p.IsActive).ToList(), result);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OStore.Model.Base.DistrictModel> GetDistricts()
        {
            try
            {
                List<OStore.Model.Base.DistrictModel> result = new List<OStore.Model.Base.DistrictModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    result = Mapper.Map(context.Districts.Where(d => d.IsActive).ToList(), result);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OStore.Model.Base.SubDistrictModel> GetSubDistrict()
        {
            try
            {
                List<OStore.Model.Base.SubDistrictModel> result = new List<OStore.Model.Base.SubDistrictModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    result = Mapper.Map(context.SubDistricts.Where(s => s.IsActive).ToList(), result);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OStore.Model.Base.PostalCodeModel> GetPostalCodes()
        {
            try
            {
                List<OStore.Model.Base.PostalCodeModel> result = new List<OStore.Model.Base.PostalCodeModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    result = Mapper.Map(context.PostalCodes.Where(z => z.IsActive).ToList(), result);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
