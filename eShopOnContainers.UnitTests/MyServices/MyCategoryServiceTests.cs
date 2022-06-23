using System;
using System.Collections.Generic;
using System.Text;
using eShopOnContainers.Core.Services.MyCategory;
using Xunit;

namespace eShopOnContainers.UnitTests.MyServices
{
    public class MyCategoryServiceTests
    {
        [Fact]
        public void GetFakeMainCategoryCountTest()
        {
            var categoryMockService = new CategoryMockService();
            var mainCategories = categoryMockService.GetMainCategories();

            Assert.Equal(10, mainCategories.Count);
        }
        
        [Fact]
        public void GetFakeSubegoryCountTest()
        {
            var categoryMockService = new CategoryMockService();
            var subCategories = categoryMockService.GetSubCategories();

            Assert.Equal(54, subCategories.Count);
        }
        
        [Fact]
        public void GetFakeSubOfSubCountTest()
        {
            var categoryMockService = new CategoryMockService();
            var subOfSubCategories = categoryMockService.GetSubOfSubCategories();

            Assert.Equal(245, subOfSubCategories.Count);
        }
    }
}
