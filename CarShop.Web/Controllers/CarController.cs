using CarShop.Data.Abstract;
using CarShop.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Web.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult Index()
        {
            var cars = _carRepository.GetAllCars().ToList();
            return View(cars);
        }

        public IActionResult About(int carId)
        {
            var car = _carRepository.GetCarById(carId);
            return View(car);
        }

        public IActionResult Edit(int carId)
        {
            var car = _carRepository.GetCarById(carId);
            return View(car);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Car car)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _carRepository.UpdateCarAsync(car);
            return Redirect("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _carRepository.AddCarAsync(car);
            return Redirect("Index");
        }
    }
}
