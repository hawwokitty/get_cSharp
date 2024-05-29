namespace UnitTest.Practice
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            LeggSammenTest test = new LeggSammenTest();
            test.LeggSammenToPositiveTall();
            test.LeggSammenToNegativeTall();
            TrekkFraTest test2 = new TrekkFraTest();
            test2.TrekkFraToPositiveTall();
            test2.TrekkFraToNegativeTall();
            MultipliserTest test3 = new MultipliserTest();
            test3.MultipliserToPositiveTall();
            test3.MultipliserToNegativeTall();
            test3.MultipliserMedNull();
            DividerTest test4 = new DividerTest();
            test4.DividerToPositiveTall();
            test4.DividerToNegativeTall();
            test4.DividerMedNull();
        }
    }
}