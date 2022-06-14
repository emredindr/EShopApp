using eShopOnContainers.Core.Models.Common;

namespace eShopOnContainers.Core.Models.MyBasket
{
    public class MyBasketItem : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public int MainCategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int SubOfSubCategoryId { get; set; }
        public int ProductCount { get; set; }
        public float ProductPrice { get; set; }
    }
}
