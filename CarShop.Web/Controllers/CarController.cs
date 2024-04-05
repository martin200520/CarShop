using CarShop.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

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
    }
}
