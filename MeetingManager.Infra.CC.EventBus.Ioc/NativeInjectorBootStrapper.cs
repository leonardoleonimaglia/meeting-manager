using Microsoft.Extensions.DependencyInjection;

namespace MeetingManager.Infra.CC.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            InfraDataModule.RegisterServices(services);
        }
    }
}
