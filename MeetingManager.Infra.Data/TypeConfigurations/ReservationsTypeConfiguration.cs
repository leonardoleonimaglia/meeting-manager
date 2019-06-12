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
                .ToTable("reservations", "public");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int");

            builder
                .Property(e => e.WhoBooked)
                .HasColumnName("Whobooked")
                .HasColumnType("int");

            builder
                .Property(e => e.MeetingRoomId)
                .HasColumnName("meetingroomId")
                .HasColumnType("int");

            builder
                .Property(e => e.StartDate)
                .HasColumnName("startdate")
                .HasColumnType("date");

            builder
                .Property(e => e.EndDate)
                .HasColumnName("enddate")
                .HasColumnType("date");
        }
    }
}
