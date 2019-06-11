using System;

namespace LaptopShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string laptopMake = "ASUS";
            string laptopModel = "Rog HV34134";
            double laptopDisplaySize = 15.3;
            decimal laptopPrice = 333;
            int laptopRam = 32;
            int laptopSsd = 256;

            Laptop laptop = new Laptop(laptopMake, laptopModel, laptopDisplaySize, laptopPrice, laptopRam, laptopSsd);

            var shop = new Shop();


            //Shop
            //-Laptops ?
            //--AddLaptop
            //--RemoveLaptop
            //--ContainsLaptop
        }
    }
}
