using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyHome;
using eShopOnContainers.Core.Services.MyHome;

namespace eShopOnContainers.Core.MyViewModels
{
    public class HomeViewModel
    {
        public List<Banner> Banners { get; set; }

        public HomeViewModel(IHomeService homeService)
        {
            Banners = homeService.GetBanners();
        }
    }
}
