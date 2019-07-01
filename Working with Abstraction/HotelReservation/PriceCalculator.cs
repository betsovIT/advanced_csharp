using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public static class PriceCalculator
    {
        public static decimal GetTotalPrice(double price, int days, Season season, Discount discount)
        {
            decimal priceWithoutModification = (decimal)price * days;
            decimal priceModifiedBySeason = priceWithoutModification * (int)season;
            decimal finalPrice = priceModifiedBySeason * (1 - ((decimal)discount / 100));
            return finalPrice;
        }
    }

    public enum Season
    {
        Spring = 2,
        Summer = 4,
        Autumn = 1,
        Winter = 3
    }

    public enum Discount
    {
        None,
        SecondVisit = 10,
        VIP = 20
    }
}
