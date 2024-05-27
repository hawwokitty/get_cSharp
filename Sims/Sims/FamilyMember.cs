namespace Sims
{
    internal class FamilyMember(string firstName, string lastName, bool isAdult, string gender)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set;} = lastName;
        public bool IsAdult { get; private set; } = isAdult;
        public string Gender { get; private set;} = gender;

    }
}
