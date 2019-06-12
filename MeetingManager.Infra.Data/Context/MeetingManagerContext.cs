using System;
using MeetingManager.Infra.Data.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MeetingManager.Infra.Data.Context
{
    public class MeetingManagerContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseNpgsql(GetConnectionString());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvitesTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MeetingRoomsTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationsTypeConfiguration());
        }

        private static string GetConnectionString()
        {
            var configuration = new ConfigurationBuilder().AddDockerSecrets().Build();
            var connectionString = configuration["MEETINGMANAGER"];

            Console.WriteLine(connectionString);

            return connectionString;
        }
    }
}
