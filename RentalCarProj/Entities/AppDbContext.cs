using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProj.Entities
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb; Database=SegoProjDb;Integrated Security=True;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<CarEntity> Cars { get; set; }
        public DbSet<RentEntity> Rents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = "Admin123", Name = "Admin Admin", Email = "admin@admin.com", Password = "Admin1234", RentedCars = 20000 }
            );


/*            modelBuilder.Entity<RentEntity>()
                    .HasOne(r => r.Car)
                    .WithMany()
                    .HasForeignKey(r => r.CarId)
                    .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RentEntity>()
                    .HasOne(r => r.RentUser)
                    .WithMany()
                    .HasForeignKey(r => r.RentUserId)
                    .OnDelete(DeleteBehavior.Cascade);
*/
            base.OnModelCreating(modelBuilder);
        }
    }
}
