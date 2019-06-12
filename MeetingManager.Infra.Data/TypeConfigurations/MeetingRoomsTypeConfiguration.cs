using MeetingManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManager.Infra.Data.TypeConfigurations
{
    public class MeetingRoomsTypeConfiguration : IEntityTypeConfiguration<MeetingRooms>
    {
        public void Configure(EntityTypeBuilder<MeetingRooms> builder)
        {
            builder
                .ToTable("meetingRooms", "public");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int");

            builder
                .Property(e => e.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(40)");

            builder
                .Property(e => e.Floor)
                .HasColumnName("floor")
                .HasColumnType("int");

            builder
                .Property(e => e.PeopleLimit)
                .HasColumnName("peoplelimit")
                .HasColumnType("int");

            builder
                .Property(e => e.HasTelevision)
                .HasColumnName("television")
                .HasColumnType("boolean");

            builder
                .Property(e => e.HasWiredNetwork)
                .HasColumnName("wirednetwork")
                .HasColumnType("boolean");

            builder
                .Property(e => e.HasProjector)
                .HasColumnName("projector")
                .HasColumnType("boolean");
        }
    }
}
