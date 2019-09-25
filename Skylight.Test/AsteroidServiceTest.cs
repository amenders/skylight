using NUnit.Framework;
using System;

namespace Skylight.Test
{
    [TestFixture()]
    public class AsteroidServiceTest
    {
        private AsteroidService asteroids = new AsteroidService();

        [Test()]
        public void Throw_Exception_When_Start_Date_Before_End_Date()
        {
            var start = new DateTime(2019, 1, 10);
            var end = new DateTime(2019, 1, 2);

            Assert.Throws<InvalidAsteroidParametersException>(async () => await asteroids.GetAsteroidByDateAsync(start, end));
        }

        [Test()]
        public void Throw_Exception_When_Date_Range_Greater_Than_Seven()
        {
            var start = new DateTime(2019, 1, 10);
            var end = new DateTime(2019, 1, 20);

            Assert.Throws<InvalidAsteroidParametersException>(async () => await asteroids.GetAsteroidByDateAsync(start, end));
        }
    }
}
