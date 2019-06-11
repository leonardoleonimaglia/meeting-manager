using MeetingManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeetingManager.Infra.Data.TypeConfigurations
{
    public class UsersTypeConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder
                .ToTable("Users", "public");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("Id")
                .HasColumnType("int");

            builder
                .Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("varchar(40)");

            builder
                .Property(e => e.LastName)
                .HasColumnName("LastName")
                .HasColumnType("varchar(40)");

            builder
                .Property(e => e.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(80)");

            builder
                .Property(e => e.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar(80)");

            builder
                .Property(e => e.ActivationDate)
                .HasColumnName("ActivationDate")
                .HasColumnType("date");

            builder
                .Property(e => e.CreatedDate)
                .HasColumnName("CreatedDate")
                .HasColumnType("date");
        }
    }
}
