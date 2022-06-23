using System;
using System.Collections.Generic;
using System.Text;
using eShopOnContainers.Core.Services.MyAccount;
using Xunit;

namespace eShopOnContainers.UnitTests.MyServices
{
    public class MyAccountServiceTests
    {
        [Fact]
        public void GetFakeAccountPageItemsCountTest()
        {
            var accountMockService= new AccountMockService();
            var accountPageItems = accountMockService.GetAccountPageItems();

            Assert.Equal(7, accountPageItems.Count);
        }
    }
}
