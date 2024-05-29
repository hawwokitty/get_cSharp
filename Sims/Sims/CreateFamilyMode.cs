namespace Sims
{
    internal class CreateFamilyMode
    {
        public void CreateFamily()
        {
            FamilyMember family = new FamilyMember();
            while (true)
            {
                family.CreateFamilyMember();

            }
        }
    }
}
