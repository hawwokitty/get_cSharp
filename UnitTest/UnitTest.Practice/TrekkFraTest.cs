namespace UnitTest.Practice
{
    internal class TrekkFraTest
    {
        Kalkulator _kalkulator = new Kalkulator();

        public void TrekkFraToPositiveTall()
        {
            int result = _kalkulator.TrekkFra(3, 2);
            Assert.That(result, Is.EqualTo(1));
        }
        public void TrekkFraToNegativeTall()
        {
            int result = _kalkulator.TrekkFra(-3, -2);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
