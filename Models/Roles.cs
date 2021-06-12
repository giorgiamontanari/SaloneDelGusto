using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace SalonedelGusto.Models
{
    public class Roles : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Name = "Visitatore", NormalizedName = "VISITATORE" },
                new IdentityRole { Name = "Amministratore", NormalizedName = "AMMINISTRATORE" }
            );
        }
    }
}