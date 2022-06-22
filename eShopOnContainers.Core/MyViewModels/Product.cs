using System.Collections.Generic;
using eShopOnContainers.Core.Services.MyProduct;

namespace eShopOnContainers.Core.MyViewModels
{
    public class Product
    {
        public List<Models.MyProduct.Product> Products { get; set; }
        public Product(IProductServices productManager)
        {
            Products = productManager.GetProducts();
        }
    }
}
