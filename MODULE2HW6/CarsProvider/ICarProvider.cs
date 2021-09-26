using MODULE2HW6.Models;

namespace MODULE2HW6.CarsProvider
{
    public interface ICarProvider
    {
        PassengerCar[] Cars { get; }

        PassengerCar[] GetCars();
    }
}