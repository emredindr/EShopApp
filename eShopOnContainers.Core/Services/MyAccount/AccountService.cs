using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyAccount;
using eShopOnContainers.Core.Services.MyRestService;

namespace eShopOnContainers.Core.Services.MyAccount
{
    public class AccountService : IAccountService
    {
        private readonly RequestProvider<List<AccountPageItem>> _restServiceAccountPageItemManager;
        private readonly RequestProvider<List<AccountPageItemLogined>> _restServiceAccountPageItemLoginedManager;
        public AccountService()
        {
            _restServiceAccountPageItemLoginedManager = new RequestProvider<List<AccountPageItemLogined>>();
            _restServiceAccountPageItemManager = new RequestProvider<List<AccountPageItem>>();
        }
        public List<AccountPageItem> GetAccountPageItems()
        {

            return _restServiceAccountPageItemManager.GetServiceResponse(MyGlobalSettings.AccountPageItem);

        }

        public List<AccountPageItemLogined> GetAccountPageItemsLogined()
        {

            return _restServiceAccountPageItemLoginedManager.GetServiceResponse(MyGlobalSettings.AccountPageItemLogined);
        }
    }
}
