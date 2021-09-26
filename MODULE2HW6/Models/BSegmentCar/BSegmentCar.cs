using MODULE2HW6.Enums;

namespace MODULE2HW6.Models.BSegmentCar
{
    public abstract class BSegmentCar : PassengerCar
    {
        public CarType CarType { get; init; } = CarType.Family;
    }
}