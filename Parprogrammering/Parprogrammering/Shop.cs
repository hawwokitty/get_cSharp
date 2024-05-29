namespace Parprogrammering
{
    internal class Shop
    {
        private List<Car> _cars = new List<Car>()
        {
            new("Toyota", 2004, "SD24679", 2999999),
            new("Ferarri", 2024, "KH23964", 0),
            new("Landrover", 2015, "EL37846", 15000),
        };

        public void EnterShop(Customer customer)
        {
            Console.WriteLine("Welcome to the Car dealership!");
            Console.WriteLine("Here is our selection of cars:");
            ShowAllCars();
            Console.WriteLine("What would you like to do? Please type 1 or 2");
            Console.WriteLine("1. Buy a car");
            Console.WriteLine("2. Filter cars");
            bool isValid = false;
            string input = Console.ReadLine();
            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        BuyCar(customer);
                    }
                    else if (choice == 2)
                    {
                        FilterCars();
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }
        }

        public void BuyCar(Customer customer)
        {
            Console.WriteLine("Which car would you like to buy? Type the number in the list of the car you want");
            bool isValid = false;
            string input = Console.ReadLine();
            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice <= _cars.Count)
                {
                    string carBrand = _cars[choice - 1].GetCarBrand();
                    Console.WriteLine($"You picked car number {choice}. {carBrand}");
                    List<Car> customersCars = customer.Cars;
                    customersCars.Add(_cars[choice - 1]);
                    _cars.Remove(_cars[choice - 1]);
                    Console.WriteLine($"You bought the {carBrand}");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }
        }

        public void FilterCars()
        {
            Console.WriteLine("What would you like to filter by?");
            Console.WriteLine("1. Manufacturing year");
            Console.WriteLine("2. Kilometer distance");
            bool isValid = false;
            string input = Console.ReadLine();
            while (!isValid)
            {
                if (int.TryParse(input, out int choice) && choice == 1 || choice == 2)
                {
                    if (choice == 1)
                    {
                        FilterCarsByYear();
                    }
                    else if (choice == 2)
                    {
                        FilterCarsByDistance();
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    input = Console.ReadLine();
                }
            }
        }

        private void FilterCarsByDistance()
        {
          
        }

        private void FilterCarsByYear()
        {
            Console.WriteLine("Please Enter the first year:");
            int fromYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the last year:");
            int toYear = Convert.ToInt32(Console.ReadLine());
            List<Car> ListFilteredByYear = _cars.Where(c => c.GetYear() < toYear && c.GetYear() > fromYear).ToList();
        }

        public void ShowAllCars()
        {
            
            for (int i = 0; i < _cars.Count; i++)
            {
                string carBrand = _cars[i].GetCarBrand();
                int carYear = _cars[i].GetYear();
                int carKm = _cars[i].GetKilometerDistance();
                Console.WriteLine($"{i + 1}. {carBrand}, Manufacturing year: {carYear}, Kilometer distance: {carKm}");
            }
        }
    }
}
