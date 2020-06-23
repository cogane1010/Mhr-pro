using Mhr.Core.Models;
using Mhr.Data.Configurations;
using Mhr.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mhr.Data
{
    public class MhrDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public MhrDbContext(DbContextOptions<MhrDbContext> options)
            : base(options)
        { }

        public MhrDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .ApplyConfiguration(new MusicConfiguration());

            builder
                .ApplyConfiguration(new ArtistConfiguration());

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = Core.Roles.Admin, NormalizedName = Core.Roles.Admin.ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = Core.Roles.Employee, NormalizedName = Core.Roles.Employee.ToUpper() });
        }
    }
}
