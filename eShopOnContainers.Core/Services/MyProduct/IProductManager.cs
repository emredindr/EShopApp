using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyProduct;

namespace eShopOnContainers.Core.Services.MyProduct
{
    public interface IProductManager
    {
        List<Product> GetProducts();
        List<Product> GetProducts(ProductFilter productFilter);
        Product GetProductById(int productId);
    }
}
