using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyProduct;

namespace eShopOnContainers.Core.Services.MyProduct
{
    public interface IProductService
    {
        List<Product> GetAllProduct();
    }
}
