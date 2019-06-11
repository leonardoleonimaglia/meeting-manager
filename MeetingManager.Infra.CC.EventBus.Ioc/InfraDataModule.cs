using MeetingManager.Domain.Interfaces;
using MeetingManager.Infra.Data;
using MeetingManager.Infra.Data.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingManager.Infra.CC.Ioc
{
    public class InfraDataModule
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUnitOfWorkFactory, UnitOfWorkFactory>();

            //services.AddScoped<ICustomerRepository, CustomerRepository>();
            //services.AddScoped<ISubsidyStatusReportRepository, SubsidyStatusReportRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
