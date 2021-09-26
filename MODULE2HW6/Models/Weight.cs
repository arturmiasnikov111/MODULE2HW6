using System;
using MODULE2HW6.Enums;

namespace MODULE2HW6.Models
{
    public class Weight
    {
        private const int CompactCarMaxWeight = 1324;
        private const int MidSizeCarMaxWeight = 1524;
        private const int LargeSizeCarMaxWeight = 1760;
        public Weight(double weight)
        {
            GetClassWeightCar(weight);
            Value = weight;
        }

        public double Value { get; init; }
        public WeightClassCar WeightClassCar { get; private set; }

        private void GetClassWeightCar(double value)
        {
            if (value > 0)
            {
                switch (value)
                {
                    case double weight when weight <= CompactCarMaxWeight:
                        WeightClassCar = WeightClassCar.CompactCar;
                        break;
                    case double weight when weight > CompactCarMaxWeight && weight <= MidSizeCarMaxWeight:
                        WeightClassCar = WeightClassCar.MidSizeCar;
                        break;
                    case double weight when weight > MidSizeCarMaxWeight && weight <= LargeSizeCarMaxWeight:
                        WeightClassCar = WeightClassCar.LargeCar;
                        break;
                }
            }
            else
            {
                {
                    throw new Exception($"Car {nameof(Value)} should be more then 0");
                }
            }
        }
    }
}