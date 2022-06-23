using eShopOnContainers.Core.Services.MyHome;
using Xunit;

namespace eShopOnContainers.UnitTests.MyServices
{
    public class MyHomeServiceTests
    {
        [Fact]
        public void GetFakeBannerCountTest()
        {
            var myHomeMockService = new MyHomeMockService();
            var banners = myHomeMockService.GetBanners();

            Assert.Equal(10, banners.Count);
        }
    }
}