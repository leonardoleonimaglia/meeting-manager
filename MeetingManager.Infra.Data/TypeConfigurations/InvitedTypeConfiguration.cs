using MeetingManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManager.Infra.Data.TypeConfigurations
{
    public class InvitedTypeConfiguration : IEntityTypeConfiguration<Invited>
    {
        public void Configure(EntityTypeBuilder<Invited> builder)
        {
            builder
                .ToTable("Invited", "public");

            builder
                .HasKey(e => e.ReservationId);

            builder
                .HasKey(e => e.UserId);

            builder
                .Property(e => e.ReservationId)
                .HasColumnName("ReservationId")
                .HasColumnType("int");

            builder
                .Property(e => e.UserId)
                .HasColumnName("UserId")
                .HasColumnType("int");
        }
    }
}

