using System;
using eShopOnContainers.Core.Models.MyAccount;
using eShopOnContainers.Core.MyViewModels;
using eShopOnContainers.Core.MyViews.HomeTabbedPageViews.AccountDetailPageViews;
using eShopOnContainers.Core.Services.Dependency;
using Firebase.Auth;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.MyViews.HomeTabbedPageViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyAccountPage : ContentPage
    {
        public string WebAPIKey = "AIzaSyArAkGi_opXahEVvwh11P9RjfLpXeSNAXU";
        public MyAccountPage()
        {
            InitializeComponent();
            RefreshCurrentPage();
            GetProfileInformationAndRefreshToken();
            var accountManager = Startup.ServiceProvider.GetService<Account>();
            accountListView.ItemsSource = accountManager.AllAccountPageItems;
            accountListViewLogined.ItemsSource = accountManager.AllAccountPageItemsLogined;
            accountListViewLoginedScrol.ItemsSource = accountManager.AllAccountPageItems;
        }
        public void RefreshCurrentPage()
        {
            if (CheckUserSession())
            {
                btnLogin.IsVisible = false;
                btnRegister.IsVisible = false;
                logoutStackLayout.IsVisible = false;
                loginedStackLayout.IsVisible = true;
                userInfo.Text = GetUserEmail();
            }
            else
            {
                btnLogin.IsVisible = true;
                btnRegister.IsVisible = true;
                logoutStackLayout.IsVisible = true;
                loginedStackLayout.IsVisible = false;
                userInfo.Text = "Hesabım";
            }
        }
        public bool CheckUserSession()
        {
            var state = Preferences.Get("MyFirebaseLoginControl", false);
            return state;
        }

        public string GetUserEmail()
        {
            var state = Preferences.Get("MyFirebaseLoginedUserEmail", "");
            return state;
        }
        public void OnSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lstView = (ListView)sender;
            lstView.SelectedItem = null;

            AccountPageItem selected = (AccountPageItem)e.SelectedItem;
            if (selected.Id == 1)
            {

                Browser.OpenAsync(selected.Url, BrowserLaunchMode.External);
            }
        }

        async private void GetProfileInformationAndRefreshToken()
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIKey));
            try
            {
                var savedfirebaseauth = JsonConvert.DeserializeObject<FirebaseAuth>(Preferences.Get("MyFirebaseRefreshToken", ""));
                if (savedfirebaseauth != null)
                {
                    var RefreshedContent = await authProvider.RefreshAuthAsync(savedfirebaseauth);
                    Preferences.Set("MyFirebaseRefreshToken", JsonConvert.SerializeObject(RefreshedContent));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                await App.Current.MainPage.DisplayAlert("Alert", "Oh no !  Token expired", "OK");
            }
        }
        public void OnSelectedLogin(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            ListView lstView = (ListView)sender;
            lstView.SelectedItem = null;

            AccountPageItemLogined selected = (AccountPageItemLogined)e.SelectedItem;
            if (selected.Id == 8)
            {
                Preferences.Remove("MyFirebaseRefreshToken");
                Preferences.Remove("MyFirebaseLoginControl");
                Navigation.PushAsync(new MyAccountPage());
                 RefreshCurrentPage();
            }
            else
            {
            }
        }
        private void LoginOnClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
        private void RegisterOnClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

    }
}
