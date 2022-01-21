using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "8af10569-b018-4fe7-a380-7d6a14c70b74",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-b018-4fe7-a380-7d6a14c70b74",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@mail.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "8af10569-b018-4fe7-a380-7d6a14c70b74",
                UserId = "3b62472e-b018-4fe7-a380-7d6a14c70b74"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("63dc8fa6-b018-4fe7-a380-7d6a14c70b74"),
                CodeWord = "PageIndex",
                Title = "Main"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-b018-4fe7-a380-7d6a14c70b74"),
                CodeWord = "PageServices",
                Title = "Our services"
            });
            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-b018-4fe7-a380-7d6a14c70b74"),
                CodeWord = "PageContacts",
                Title = "Contacts"
            });
        }
    }
}
