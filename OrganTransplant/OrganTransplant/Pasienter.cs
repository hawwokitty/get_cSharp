namespace OrganTransplant
{
    internal class Pasienter (string name, string kidney1, string kidney2)
    {
        public string Name { get; set; } = name;
        public string Kidney1 { get; set; } = kidney1;
        public string Kidney2 { get; set; } = kidney2;

        public static void DoTransplant(Pasienter nameOfPatient, Pasienter nameOfDonor)
        {

            nameOfPatient.Kidney2 = nameOfDonor.Kidney2;
            nameOfDonor.Kidney2 = null;
        }
    }
}
