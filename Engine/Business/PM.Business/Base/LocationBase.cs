using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business.Base
{
    public class LocationBase : Library.Business.Base.BusinessBase
    {
        public LocationBase(int shopId, int userId)
            : base(shopId, userId)
        {
            CreateModelMapping();
        }

        private void CreateModelMapping()
        {
            Mapper.CreateMap<OStore.Data.EF.Province, OStore.Model.Base.ProvinceModel>();
            Mapper.CreateMap<OStore.Model.Base.ProvinceModel, OStore.Data.EF.Province>();

            Mapper.CreateMap<OStore.Data.EF.District, OStore.Model.Base.DistrictModel>();
            Mapper.CreateMap<OStore.Model.Base.DistrictModel, OStore.Data.EF.District>();

            Mapper.CreateMap<OStore.Data.EF.SubDistrict, OStore.Model.Base.SubDistrictModel>();
            Mapper.CreateMap<OStore.Model.Base.SubDistrictModel, OStore.Data.EF.SubDistrict>();

            Mapper.CreateMap<OStore.Data.EF.PostalCode, OStore.Model.Base.PostalCodeModel>();
            Mapper.CreateMap<OStore.Model.Base.PostalCodeModel, OStore.Data.EF.PostalCode>();
        }
    }
}
