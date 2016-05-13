using AutoMapper;
using OStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.Business
{
    public class Shop : AT.Business.Base.ShopBase
    {
        public Shop(int shopId, int userId) : base(shopId, userId) { }

        public ShopInfoModel GetShopInfo(string dns)
        {
            try
            {
                ShopInfoModel result = null;

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    result = (from s in context.Shops
                              join p in context.People on s.Id equals p.ShopId
                              join pmt in context.PersonMapTypes on p.Id equals pmt.PersonId
                              join pa in context.PersonAddresses on p.Id equals pa.PersonId
                              where dns.StartsWith(s.DNS) && pmt.PersonTypeId == 1 && pa.AddressTypeId == 1 && s.IsActive && p.IsActive && pmt.IsActive && pa.IsActive
                              select new ShopInfoModel { Id = s.Id, ShortName = s.ShortName, LongName = s.LongName, DNS = s.DNS, ProvinceId = pa.ProvinceId, DistrictId = pa.DistrictId, SubDistrictId = pa.SubDistrictId, PostalCodeId = pa.PostalCodeId, Mobile = pa.Mobile1, FaceBookId = s.FacebookId, LineId = s.LineId, InstargramId = s.InstargramId, Vision = s.Vision, TimZoneId = s.TimZoneId, IsActive = s.IsActive }).FirstOrDefault();
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AddNewShopInfo(ShopInfoModel model)
        {
            try
            {
                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities(CurrentUserId))
                {
                    OStore.Data.EF.Shop shop = new OStore.Data.EF.Shop() { ShortName = model.ShortName, LongName = model.LongName, DNS = model.DNS, Vision = model.Vision, FacebookId = model.FaceBookId, LineId = model.LineId, InstargramId = model.InstargramId, IsActive = model.IsActive, TimZoneId = model.TimZoneId, CreateDate = DateTime.Now };

                    OStore.Data.EF.Person person = new OStore.Data.EF.Person() { Firstname = model.ShortName, Lastname = model.LongName, Mobile1 = model.Mobile, Email1 = model.Email, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now };
                    OStore.Data.EF.PersonAddress address = new OStore.Data.EF.PersonAddress() { AddressTypeId = 1, FirstName = model.ShortName, LastName = model.LongName, AddressLine1 = model.AddressLine01, ProvinceId = model.ProvinceId, DistrictId = model.DistrictId, SubDistrictId = model.SubDistrictId, PostalCodeId = model.PostalCodeId, Mobile1 = model.Mobile, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now };

                    person.PersonMapTypes.Add(new OStore.Data.EF.PersonMapType() { PersonTypeId = 1, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });

                    person.PersonAddresses.Add(address);
                    shop.People.Add(person);

                    context.DBEntry(shop, System.Data.Entity.EntityState.Added);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateShopInfo(ShopInfoModel model)
        {
            try
            {
                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities(CurrentUserId))
                {
                    using (System.Data.Entity.DbContextTransaction tr = context.Database.BeginTransaction())
                    {
                        OStore.Data.EF.Shop shop = context.Shops.Where(s => s.Id == model.Id).FirstOrDefault();
                        if (shop == null)
                            throw new Exception("Invalid shop Id.");

                        shop.ShortName = model.ShortName;
                        shop.LongName = model.LongName;
                        shop.DNS = model.DNS;
                        shop.Vision = model.Vision;
                        shop.FacebookId = model.FaceBookId;
                        shop.LineId = model.LineId;
                        shop.InstargramId = model.InstargramId;
                        shop.IsActive = model.IsActive;
                        shop.TimZoneId = model.TimZoneId;
                        shop.UpdateBy = CurrentUserId;
                        shop.UpdateDate = DateTime.Now;

                        OStore.Data.EF.Person person = shop.People.Where(p => p.Id == p.PersonMapTypes.Where(t => t.PersonTypeId == 1).Select(t => t.PersonId).FirstOrDefault()).FirstOrDefault();
                        if (person != null)
                        {
                            person.Firstname = model.ShortName;
                            person.Lastname = model.LongName;
                            person.Mobile1 = model.Mobile;
                            person.Email1 = model.Email;
                            person.IsActive = model.IsActive;
                            person.UpdateBy = CurrentUserId;
                            person.UpdateDate = DateTime.Now;
                            OStore.Data.EF.PersonMapType personType = person.PersonMapTypes.Where(t => t.PersonTypeId == 1).FirstOrDefault();
                            if (personType != null)
                            {
                                personType.IsActive = model.IsActive;
                                personType.UpdateBy = CurrentUserId;
                                personType.UpdateDate = DateTime.Now;
                            }
                            else
                            {
                                person.PersonMapTypes.Add(new OStore.Data.EF.PersonMapType() { PersonId = person.Id, PersonTypeId = 1, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            }

                            OStore.Data.EF.PersonAddress address = person.PersonAddresses.Where(a => a.AddressTypeId == 1).FirstOrDefault();
                            if (address != null)
                            {
                                address.FirstName = model.ShortName;
                                address.LastName = model.LongName;
                                address.AddressLine1 = model.AddressLine01;
                                address.ProvinceId = model.ProvinceId;
                                address.DistrictId = model.DistrictId;
                                address.SubDistrictId = model.SubDistrictId;
                                address.PostalCodeId = model.PostalCodeId;
                                address.Mobile1 = model.Mobile;
                                address.IsActive = model.IsActive;
                                address.UpdateBy = CurrentUserId;
                                address.UpdateDate = DateTime.Now;
                            }
                            else
                            {
                                person.PersonAddresses.Add(new OStore.Data.EF.PersonAddress() { PersonId = person.Id, AddressTypeId = 1, FirstName = model.ShortName, LastName = model.LongName, AddressLine1 = model.AddressLine01, ProvinceId = model.ProvinceId, DistrictId = model.DistrictId, SubDistrictId = model.SubDistrictId, PostalCodeId = model.PostalCodeId, Mobile1 = model.Mobile, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            }
                        }
                        else
                        {
                            person = new OStore.Data.EF.Person() { Firstname = model.ShortName, Lastname = model.LongName, Mobile1 = model.Mobile, Email1 = model.Email, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now };
                            OStore.Data.EF.PersonAddress address = new OStore.Data.EF.PersonAddress() { AddressTypeId = 1, FirstName = model.ShortName, LastName = model.LongName, AddressLine1 = model.AddressLine01, ProvinceId = model.ProvinceId, DistrictId = model.DistrictId, SubDistrictId = model.SubDistrictId, PostalCodeId = model.PostalCodeId, Mobile1 = model.Mobile, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now };

                            person.PersonMapTypes.Add(new OStore.Data.EF.PersonMapType() { PersonTypeId = 1, IsActive = model.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });

                            person.PersonAddresses.Add(address);
                            shop.People.Add(person);
                        }

                        context.DBEntry(shop, System.Data.Entity.EntityState.Modified);
                        context.SaveChanges();
                        tr.Commit();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
