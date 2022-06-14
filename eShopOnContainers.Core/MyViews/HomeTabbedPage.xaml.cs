using eShopOnContainers.Core.MyViews.HomeTabbedPageViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.MyViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();
            Children.Add(new HomePage());
            Children.Add(new CategoryPage());
            Children.Add(new MyBasketPage());
            Children.Add(new MyAccountPage());
        }
    }
}