using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyAccount;

namespace eShopOnContainers.Core.Services.MyAccount
{
    public interface IAccountService
    {
        List<AccountPageItem> GetAccountPageItems();
        List<AccountPageItemLogined> GetAccountPageItemsLogined();
    }
}
