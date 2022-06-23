using System.Collections.Generic;
using System.Linq;
using eShopOnContainers.Core.Models.MyProduct;
using eShopOnContainers.Core.Services.MyRestService;

namespace eShopOnContainers.Core.Services.MyProduct
{
    public class ProductService : IProductService
    {
        private readonly RequestProvider<List<Product>> _restServiceProductManager;
        public ProductService()
        {
            _restServiceProductManager = new RequestProvider<List<Product>>();
        }
        public List<Product> GetProducts()
        {
            return _restServiceProductManager.GetServiceResponse(MyGlobalSettings.Product);
        }

        public List<Product> GetProducts(ProductFilter productFilter)
        {
            var allProduct = _restServiceProductManager.GetServiceResponse(MyGlobalSettings.Product);

            if (productFilter.MainCategoryId.HasValue)
                allProduct = allProduct.Where(x => x.CategoryId == productFilter.MainCategoryId.Value).ToList();

            if (productFilter.SubCategoryId.HasValue)
                allProduct = allProduct.Where(x => x.SubCategoryId == productFilter.SubCategoryId.Value).ToList();

            if (productFilter.SubOfSubCategoryId.HasValue)
                allProduct = allProduct.Where(x => x.SubOfSubCategoryId == productFilter.SubOfSubCategoryId.Value).ToList();



            return allProduct;
        }

        public Product GetProductById(int productId)
        {
            var allProduct = _restServiceProductManager.GetServiceResponse(MyGlobalSettings.Product);
            var result = allProduct.FirstOrDefault(x => x.Id == productId);
            return result;
        }
    }
}
