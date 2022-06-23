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
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
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
