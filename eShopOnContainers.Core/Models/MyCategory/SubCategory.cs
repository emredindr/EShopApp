using eShopOnContainers.Core.Models.Common;

namespace eShopOnContainers.Core.Models.MyCategory
{
    public class SubCategory : BaseEntity
    {
        public int SubId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public bool IsPopularForElecktronic { get; set; }
        public bool IsPopularForBaby { get; set; }
        public string ImageSource { get; set; }
    }
}
