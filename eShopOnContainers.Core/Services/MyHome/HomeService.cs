using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyHome;
using eShopOnContainers.Core.Services.MyRestService;

namespace eShopOnContainers.Core.Services.MyHome
{
    public class HomeService : IHomeService
    {
        private readonly RestServiceManager<List<Banner>> _restServiceBannerManager;
        public HomeService()
        {
            _restServiceBannerManager = new RestServiceManager<List<Banner>>();
        }
        public List<Banner> GetBanners()
        {
            return _restServiceBannerManager.GetServiceResponse(ServiceUrlConst.Banner);
        }
    }
}
