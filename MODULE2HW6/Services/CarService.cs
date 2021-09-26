using System;
using System.Linq;
using MODULE2HW6.CarsProvider;
using MODULE2HW6.Enums;
using MODULE2HW6.Models;
using MODULE2HW6.Models.ASegmentCar;
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
                Console.WriteLine();
            }
        }

        public void Print(PassengerCar passengerCar)
        {
            Console.WriteLine($"---------{Environment.NewLine}Car has been found by Parameters{Environment.NewLine}Brand: {passengerCar.Brand} Price: {passengerCar.Price.CarPrice} Weight {passengerCar.Weight.Value}");
        }

        public void FindByParameters(int weight, BrandEnum brandEnum)
        {
            bool flag = false;
            foreach (var item in _cars)
            {
                if (weight == item.Weight.Value && brandEnum == item.Brand)
                {
                    Print(item);
                    flag = true;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Nothing has been found according to your search parameters");
            }
        }
    }
}