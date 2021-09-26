using System;
using MODULE2HW6.Enums;

namespace MODULE2HW6.Models
{
    public class Price
    {
        private const int MaxLowPrice = 5000;
        private const int MaxMiddlePrice = 10000;
        private const int LowHighPrice = 10001;

        public Price(int value)
        {
            GetCarPriceType(value);
            CarPrice = value;
        }

        public double CarPrice { get; init; }
        public PriceEnum CarPriceType { get; private set; }

        private void GetCarPriceType(int value)
        {
            if (value > 0)
            {
                switch (value)
                {
                    case int weight when weight <= MaxLowPrice:
                        CarPriceType = PriceEnum.LowPrice;
                        break;
                    case int weight when weight > MaxLowPrice && weight <= MaxMiddlePrice:
                        CarPriceType = PriceEnum.MiddlePrice;
                        break;
                    case int weight when weight > LowHighPrice:
                        CarPriceType = PriceEnum.HighPrice;
                        break;
                }
            }
            else
            {
                {
                    throw new Exception($"Car {nameof(CarPrice)} should be more then 0");
                }
            }
        }
    }
}