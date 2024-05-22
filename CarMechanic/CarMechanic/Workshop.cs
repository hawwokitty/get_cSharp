namespace CarMechanic
{
    internal class Workshop
    {
        public string _carIssue { get; private set; }

        private List<string> _carProblems = new()
        {
            "Wheel",
            "Battery",
            "Heating",
            "Motor",
            "Fuel pump",
            "Radiator",
            "Timing belt",
            "Spark plug",
            "Air conditioning",
            "Power steering",
            "Headlight",
            "Taillight",
            "Windshield wiper",
            "Fuel injector",
            "Clutch",
            "ABS system",
        };
        public void DiagnoseCar()
        {
            _carIssue = RunCarGetsProblem();
        }
        public string RunCarGetsProblem()
        {
            Random randomNum = new Random();
            int randomCarIssueNumber = randomNum.Next(0, _carProblems.Count);
            return _carProblems[randomCarIssueNumber];
        }

        public void CheckCar()
        {
            for (int i = 0; i < _carProblems.Count; i++)
            {
                Console.WriteLine($"Mechanic checking {_carProblems[i]}");
                if (_carIssue == _carProblems[i])
                {
                    Console.WriteLine($"Problem found with: {_carIssue}");
                    RunFixCarProblem();
                    break;
                }
                else
                {
                    Console.WriteLine($"No problem with: {_carProblems[i]}");
                }
            }
        }

        public void RunFixCarProblem()
        {
            Console.WriteLine($"Mechanic is fixing the problem with: {_carIssue}");
            _carIssue = "";
            Console.WriteLine("The car is now fixed and can be picked up by the owner");
        }
    }
}
