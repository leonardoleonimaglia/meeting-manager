using MeetingManager.Infra.Data.Configurations;
using MeetingManager.Infra.Data.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MeetingManager.Infra.Data.Context
{
    public class MeetingManagerContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseNpgsql(MeetingManagerConnectionString.ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvitedTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingRoomsTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationsTypeConfiguration());
        }
    }
}
