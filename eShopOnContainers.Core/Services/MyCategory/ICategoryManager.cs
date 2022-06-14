using System.Collections.Generic;
using eShopOnContainers.Core.Models.MyCategory;

namespace eShopOnContainers.Core.Services.MyCategory
{
    public interface ICategoryManager
    {
        List<MainCategory> GetMainCategories();
        List<SubCategory> GetSubCategories();
        List<SubOfSubCategory> GetSubOfSubCategories();
        List<SubCategory> GetSubCategories(MainCategory mainCategory);
        List<SubOfSubCategory> GetSubOfSubCategories(SubCategory subCategory);
        List<SubCategory> GetElektronicPopulerCategories();
        List<SubCategory> GetBabyPopulerCategories();
    }
}

