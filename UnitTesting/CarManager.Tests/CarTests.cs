using NUnit.Framework;
//using CarManager;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("VW", "Golf", 10.5, 65);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Assert.That(car, Is.Not.Null);
        }

        [Test]
        public void TestIfConstructorThrowsWithNullMake()
        {
            Assert.Throws<ArgumentException>(() => new Car("Bacia", null, 15, 40));
        }
        [Test]
        public void TestIfConstructorThrowsWithNullModel()
        {
            Assert.Throws<ArgumentException>(() => new Car(null, "Dragster", 15, 40));
        }

        [Test]
        public void TestIfConstructorThrowsWithLowerThanZeroFuelConsumption()
        {
            Assert.Throws<ArgumentException>(() => new Car("Bacia", "Dragster", -3, 40));
        }

        [Test]
        public void TestIfConstructorThrowsWithLowerThanZeroFuelCapacity()
        {
            Assert.Throws<ArgumentException>(() => new Car("Bacia", "Dragster", 2, -4));
        }

        [Test]
        public void TestIfMakeGetsTheCorrectString()
        {
            Assert.That(car.Make, Is.EqualTo("VW"));
        }

        [Test]
        public void TestIfModelGetsTheCorrectString()
        {
            Assert.That(car.Model, Is.EqualTo("Golf"));
        }

        [Test]
        public void TestIfFuelConsumptionIsCorrect()
        {
            Assert.That(car.FuelConsumption, Is.EqualTo(10.5));
        }

        [Test]
        public void TestIfFuelCapacityIsCorrect()
        {
            Assert.That(car.FuelCapacity, Is.EqualTo(65));
        }

        [Test]
        public void TestIfFuelAmmountIsCorrect()
        {
            Assert.That(car.FuelAmount, Is.EqualTo(0));
        }

        [Test]
        public void TestIfRefuelingWorksCorrectly()
        {
            car.Refuel(5);

            Assert.That(car.FuelAmount, Is.EqualTo(5));
        }

        [Test]
        public void TestRefuelingWithNegativeNumber()
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(-5), "Fuel amount cannot be zero or negative!");
        }

        [Test]
        public void TestRefuelingWithAmmountBiggerThanTheCapacity()
        {
            car.Refuel(150);
            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }

        [Test]
        public void TestDrivingWorksCorrectly()
        {
            car.Refuel(50);
            car.Drive(100);

            Assert.That(car.FuelAmount, Is.EqualTo(39.5));
        }

        [Test]
        public void TestDrivingWithInsufficientFuel()
        {
            car.Refuel(5);

            Assert.Throws<InvalidOperationException>(() => car.Drive(100), "You don't have enough fuel to drive!");
        }
    }
}