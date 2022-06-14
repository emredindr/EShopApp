using eShopOnContainers.Core.Models.Common;

namespace eShopOnContainers.Core.Models.MyProduct
{
    public class ProductFilter : BaseEntity
    {
        public int? MainCategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? SubOfSubCategoryId { get; set; }
        public string Title { get; set; }
    }
}
