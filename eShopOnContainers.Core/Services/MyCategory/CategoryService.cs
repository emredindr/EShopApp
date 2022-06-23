using System.Collections.Generic;
using System.Linq;
using eShopOnContainers.Core.Models.MyCategory;
using eShopOnContainers.Core.Services.MyRestService;

namespace eShopOnContainers.Core.Services.MyCategory
{
    public class CategoryService : ICategoryService
    {
        private readonly RequestProvider<List<MainCategory>> _restServiceMainCategoryManager;
        private readonly RequestProvider<List<SubCategory>> _restServiceSubCategoryManager;
        private readonly RequestProvider<List<SubOfSubCategory>> _restServiceSubOfSubCategoryManager;

        public CategoryService()
        {
            _restServiceMainCategoryManager = new RequestProvider<List<MainCategory>>();
            _restServiceSubCategoryManager = new RequestProvider<List<SubCategory>>();
            _restServiceSubOfSubCategoryManager = new RequestProvider<List<SubOfSubCategory>>();
        }
        public List<MainCategory> GetMainCategories()
        {
            return _restServiceMainCategoryManager.GetServiceResponse(MyGlobalSettings.MainCategory);
        }

        public List<SubCategory> GetSubCategories()
        {
            return _restServiceSubCategoryManager.GetServiceResponse(MyGlobalSettings.SubCategory);
        }

        public List<SubOfSubCategory> GetSubOfSubCategories()
        {

            return _restServiceSubOfSubCategoryManager.GetServiceResponse(MyGlobalSettings.SubOfSubCategory);
        }

        //Bunlar dışarda kullanılan base methodlar
        public List<SubCategory> GetSubCategories(MainCategory mainCategory)
        {
            var allSubCategories = _restServiceSubCategoryManager.GetServiceResponse(MyGlobalSettings.SubCategory);
            var result = allSubCategories.Where(x => x.CategoryId == mainCategory.Id).ToList();
            return result;
        }

        public List<SubOfSubCategory> GetSubOfSubCategories(SubCategory subCategory)
        {
            var allSubOfSubCategories = _restServiceSubOfSubCategoryManager.GetServiceResponse(MyGlobalSettings.SubOfSubCategory);
            var resultSub = allSubOfSubCategories.Where(x => x.SubCategoryId == subCategory.SubId && x.CategoryId == subCategory.CategoryId).ToList();
            return resultSub;
        }



        public List<SubCategory> GetElektronicPopulerCategories()
        {
            var allSubCategories = _restServiceSubCategoryManager.GetServiceResponse(MyGlobalSettings.SubCategory);
            var result = allSubCategories.Where(x => x.IsPopularForElecktronic == true).ToList();
            return result;
        }

        public List<SubCategory> GetBabyPopulerCategories()
        {
            var allSubCategories = _restServiceSubCategoryManager.GetServiceResponse(MyGlobalSettings.SubCategory);
            var result = allSubCategories.Where(x => x.IsPopularForBaby == true).ToList();
            return result;
        }
    }
}
