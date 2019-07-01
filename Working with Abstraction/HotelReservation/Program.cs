using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double pricePerDay = double.Parse(input[0]);
            int days = int.Parse(input[1]);
            Season season = Season.Winter;
            Discount discount = Discount.None;
            switch (input[2])
            {
                case "Winter":
                    season = Season.Winter;
                    break;
                case "Summer":
                    season = Season.Summer;
                    break;
                case "Spring":
                    season = Season.Spring;
                    break;
                case "Autumn":
                    season = Season.Autumn;
                    break;
                default:
                    break;
            }
            if (input.Length > 3)
            {
                switch (input[3])
                {
                    case "VIP":
                        discount = Discount.VIP;
                        break;
                    case "SecondVisit":
                        discount = Discount.SecondVisit;
                        break;
                    default:
                        discount = Discount.None;
                        break;
                }
            }
            


            Console.WriteLine($"{PriceCalculator.GetTotalPrice(pricePerDay, days, season, discount):F2}");
        }




    }
}
