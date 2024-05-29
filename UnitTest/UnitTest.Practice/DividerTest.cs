using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Practice
{
    internal class DividerTest
    {
        Kalkulator _kalkulator = new Kalkulator();
        public void DividerToPositiveTall()
        {
            int result = _kalkulator.Divider(6, 2);
            Assert.AreEqual(3, result);
        }
        public void DividerToNegativeTall()
        {
            int result = _kalkulator.Divider(-6, -2);
            Assert.AreEqual(3, result);
        }
        public void DividerMedNull()
        {
            var ex = Assert.Throws<ArgumentException>(() => _kalkulator.Divider(3, 0));
            Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero."));
        }
    }
}
