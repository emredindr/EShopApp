using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyAccount;
using eShopOnContainers.Core.Services.MyAccount;

namespace eShopOnContainers.Core.MyViewModels
{
    public class Account
    {
        public List<AccountPageItem> AllAccountPageItems { get; set; }
        public List<AccountPageItemLogined> AllAccountPageItemsLogined { get; set; }
        public Account(IAccountManager accountManager)
        {
            AllAccountPageItems = accountManager.GetAccountPageItems();
            AllAccountPageItemsLogined = accountManager.GetAccountPageItemsLogined();
        }
    }
}
