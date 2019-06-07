using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private List<Car> cars;
        private int capacity;

        public List<Car> Cars
        {
            get { return cars; }
            set { this.cars = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }

        public int Count
        {
            get { return Cars.Count; }
        }

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }

        public string AddCar(Car car)
        {
            if (Cars.Exists(n => n.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count == Capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registration)
        {
            if (!Cars.Exists(n => n.RegistrationNumber == registration))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Car car = Cars.Where(n => n.RegistrationNumber == registration).FirstOrDefault();
                Cars.Remove(car);

                return $"Successfully removed {registration}";
            }
        }

        public Car GetCar(string registration)
        {
            Car car = Cars.Where(n => n.RegistrationNumber == registration).FirstOrDefault();
            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registration in registrationNumbers)
            {
                RemoveCar(registration);
            }
        }

    }
}
