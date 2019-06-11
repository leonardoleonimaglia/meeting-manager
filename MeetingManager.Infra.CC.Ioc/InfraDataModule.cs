using MeetingManager.Domain.Interfaces;
using MeetingManager.Domain.Interfaces.Repositories;
using MeetingManager.Infra.Data;
using MeetingManager.Infra.Data.Factories;
using MeetingManager.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingManager.Infra.CC.Ioc
{
    public class InfraDataModule
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkFactory, UnitOfWorkFactory>();

            services.AddScoped<IUsersRepository, UsersRepository>();
        }
    }
}
