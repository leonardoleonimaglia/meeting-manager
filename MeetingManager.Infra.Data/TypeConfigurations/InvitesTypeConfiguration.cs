using MeetingManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManager.Infra.Data.TypeConfigurations
{
    public class InvitesTypeConfiguration : IEntityTypeConfiguration<Invites>
    {
        public void Configure(EntityTypeBuilder<Invites> builder)
        {
            builder
                .ToTable("invited", "public");

            builder
                .HasKey(e => e.ReservationId);

            builder
                .HasKey(e => e.UserId);

            builder
                .Property(e => e.ReservationId)
                .HasColumnName("reservationid")
                .HasColumnType("int");

            builder
                .Property(e => e.UserId)
                .HasColumnName("userid")
                .HasColumnType("int");
        }
    }
}

