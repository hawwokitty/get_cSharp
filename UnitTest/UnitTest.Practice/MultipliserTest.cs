using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Practice
{
    internal class MultipliserTest
    {
        Kalkulator _kalkulator = new Kalkulator();

        public void MultipliserToPositiveTall()
        {
            int result = _kalkulator.Multipliser(3, 2);
            Assert.AreEqual(6, result);
        }
        public void MultipliserToNegativeTall()
        {
            int result = _kalkulator.Multipliser(-3, -2);
            Assert.AreEqual(6, result);
        }
        public void MultipliserMedNull()
        {
            int result = _kalkulator.Multipliser(-3, 0);
            Assert.AreEqual(0, result);
        }
    }
}
