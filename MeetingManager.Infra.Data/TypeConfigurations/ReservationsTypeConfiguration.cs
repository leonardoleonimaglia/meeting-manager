using MeetingManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManager.Infra.Data.TypeConfigurations
{
    public class ReservationsTypeConfiguration : IEntityTypeConfiguration<Reservations>
    {
        public void Configure(EntityTypeBuilder<Reservations> builder)
        {
            builder
                .ToTable("Reservations", "public");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");

            builder
                .Property(e => e.WhoBooked)
                .HasColumnName("WhoBooked")
                .HasColumnType("int");

            builder
                .Property(e => e.MeetingRoomId)
                .HasColumnName("MeetingRoomId")
                .HasColumnType("int");

            builder
                .Property(e => e.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("date");

            builder
                .Property(e => e.EndDate)
                .HasColumnName("EndDate")
                .HasColumnType("date");
        }
    }
}
