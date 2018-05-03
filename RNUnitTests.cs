using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Project_RimskaCisla
{
    class RNUnitTests
    {
        public void RNUnitTest1()
        {
            Assert.That(true, Is.GreaterThan(0));
        }

        public void RNUnitTest2()
        {
            Assert.That(5, Is.EqualTo(5));
        }

        public void RNUnitTest3()
        {
            Assert.That(6, Is.LessThanOrEqualTo(8));
        }
    }
}
