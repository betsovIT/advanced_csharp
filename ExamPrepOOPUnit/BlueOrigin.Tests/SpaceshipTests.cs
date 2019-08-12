namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    public class SpaceshipTests
    {
       [Test]
       public void TestIfSpaceshipInitializesCorrectly()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 50);


            Assert.That(spaceship.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestThatNameSetsCorrectly()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 50);

            Assert.That(spaceship.Name, Is.EqualTo("Enterprise"));
        }

        [Test]
        public void TestThatNameCanNotBeSetToNull()
        {
            Assert.Throws<ArgumentNullException>(() => { Spaceship spaceship = new Spaceship(null, 50); });
        }

        [Test]
        public void TestThatCapacitySetsCorrectly()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 50);

            Assert.That(spaceship.Capacity, Is.EqualTo(50));
        }

        [Test]
        public void TestThatCapacityCanNotBeSetToNegative()
        {
            Assert.Throws<ArgumentException>(() => { Spaceship spaceship = new Spaceship("Enterprise", -1); });
        }

        [Test]
        public void TestAddingAstronautsWorksCorrectly()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 50);
            Astronaut astronaut = new Astronaut("Neil", 100);

            spaceship.Add(astronaut);

            Assert.That(spaceship.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestAddingWithFullCapacity()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 1);
            Astronaut astronaut = new Astronaut("Neil", 100);
            Astronaut newAstronaut = new Astronaut("Armstrong", 100);

            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(() => spaceship.Add(newAstronaut), "Spaceship is full!");

        }

        [Test]
        public void TestAddingExistingAstronaut()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 50);
            Astronaut astronaut = new Astronaut("Neil", 100);

            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(() => spaceship.Add(astronaut), $"Astronaut {astronaut.Name} is already in!");
        }

        [Test]
        public void TestRemovingCorrectly()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 1);
            Astronaut astronaut = new Astronaut("Neil", 100);

            spaceship.Add(astronaut);


            Assert.That(() => spaceship.Remove("Neil"), Is.EqualTo(true));
        }

        [Test]
        public void TestRemovingNonExistant()
        {
            Spaceship spaceship = new Spaceship("Enterprise", 1);
            Astronaut astronaut = new Astronaut("Neil", 100);

            spaceship.Add(astronaut);


            Assert.That(() => spaceship.Remove("Armstrong"), Is.EqualTo(false));
        }
    }
}