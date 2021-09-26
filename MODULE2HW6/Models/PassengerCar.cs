using MODULE2HW6.Enums;

namespace MODULE2HW6.Models
{
    public abstract class PassengerCar
    {
        public abstract Weight Weight { get; init; }
        public abstract CarColorEnum Color { get; init; }
        public abstract ManufacturerCountryEnum ManufacturerCountry { get; init; }
        public abstract TransmissionEnum Transmission { get; init; }
        public abstract double Seats { get; init; }
        public abstract Price Price { get; init; }
        public abstract BrandEnum Brand { get; init; }
        public abstract int CarSpeed { get; init; }
        public abstract int FuelConsumption { get; init; }
    }
}