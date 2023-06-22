using ECommerceApplication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Other service configurations

        services.AddDbContext<ECommerceDbContext>(options =>
            options.UseSqlServer("YourConnectionStringHere"));

        // Other service configurations
    }
}
