namespace AGirlSmilesAtYou
{
    internal class You
    {
        public void GirlInteractsWithYou(Girl girl)
        {
            GirlLooksInYourDirection(girl);
        }

        private void GirlLooksInYourDirection(Girl girl)
        {
            Console.WriteLine("When in a nightclub/ bar/ pub/ discoteque/ ballroom etc. you may find yourself in a situation where a young lady is giving you 'the eye'. The correct procedure in these circumstances is to do the following: ");
            Console.WriteLine("Check behind you to see if there is anyone standing there.");

            Console.WriteLine("If there IS, and it is another man, move away a few steps, and see if her eyeline follows you or stays on the other man.");
            if (girl.IsGirlReallyInteractingWithYou())
            {
                MonitorHerForAWhile(girl);
            }
            else
            {
                Failure();
            }
        }

        private void MonitorHerForAWhile(Girl girl)
        {
            Console.WriteLine("If she is still looking in your direction after this and you haven't been removed by bouncers for looking dodgy, proceed to monitor her for another 30 minutes to make absolutely sure it is YOU she is looking at.");
            if (girl.IsGirlReallyInteractingWithYou())
            {
                Console.WriteLine("Risk a smile.");
                GirlSmilesAtYou(girl);
            }
            else
            {
                Failure();
            }
        }

        private static void Failure()
        {
            Console.WriteLine("She was not interested in you after all.. good thing we avoided an awkward situation! Go to the bar for a consolation pint");
        }

        private void GirlSmilesAtYou(Girl girl)
        {
            Console.WriteLine("If she smiles back, don't be fooled into approaching, for it could be an unfortunately timed belch, or a small piece of ice caught in her throat. Monitor the situation for a further ten or so minutes, then risk another smile.");
            if (girl.IsGirlReallyInteractingWithYou())
            {
                Console.WriteLine("If she smiles again, it is highly unlikely the belch/ ice situations have struck twice, so she probably is making those mouth movements voluntarily. But smile again just in case.");
                if (girl.IsGirlReallyInteractingWithYou())
                {
                    Console.WriteLine("The third smile totally eradicates the belch/ ice possibilities. Risk a small wave. Nothing fancy. Avoid finger gestures and 'wanker' signs (this may seem obvious, but under stress, leave nothing to chance).");
                    GirlWavesAtYou(girl);
                }
                else
                {
                    Failure();
                }
            }
            else
            {
                Failure();
            }
        }

        private void GirlWavesAtYou(Girl girl)
        {
            if (girl.IsGirlReallyInteractingWithYou())
            {
                Console.WriteLine("She's waved back. And smiled. And beckoned you over. Don't risk it. Proceed to monitor her for a further hour.");
                MonitorHerMore(girl);
            }
            else
            {
                Failure();
            }
        }

        private void MonitorHerMore(Girl girl)
        {
            Console.WriteLine("She's gone off with another man. This proves that she wasn't interested and following this has saved you from a potentially embarrassing situation. Proceed to the bar for a consolation/ celebratory pint.");
        }
    }
}
