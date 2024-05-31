namespace UnitTest.Practice
{
    internal class MultipliserTest
    {
        Kalkulator _kalkulator = new Kalkulator();

        public void MultipliserToPositiveTall()
        {
            int result = _kalkulator.Multipliser(3, 2);
            Assert.That(result, Is.EqualTo(6));
        }
        public void MultipliserToNegativeTall()
        {
            int result = _kalkulator.Multipliser(-3, -2);
            Assert.That(result, Is.EqualTo(6));
        }
        public void MultipliserMedNull()
        {
            int result = _kalkulator.Multipliser(-3, 0);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
