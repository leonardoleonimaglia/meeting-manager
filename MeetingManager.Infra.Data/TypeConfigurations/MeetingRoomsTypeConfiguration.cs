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
                .ToTable("MeetingRooms", "public");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");

            builder
                .Property(e => e.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar(40)");

            builder
                .Property(e => e.Floor)
                .HasColumnName("Floor")
                .HasColumnType("int");

            builder
                .Property(e => e.PeopleLimit)
                .HasColumnName("PeopleLimit")
                .HasColumnType("int");

            builder
                .Property(e => e.HasTelevision)
                .HasColumnName("Television")
                .HasColumnType("boolean");

            builder
                .Property(e => e.HasWiredNetwork)
                .HasColumnName("WiredNetwork")
                .HasColumnType("boolean");

            builder
                .Property(e => e.HasProjector)
                .HasColumnName("Projector")
                .HasColumnType("boolean");
        }
    }
}
