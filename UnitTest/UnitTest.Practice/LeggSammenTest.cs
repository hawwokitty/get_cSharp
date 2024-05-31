namespace UnitTest.Practice
{
    internal class LeggSammenTest
    {
        Kalkulator _kalkulator = new Kalkulator();
        

        public void LeggSammenToPositiveTall()
        {
            int result = _kalkulator.LeggSammen(3, 2);
            Assert.That(result, Is.EqualTo(5));
        }public void LeggSammenToNegativeTall()
        {
            int result = _kalkulator.LeggSammen(-6, -2);
            Assert.That(result, Is.EqualTo(-8));
        }
    }
}
