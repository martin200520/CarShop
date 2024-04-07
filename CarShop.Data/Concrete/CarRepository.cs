using CarShop.Data.Abstract;
using CarShop.Data.Context;
using CarShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Data.Concrete
{
    public class CarRepository : ICarRepository
    {
        private readonly CarShopDbContext _context;
        public CarRepository(CarShopDbContext context) 
        {
            _context = context;
        }
        
        public async Task AddCarAsync(Car car)
        {
            await _context.AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars()
        {
            var cars = _context.cars.ToList();
            return cars;
        }

        public Car GetCarById(int id)
        {
            Car car = _context.cars.Find(id)!;
            return car;
        }

        public async Task UpdateCarAsync(Car car)
        {
            _context.cars.Update(car);

            await _context.SaveChangesAsync();
        }
    }
}
