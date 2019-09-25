using NUnit.Framework;
using System;

namespace Skylight.Test
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.True(true);

        }

        [Test()]
        public void Pass()
        {
            Assert.True(true);
        }
    }
}
