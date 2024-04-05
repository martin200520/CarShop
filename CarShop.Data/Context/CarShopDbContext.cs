using CarShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Data.Context
{
    public class CarShopDbContext : DbContext
    {
        public CarShopDbContext(DbContextOptions<CarShopDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Brand = "Toyota", Model = "Camry", Year = 2020, Price = 25000, HorsePower = 203 },
                new Car { Id = 2, Brand = "Honda", Model = "Accord", Year = 2021, Price = 27000, HorsePower = 192 },
                new Car { Id = 3, Brand = "Chevrolet", Model = "Malibu", Year = 2019, Price = 28000, HorsePower = 160 },
                new Car { Id = 4, Brand = "Ford", Model = "Fusion", Year = 2018, Price = 26000, HorsePower = 175 },
                new Car { Id = 5, Brand = "Hyundai", Model = "Sonata", Year = 2020, Price = 24500, HorsePower = 191 },
                new Car { Id = 6, Brand = "Kia", Model = "Optima", Year = 2019, Price = 25500, HorsePower = 185 },
                new Car { Id = 7, Brand = "Nissan", Model = "Altima", Year = 2021, Price = 27500, HorsePower = 188 },
                new Car { Id = 8, Brand = "Mazda", Model = "Mazda6", Year = 2020, Price = 26500, HorsePower = 187 },
                new Car { Id = 9, Brand = "Subaru", Model = "Legacy", Year = 2019, Price = 27000, HorsePower = 182 },
                new Car { Id = 10, Brand = "Volkswagen", Model = "Passat", Year = 2021, Price = 29000, HorsePower = 174 },
                new Car { Id = 11, Brand = "BMW", Model = "3 Series", Year = 2020, Price = 40000, HorsePower = 255 },
                new Car { Id = 12, Brand = "Mercedes-Benz", Model = "C-Class", Year = 2019, Price = 42000, HorsePower = 255 },
                new Car { Id = 13, Brand = "Audi", Model = "A4", Year = 2021, Price = 38000, HorsePower = 201 },
                new Car { Id = 14, Brand = "Lexus", Model = "ES", Year = 2020, Price = 39000, HorsePower = 203 },
                new Car { Id = 15, Brand = "Tesla", Model = "Model 3", Year = 2021, Price = 48000, HorsePower = 283 }
            );
        }

        public DbSet<Car> cars { get; set; }
    }
}
