using Domain.Interfaces.Identity;
using Domain.Interfaces.Repositories;
using Infrastructure.Identity;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IWorkerRepository, WorkerRepository>();

            services.AddScoped<IIdentityService, IdentityService>();

            return services;
        }
    }
}
