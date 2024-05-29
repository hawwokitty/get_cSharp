namespace Parprogrammering
{
    internal class Car
    {
        private string Brand { get; set; }
        private int Year { get; set; }
        private string Regislation { get; set; }
        private int KilometerDistance { get; set; }
        public Car(string brand, int year, string reg, int km)
        {
            Brand = brand;
            Year = year;
            Regislation = reg;
            KilometerDistance = km;
        }
        public Car()
        {

        }
        public string GetCarBrand(){ return Brand; }
        public int GetYear() { return Year; }
        public string GetRegislation() {  return Regislation; }
        public int GetKilometerDistance() {  return KilometerDistance; }

    }
}
