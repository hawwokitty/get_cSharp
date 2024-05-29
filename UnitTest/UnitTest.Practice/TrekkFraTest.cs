using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Practice
{
    internal class TrekkFraTest
    {
        Kalkulator _kalkulator = new Kalkulator();

        public void TrekkFraToPositiveTall()
        {
            int result = _kalkulator.TrekkFra(3, 2);
            Assert.AreEqual(1, result);
        }
        public void TrekkFraToNegativeTall()
        {
            int result = _kalkulator.TrekkFra(-3, -2);
            Assert.AreEqual(-1, result);
        }
    }
}
