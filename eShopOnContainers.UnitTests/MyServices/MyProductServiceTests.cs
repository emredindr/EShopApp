using System;
using System.Collections.Generic;
using System.Text;
using eShopOnContainers.Core.Services.MyProduct;
using Xunit;

namespace eShopOnContainers.UnitTests.MyServices
{
    public class MyProductServiceTests 
    {
        [Fact]
        public void GetFakeProductsCountTest()
        {
            var productMockService = new ProductMockService();
            var products = productMockService.GetProducts();

            Assert.Equal(114, products.Count);
        }
    }
}
