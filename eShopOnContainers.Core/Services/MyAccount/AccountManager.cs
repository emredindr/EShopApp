using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyAccount;
using eShopOnContainers.Core.Services.MyRestService;

namespace eShopOnContainers.Core.Services.MyAccount
{
    public class AccountManager : IAccountManager
    {
        private readonly RestServiceManager<List<AccountPageItem>> _restServiceAccountPageItemManager;
        private readonly RestServiceManager<List<AccountPageItemLogined>> _restServiceAccountPageItemLoginedManager;
        public AccountManager()
        {
            _restServiceAccountPageItemLoginedManager = new RestServiceManager<List<AccountPageItemLogined>>();
            _restServiceAccountPageItemManager = new RestServiceManager<List<AccountPageItem>>();
        }
        public List<AccountPageItem> GetAccountPageItems()
        {

            return _restServiceAccountPageItemManager.GetServiceResponse(ServiceUrlConst.AccountPageItem);

        }

        public List<AccountPageItemLogined> GetAccountPageItemsLogined()
        {

            return _restServiceAccountPageItemLoginedManager.GetServiceResponse(ServiceUrlConst.AccountPageItemLogined);
        }
    }
}
