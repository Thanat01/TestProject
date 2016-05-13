using PM.Business.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class Customer : PM.Business.Base.PaymentBase
    {
        public Customer(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.CustomerInfoModel> GetCustomers()
        {
            try
            {
                List<OStore.Model.CustomerInfoModel> customers = new List<OStore.Model.CustomerInfoModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    customers = (from au in context.AuthorizeUsers
                                 join p in context.People on au.PersonId equals p.Id
                                 join pmt in context.PersonMapTypes on p.Id equals pmt.PersonId
                                 join pa in context.PersonAddresses on p.Id equals pa.PersonId
                                 where p.ShopId == CurrentShopId && pmt.PersonTypeId == 3 && pa.AddressTypeId == 1 && p.IsActive && pmt.IsActive && pa.IsActive
                                 select new OStore.Model.CustomerInfoModel { Id = au.Id, Firstname = p.Firstname, Lastname = p.Lastname, Mobile = p.Mobile1, Email = p.Email1, Address = pa.AddressLine1, ProvinceId = pa.ProvinceId, DistrictId = pa.DistrictId, SubDistrictId = pa.SubDistrictId, PostalCodeId = pa.PostalCodeId }).ToList();
                }

                return customers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateCustomers(List<OStore.Model.CustomerInfoModel> customers)
        {
            try
            {
                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities(CurrentUserId))
                {
                    customers.ForEach(customer =>
                    {
                        OStore.Data.EF.Person person = context.People.Where(p => p.ShopId == CurrentShopId && p.Firstname == customer.Firstname && p.Lastname == customer.Lastname && p.Mobile1 == customer.Mobile).FirstOrDefault();
                        if (person == null)
                        {
                            person = new OStore.Data.EF.Person() { ShopId = CurrentShopId, Firstname = customer.Firstname, Lastname = customer.Lastname, Mobile1 = customer.Mobile, Email1 = customer.Email, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now };
                            person.PersonMapTypes.Add(new OStore.Data.EF.PersonMapType() { PersonTypeId = 3, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            person.PersonAddresses.Add(new OStore.Data.EF.PersonAddress() { AddressTypeId = 1, FirstName = customer.Firstname, LastName = customer.Lastname, Mobile1 = customer.Mobile, AddressLine1 = customer.Address, ProvinceId = customer.ProvinceId, DistrictId = customer.DistrictId, SubDistrictId = customer.SubDistrictId, PostalCodeId = customer.PostalCodeId, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            person.AuthorizeUsers.Add(new OStore.Data.EF.AuthorizeUser() { ShopId = CurrentShopId, Username = customer.Email, Password = customer.Mobile, Firstname = customer.Firstname, Lastname = customer.Lastname, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });

                            context.DBEntry(person, System.Data.Entity.EntityState.Added);
                        }
                        else
                        {
                            person.Firstname = customer.Firstname; person.Lastname = customer.Lastname; person.Mobile1 = customer.Mobile; person.Email1 = customer.Email; person.IsActive = customer.IsActive; person.UpdateBy = CurrentUserId; person.UpdateDate = DateTime.Now;

                            OStore.Data.EF.PersonMapType personType = person.PersonMapTypes.Where(t => t.PersonTypeId == 3).FirstOrDefault();
                            if (personType == null)
                                person.PersonMapTypes.Add(new OStore.Data.EF.PersonMapType() { PersonTypeId = 3, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            else
                                personType.IsActive = customer.IsActive; personType.UpdateBy = CurrentUserId; personType.UpdateDate = DateTime.Now;

                            OStore.Data.EF.PersonAddress address = person.PersonAddresses.Where(a => a.AddressTypeId == 1).FirstOrDefault();
                            if (address == null)
                                person.PersonAddresses.Add(new OStore.Data.EF.PersonAddress() { AddressTypeId = 1, FirstName = customer.Firstname, LastName = customer.Lastname, Mobile1 = customer.Mobile, AddressLine1 = customer.Address, ProvinceId = customer.ProvinceId, DistrictId = customer.DistrictId, SubDistrictId = customer.SubDistrictId, PostalCodeId = customer.PostalCodeId, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            else
                                address.FirstName = customer.Firstname; address.LastName = customer.Lastname; address.Mobile1 = customer.Mobile; address.AddressLine1 = customer.Address; address.ProvinceId = customer.ProvinceId; address.DistrictId = customer.DistrictId; address.SubDistrictId = customer.SubDistrictId; address.PostalCodeId = customer.PostalCodeId; address.IsActive = customer.IsActive; address.UpdateBy = CurrentUserId; address.UpdateDate = DateTime.Now;

                            OStore.Data.EF.AuthorizeUser user = person.AuthorizeUsers.FirstOrDefault();
                            if (user == null)
                                person.AuthorizeUsers.Add(new OStore.Data.EF.AuthorizeUser() { ShopId = CurrentShopId, Username = customer.Email, Password = customer.Mobile, Firstname = customer.Firstname, Lastname = customer.Lastname, IsActive = customer.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now });
                            else
                                user.Firstname = customer.Firstname; user.Lastname = customer.Lastname; user.IsActive = customer.IsActive; user.UpdateBy = CurrentUserId; user.UpdateDate = DateTime.Now;

                            context.DBEntry(person, System.Data.Entity.EntityState.Modified);
                        }

                    });

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
