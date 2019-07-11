using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    class Robot : IIdentifiable
    {
        public string Model { get; set; }
        public string Id { get; set; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public bool CheckIfFake(string lastDigits)
        {
            int countOfDigits = lastDigits.Length;
            string lastDigitsOfID = Id.Substring(Id.Length - countOfDigits, countOfDigits);

            return lastDigits == lastDigitsOfID;
        }
    }
}
