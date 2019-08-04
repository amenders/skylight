
using System;
using NUnit.Framework;

namespace Skylight.Test
{
    [TestFixture]
    public class AsteroidServiceTest
    {
        [Test]
        public void Pass()
        {
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        public void Ignore()
        {
            Assert.True(false);
        }
    }
}
