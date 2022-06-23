using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyHome;
using eShopOnContainers.Core.Services.MyRestService;

namespace eShopOnContainers.Core.Services.MyHome
{
    public class HomeService : IHomeService
    {
        private readonly RequestProvider<List<Banner>> _restServiceBannerManager;
        public HomeService()
        {
            _restServiceBannerManager = new RequestProvider<List<Banner>>();
        }
        public List<Banner> GetBanners()
        {
            return _restServiceBannerManager.GetServiceResponse(MyGlobalSettings.Banner);
        }
    }
}
