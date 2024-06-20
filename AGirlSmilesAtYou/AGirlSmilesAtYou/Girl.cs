namespace AGirlSmilesAtYou
{
    internal class Girl
    {
        Random random = new Random();
        public bool IsGirlReallyInteractingWithYou()
        {
            return random.Next(1, 3) == 1;
        }
    }
}
