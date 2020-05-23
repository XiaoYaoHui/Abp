using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

namespace Acme.BookStore.Web
{
    public class Startup
    {
        private readonly IConfiguration _configration;

        public Startup(IConfiguration configration)
        {
            _configration = configration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BookStoreWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
