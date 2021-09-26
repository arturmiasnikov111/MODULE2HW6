using System;
using MODULE2HW6.CarsProvider;
using MODULE2HW6.Enums;
using MODULE2HW6.Extensions;
using MODULE2HW6.Models;
using MODULE2HW6.Models.BSegmentCar.BSegmentChevrolet.ChevroletAveo;
using MODULE2HW6.Services;
using MODULE2HW6.Services.Abstractions;

namespace MODULE2HW6
{
    public class Application
    {
        private readonly ICarService _carService;

        public Application(ICarService carService)
        {
            _carService = carService;
        }

        public void Run()
        {
            var carService = _carService.GetCars();
            _carService.CarsPrice();
            Console.WriteLine("Car has been sorted by Fuel Consumption");
            _carService.SortByFuel();
            Search.FindByParameters(carService, 3500, BrandEnum.Chevrolet);
        }
    }
}