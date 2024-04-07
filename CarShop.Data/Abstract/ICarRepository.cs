using CarShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Data.Abstract
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        void DeleteCar(int id);

    }
}
