using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Practice
{
    internal class LeggSammenTest
    {
        Kalkulator _kalkulator = new Kalkulator();
        

        public void LeggSammenToPositiveTall()
        {
            int result = _kalkulator.LeggSammen(3, 2);
            Assert.AreEqual(5, result);
        }public void LeggSammenToNegativeTall()
        {
            int result = _kalkulator.LeggSammen(-6, -2);
            Assert.AreEqual(-8, result);
        }
    }
}
