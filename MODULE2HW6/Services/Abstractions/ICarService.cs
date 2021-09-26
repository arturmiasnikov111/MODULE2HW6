using MODULE2HW6.Models;
using MODULE2HW6.Enums;

namespace MODULE2HW6.Services.Abstractions
{
    public interface ICarService
    {
        void FillCars();
        PassengerCar[] GetCars();
        double CarsPrice();
        void SortByFuel();
        void Print(PassengerCar[] passengerCars);
        void Print(PassengerCar passengerCar);
        void FindByParameters(int weight, BrandEnum brandEnum);
    }
}