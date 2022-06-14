using eShopOnContainers.Core.Models.Common;

namespace eShopOnContainers.Core.Models.MyCategory
{
    public class SubOfSubCategory : BaseEntity
    {
        public int SubOfSubId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string Title { get; set; }
    }
}
