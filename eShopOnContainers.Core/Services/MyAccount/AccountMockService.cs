using System;
using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyAccount;

namespace eShopOnContainers.Core.Services.MyAccount
{
    public class AccountMockService : IAccountService
    {
        public List<AccountPageItem> GetAccountPageItems()
        {
            List<AccountPageItem> items = new List<AccountPageItem>()
            {
                new AccountPageItem()
                {
                   Id = 1,
                   Title = "HGS Yükle",
                   Url="https://play.google.com/store/apps/details?id=tr.com.ulkem.hgs&hl=tr&gl=US",
                }
                ,new AccountPageItem()
                {
                   Id = 2,
                   Title = "Kanpanyalar",
                },
                new AccountPageItem()
                {
                   Id = 3,
                   Title = "Günün Fırsatları",
                },
                new AccountPageItem()
                {
                   Id = 4,
                   Title = "Hediye Bul",
                },
                new AccountPageItem()
                {
                   Id = 5,
                   Title = "Mağazalar",
                },
                new AccountPageItem()
                {
                   Id = 6,
                   Title = "Banka Hesapları",
                },
                new AccountPageItem()
                {
                   Id = 7,
                   Title = "Yardım",
                }
            };
            return items;
        }

        public List<AccountPageItemLogined> GetAccountPageItemsLogined()
        {
            throw new NotImplementedException();
        }
    }
}
