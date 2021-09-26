using MODULE2HW6.Enums;
using MODULE2HW6.Models;

namespace MODULE2HW6.Models.ASegmentCar
{
    public abstract class ASegmentCar : PassengerCar
    {
        public CarType CarType { get; init; } = CarType.Single;
    }
}