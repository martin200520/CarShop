using CarShop.Data.Abstract;
using CarShop.Data.Concrete;
using CarShop.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Add DI for CarShopDbContext
            builder.Services.AddDbContext<CarShopDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // Add DI for ICarRepository
            builder.Services.AddTransient<ICarRepository, CarRepository>(provider =>
            {
                var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;

                return new CarRepository(provider.GetRequiredService<CarShopDbContext>());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
