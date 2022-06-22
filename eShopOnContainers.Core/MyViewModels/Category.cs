using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyCategory;
using eShopOnContainers.Core.Services.MyCategory;

namespace eShopOnContainers.Core.MyViewModels
{
    public class Category
    {
        public List<MainCategory> MainCategories { get; set; }
        public List<SubCategory> BabyPopulerCategories { get; set; }
        public List<SubCategory> ElektronicPopulerCategories { get; set; }
        public Category(ICategoryService categoryManager)
        {
            MainCategories = categoryManager.GetMainCategories();
            ElektronicPopulerCategories = categoryManager.GetElektronicPopulerCategories();
            BabyPopulerCategories = categoryManager.GetBabyPopulerCategories();
        }
    }
}
