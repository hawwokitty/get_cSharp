using Abaxrekruttering;

Car car1 = new Car("NF123456", 200, "grønn","Lett kjøretøy", 147);
Car car2 = new Car("NF654321", 195, "blå","Lett kjøretøy", 150);

Airplane airplane1 = new Airplane(30, 2, 10, "Jetfly", "LN1234", 1000);
Boat boat1  = new Boat(30, 500, "Båt", "ABC123", 100);
car1.PrintInfo();
car2.PrintInfo();
airplane1.PrintInfo();
boat1.PrintInfo();
airplane1.Operate();
car1.Operate();
CheckIfSameType(car1.Type, car2.Type);

void CheckIfSameType(string car1Type, string car2Type)
{
    if (car1Type == car2Type) Console.WriteLine("They are the same");
}