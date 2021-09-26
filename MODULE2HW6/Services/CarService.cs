using System;
using System.Linq;
using MODULE2HW6.CarsProvider;
using MODULE2HW6.Enums;
using MODULE2HW6.Models;
using MODULE2HW6.Models.ASegmentCar;
using MODULE2HW6.Models.BSegmentCar.BSegmentChevrolet.ChevroletAveo;
using MODULE2HW6.Services.Abstractions;

namespace MODULE2HW6.Services
{
    public class CarService : ICarService
    {
        private readonly ICarProvider _carProvider;
        private PassengerCar[] _cars;

        public CarService(ICarProvider carProvider)
        {
            _carProvider = carProvider;
            FillCars();
        }

        public void FillCars()
        {
            _cars = _carProvider.GetCars();
        }

        public PassengerCar[] GetCars()
        {
            return _cars;
        }

        public double CarsPrice()
        {
            double totalPrice = 0;
            if (_cars != null)
            {
                foreach (var item in _cars)
                {
                    totalPrice += item.Price.CarPrice;
                }

                Console.WriteLine($"Total Price IS : {totalPrice}");
            }

            return totalPrice;
        }

        public void SortByFuel()
        {
            PassengerCar[] sortedArray = _cars.OrderBy(c => c.FuelConsumption).ToArray();
            Print(sortedArray);
        }

        public void Print(PassengerCar[] passengerCars)
        {
            foreach (var item in passengerCars)
            {
                Console.WriteLine($"Brand: {item.Brand} Price: {item.Price.CarPrice} Fuel Consumption: {item.FuelConsumption}");
            }
        }
    }
}