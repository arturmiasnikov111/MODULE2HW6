using System;
using MODULE2HW6.Enums;
using MODULE2HW6.Models;

namespace MODULE2HW6.Extensions
{
    public static class Search
    {
        public static void FindByParameters(this PassengerCar[] cars, int weight, BrandEnum brandEnum)
        {
            bool flag = false;
            foreach (var item in cars)
            {
                if (weight == item.Weight.Value && brandEnum == item.Brand)
                {
                    Console.WriteLine(
                        $"---------{Environment.NewLine}Car has been found by Parameters" +
                        $"{Environment.NewLine}" +
                        $"Brand: {item.Brand} " +
                        $"Price: {item.Price.CarPrice} " +
                        $"Weight {item.Weight.Value}");
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
