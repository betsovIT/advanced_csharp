namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;

    public class SoftParkTest
    {
        [Test]
        public void TestCountOfParkingSpots()
        {
            SoftPark parking = new SoftPark();

            Assert.That(parking.Parking.Count, Is.EqualTo(12));
        }

        [Test]
        public void TestParkingOnNonExistantSpot()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");

            Assert.Throws<ArgumentException>(() => parking.ParkCar("A5", car), "Parking spot doesn't exists!");
        }

        [Test]
        public void TestParkingOnAlreadyTakenSpot()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");
            Car newCar = new Car("VW", "CA0000AC");

            parking.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() => parking.ParkCar("A1", newCar), "Parking spot is already taken!");
        }

        [Test]
        public void TestParkingTheSameCarAtDifferentPlace()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");

            parking.ParkCar("A1", car);

            Assert.Throws<InvalidOperationException>(() => parking.ParkCar("A2", car), "Car is already parked!");
        }

        [Test]
        public void TestTheOutputAfterParkingCorrectly()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");

            string output = parking.ParkCar("A1", car);

            Assert.That(output, Is.EqualTo("Car:CA2249PC parked successfully!"));
        }

        [Test]
        public void TestRemovingACarFromNonexistantSpot()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");


            Assert.Throws<ArgumentException>(() => parking.RemoveCar("A15", car), "Parking spot doesn't exists!");
        }

        [Test]
        public void TestRemovingTheWrongCarFromThatSpot()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");
            Car otherCar = new Car("Opel", "Y2020TA");

            parking.ParkCar("B1", car);

            Assert.Throws<ArgumentException>(() => parking.RemoveCar("B1", otherCar), "Car for that spot doesn't exists!");
        }

        [Test]
        public void TestRemovingWorksCorrectly()
        {
            SoftPark parking = new SoftPark();
            Car car = new Car("VW", "CA2249PC");

            parking.ParkCar("B1", car);
            string message = parking.RemoveCar("B1", car);

            Assert.That(message, Is.EqualTo("Remove car:CA2249PC successfully!"));
            Assert.That(parking.Parking["B1"], Is.Null);

        }
    }
}