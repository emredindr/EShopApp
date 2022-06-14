using eShopOnContainers.Core.MyViewModels;
using eShopOnContainers.Core.Services.MyAccount;
using eShopOnContainers.Core.Services.MyCategory;
using eShopOnContainers.Core.Services.MyHome;
using eShopOnContainers.Core.Services.MyProduct;
using Microsoft.Extensions.DependencyInjection;

namespace eShopOnContainers.Core.Services.Dependency
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountManager, AccountManager>();
            services.AddScoped<IHomeManager, HomeManager>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IProductManager, ProductManager>();

            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            services.AddTransient<Home>();
            services.AddTransient<Category>();
            services.AddTransient<Account>();
            services.AddTransient<Product>();


            return services;
        }
    }
}
