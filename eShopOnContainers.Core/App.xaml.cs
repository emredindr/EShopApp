﻿using System.Threading.Tasks;
using eShopOnContainers.Core.MyViews;
using eShopOnContainers.Core.Services.Dependency;
using eShopOnContainers.Core.Services.Settings;
using Xamarin.Forms;

namespace eShopOnContainers
{
    public partial class App : IApplicationController
    {
        ISettingsService _settingsService;

        public App()
        {
            InitializeComponent();

            Startup.Init();
            //InitApp();
            MainPage = new NavigationPage(new HomeTabbedPage()) { BarBackgroundColor = Color.White };
            //MainPage = new AppShell ();

        }

        private void InitApp()
        {
            //_settingsService = ViewModelLocator.Resolve<ISettingsService>();
            //if (!_settingsService.UseMocks)
            //    ViewModelLocator.UpdateDependencies(_settingsService.UseMocks);
        }

        private void InitNavigation()
        {
            //var navigationService = ViewModelLocator.Resolve<INavigationService>();
            //return navigationService.InitializeAsync();
        }

        protected override async void OnStart()
        {
            //base.OnStart();

            //if (_settingsService.AllowGpsLocation && !_settingsService.UseFakeLocation)
            //{
            //    await GetGpsLocation();
            //}
            //if (!_settingsService.UseMocks && !string.IsNullOrEmpty(_settingsService.AuthAccessToken))
            //{
            //    await SendCurrentLocation();
            //}

            //OnResume();
        }

        protected override void OnSleep()
        {
            //SetStatusBar();
            //RequestedThemeChanged -= App_RequestedThemeChanged;
        }

        protected override void OnResume()
        {
        //    SetStatusBar();
        //    RequestedThemeChanged += App_RequestedThemeChanged;
        }

        private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            //MainThread.BeginInvokeOnMainThread(() =>
            //{
            //    SetStatusBar();
            //});
        }

        void SetStatusBar()
        {
            //var nav = Current.MainPage as NavigationPage;

            //var e = DependencyService.Get<ITheme>();
            //if (Current.RequestedTheme == OSAppTheme.Dark)
            //{
            //    e?.SetStatusBarColor(Color.Black, false);
            //    if (nav != null)
            //    {
            //        nav.BarBackgroundColor = Color.Black;
            //        nav.BarTextColor = Color.White;
            //    }
            //}
            //else
            //{
            //    e?.SetStatusBarColor(Color.White, true);
            //    if (nav != null)
            //    {
            //        nav.BarBackgroundColor = Color.White;
            //        nav.BarTextColor = Color.Black;
            //    }
            //}
        }

        private async Task GetGpsLocation()
        {
            //try
            //{
            //    var request = new GeolocationRequest (GeolocationAccuracy.High);
            //    var location = await Geolocation.GetLocationAsync (request, CancellationToken.None).ConfigureAwait(false);

            //    if (location != null)
            //    {
            //        _settingsService.Latitude = location.Latitude.ToString ();
            //        _settingsService.Longitude = location.Longitude.ToString ();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (ex is FeatureNotEnabledException || ex is FeatureNotEnabledException || ex is PermissionException)
            //    {
            //        _settingsService.AllowGpsLocation = false;
            //    }

            //    // Unable to get location
            //    Debug.WriteLine(ex);
            //}
        }

        private async Task SendCurrentLocation()
        {
            //var location = new Core.Models.Location.Location
            //{
            //    Latitude = double.Parse(_settingsService.Latitude, CultureInfo.InvariantCulture),
            //    Longitude = double.Parse(_settingsService.Longitude, CultureInfo.InvariantCulture)
            //};

            //var locationService = ViewModelLocator.Resolve<ILocationService>();
            //await locationService.UpdateUserLocation(location, _settingsService.AuthAccessToken);
        }
    }
}