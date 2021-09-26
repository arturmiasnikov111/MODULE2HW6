using Microsoft.Extensions.DependencyInjection;
using MODULE2HW6.CarsProvider;
using MODULE2HW6.Services;
using MODULE2HW6.Services.Abstractions;

namespace MODULE2HW6
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ICarProvider, CarProvider>()
                .AddTransient<ICarService, CarService>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Application>();
            start?.Run();
        }
    }
}