using MODULE2HW6.Enums;

namespace MODULE2HW6.Models.ASegmentCar
{
    public class DaewooMatiz : ASegmentDaewoo
    {
        public DaewooMatiz(Weight weight, CarColorEnum color, ManufacturerCountryEnum country, TransmissionEnum transmission, double seats, Price price, BrandEnum brand, int carSpeed, int fuelConsumption)
        {
            Weight = weight;
            Color = color;
            ManufacturerCountry = country;
            Transmission = transmission;
            Seats = seats;
            Price = price;
            Brand = brand;
            CarSpeed = carSpeed;
            FuelConsumption = fuelConsumption;
            DaewooBrand = "Daewoo Matiz";
        }

        public override string DaewooBrand { get; init; }

        public override Weight Weight { get; init; }
        public override CarColorEnum Color { get; init; }
        public override ManufacturerCountryEnum ManufacturerCountry { get; init; }
        public override TransmissionEnum Transmission { get; init; }
        public override double Seats { get; init; }
        public override Price Price { get; init; }
        public override BrandEnum Brand { get; init; }
        public override int CarSpeed { get; init; }
        public override int FuelConsumption { get; init; }
    }
}