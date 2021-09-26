using MODULE2HW6.Models;
using MODULE2HW6.Models.ASegmentCar;
using MODULE2HW6.Enums;
using MODULE2HW6.Models.BSegmentCar.BSegmentAudi.AudiA1;
using MODULE2HW6.Models.BSegmentCar.BSegmentChevrolet.ChevroletAveo;

namespace MODULE2HW6.CarsProvider
{
    public class CarProvider : ICarProvider
    {
        public CarProvider()
        {
        }

        public PassengerCar[] Cars { get; set; }

        public PassengerCar[] GetCars()
        {
            return new PassengerCar[]
            {
                new DaewooMatiz(
                    new Weight(2000),
                    CarColorEnum.Blue,
                    ManufacturerCountryEnum.Ukraine,
                    TransmissionEnum.ManualTransmission,
                    4,
                    new Price(2000),
                    BrandEnum.Daewoo,
                    120,
                    1110),
                new AudiA1(
                    new Weight(3000),
                    CarColorEnum.Green,
                    ManufacturerCountryEnum.Germany,
                    TransmissionEnum.AutomaticTransmission,
                    4,
                    new Price(5200),
                    BrandEnum.Audi,
                    200,
                    30),
                new ChevroletAveo(
                    new Weight(3500),
                    CarColorEnum.Green,
                    ManufacturerCountryEnum.Germany,
                    TransmissionEnum.AutomaticTransmission,
                    3,
                    new Price(1500),
                    BrandEnum.Chevrolet,
                    150,
                    10)
            };
        }
    }
}