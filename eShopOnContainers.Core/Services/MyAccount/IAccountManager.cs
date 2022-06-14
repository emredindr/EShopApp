using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyAccount;

namespace eShopOnContainers.Core.Services.MyAccount
{
    public interface IAccountManager
    {
        List<AccountPageItem> GetAccountPageItems();
        List<AccountPageItemLogined> GetAccountPageItemsLogined();
    }
}
