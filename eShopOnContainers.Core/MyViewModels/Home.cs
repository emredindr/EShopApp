using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyHome;
using eShopOnContainers.Core.Services.MyHome;

namespace eShopOnContainers.Core.MyViewModels
{
    public class Home
    {
        public List<Banner> Banners { get; set; }

        public Home(IHomeService homeService)
        {
            Banners = homeService.GetBanners();
        }
    }
}
