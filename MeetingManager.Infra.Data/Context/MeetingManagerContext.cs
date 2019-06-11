using MeetingManager.Infra.Data.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MeetingManager.Infra.Data.Context
{
    public class MeetingManagerContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseNpgsql(GetSecret());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvitedTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingRoomsTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationsTypeConfiguration());
        }

        private static string GetSecret()
        {
            var configuration = new ConfigurationBuilder().AddDockerSecrets().Build();
            var connectionString = configuration["MEETINGMANAGER"];

            return connectionString;
        }
    }
}
