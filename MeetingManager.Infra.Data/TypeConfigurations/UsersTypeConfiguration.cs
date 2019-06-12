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
                .ToTable("users", "public");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int");

            builder
                .Property(e => e.FirstName)
                .HasColumnName("firstname")
                .HasColumnType("varchar(40)");

            builder
                .Property(e => e.LastName)
                .HasColumnName("lastname")
                .HasColumnType("varchar(40)");

            builder
                .Property(e => e.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(80)");

            builder
                .Property(e => e.Password)
                .HasColumnName("password")
                .HasColumnType("varchar(80)");

            builder
                .Property(e => e.ActivationDate)
                .HasColumnName("activationdate")
                .HasColumnType("date");

            builder
                .Property(e => e.CreatedDate)
                .HasColumnName("createddate")
                .HasColumnType("date");
        }
    }
}
