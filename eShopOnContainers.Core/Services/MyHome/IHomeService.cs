using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyHome;

namespace eShopOnContainers.Core.Services.MyHome
{
    public interface IHomeService
    {
        List<Banner> GetBanners();
    }
}
