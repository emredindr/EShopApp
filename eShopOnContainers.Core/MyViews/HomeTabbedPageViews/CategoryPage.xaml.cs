using eShopOnContainers.Core.Models.MyCategory;
using eShopOnContainers.Core.MyViewModels;
using eShopOnContainers.Core.MyViews.HomeTabbedPageViews.CategoryDetailPageViews;
using eShopOnContainers.Core.Services.Dependency;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.MyViews.HomeTabbedPageViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
            var categoryManager = Startup.ServiceProvider.GetService<Category>();
            categoryListView.ItemsSource = categoryManager.MainCategories;
        }

        private void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lstView = (ListView)sender;
            lstView.SelectedItem = null;

            MainCategory selected = (MainCategory)e.SelectedItem;
            if (selected != null && selected.Id > 0)
            {
              //  Page Page = new SubCategoryPage(selected);
               Navigation.PushAsync(new SubCategoryPage(selected));
            }
        }
    }
}