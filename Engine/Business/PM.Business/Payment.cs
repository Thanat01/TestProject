using AutoMapper;
using OStore.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Business
{
    public class Payment : PM.Business.Base.PaymentBase
    {
        public Payment(int shopId, int userId) : base(shopId, userId) { }

        public List<OStore.Model.PaymentChannelInfoModel> GetPayments()
        {
            try
            {
                List<OStore.Model.PaymentChannelInfoModel> channels = new List<OStore.Model.PaymentChannelInfoModel>();

                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    List<OStore.Data.EF.ShopMapPaymentChannel> allActiveChannel = context.ShopMapPaymentChannels.Where(p => p.ShopId == CurrentShopId && p.IsActive && p.PaymentChannel.IsActive).ToList();
                    allActiveChannel.ForEach(c =>
                    {
                        OStore.Model.PaymentChannelInfoModel channel = new OStore.Model.PaymentChannelInfoModel();
                        channel = Mapper.Map(c.PaymentChannel, channel);

                        c.ShopPaymentAccounts.Where(a => a.IsActive).ToList().ForEach(a =>
                        {
                            ShopPaymentAccountModel account = new ShopPaymentAccountModel();
                            account = Mapper.Map(a, account);
                            channel.Accounts.Add(account);
                        });

                        channels.Add(channel);
                    });
                }

                return channels;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdatePayments(List<OStore.Model.PaymentChannelInfoModel> channels)
        {
            try
            {
                using (OStore.Data.EF.OStoreDBEntities context = new OStore.Data.EF.OStoreDBEntities())
                {
                    channels.ForEach(c=> {
                        OStore.Data.EF.ShopMapPaymentChannel mapChannel = context.ShopMapPaymentChannels.Where(m => m.ShopId == CurrentShopId && m.PaymentChannelId == c.Id).FirstOrDefault();
                        if (mapChannel == null)
                        {
                            mapChannel = new OStore.Data.EF.ShopMapPaymentChannel() { ShopId = CurrentShopId, PaymentChannelId = c.Id, IsActive = c.IsActive, CreateBy = CurrentUserId, CreateDate = DateTime.Now };
                            c.Accounts.ForEach(a =>
                            {
                                OStore.Data.EF.ShopPaymentAccount account = new OStore.Data.EF.ShopPaymentAccount();
                                account = Mapper.Map(a, account);
                                account.CreateBy = CurrentUserId;
                                account.CreateDate = DateTime.Now;
                                mapChannel.ShopPaymentAccounts.Add(account);
                            });

                            context.DBEntry(mapChannel, System.Data.Entity.EntityState.Added);
                        }
                        else
                        {
                            mapChannel.IsActive = c.IsActive;
                            mapChannel.UpdateBy = CurrentUserId;
                            mapChannel.UpdateDate = DateTime.Now;
                            c.Accounts.ForEach(a =>
                            {
                                OStore.Data.EF.ShopPaymentAccount account = mapChannel.ShopPaymentAccounts.Where(m => m.Id == a.Id).FirstOrDefault();
                                if(account==null)
                                {
                                    account = new OStore.Data.EF.ShopPaymentAccount();
                                    account = Mapper.Map(a, account);
                                    account.CreateBy = CurrentUserId;
                                    account.CreateDate = DateTime.Now;
                                    mapChannel.ShopPaymentAccounts.Add(account);
                                }
                                else
                                {
                                    account.IsActive = c.IsActive;
                                    account.UpdateBy = CurrentUserId;
                                    account.UpdateDate = DateTime.Now;
                                }

                            });

                            context.DBEntry(mapChannel, System.Data.Entity.EntityState.Modified);
                        }

                        context.SaveChanges();
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
