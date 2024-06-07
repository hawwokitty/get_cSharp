using Formkontrollsystem;

List<Shape> listOfShapes = new()
{
    new Circle("Circle", "Red", 5),
    new Circle("Circle", "Magenta", 10),
    new Rectangle("Rectangle", "Yellow", 5, 10),
    new Rectangle("Rectangle", "Green", 6, 3),
    new Triangle("Triangle", "Blue", 14, 2),
    new Triangle("Triangle", "Cyan", 2, 4)
};

foreach (var shape in listOfShapes)
{
    Console.ForegroundColor = GetConsoleColor(shape.Color);
    Console.WriteLine($"This {shape.Name} is {shape.Color} and has an area of {shape.CalculateArea()}");
    Console.ForegroundColor = ConsoleColor.White;
}

TotalArea();
SortShapes();
SortByColor();

static ConsoleColor GetConsoleColor(string color)
{
    return color.ToLower() switch
    {
        "black" => ConsoleColor.Black,
        "darkblue" => ConsoleColor.DarkBlue,
        "darkgreen" => ConsoleColor.DarkGreen,
        "darkcyan" => ConsoleColor.DarkCyan,
        "darkred" => ConsoleColor.DarkRed,
        "darkmagenta" => ConsoleColor.DarkMagenta,
        "darkyellow" => ConsoleColor.DarkYellow,
        "gray" => ConsoleColor.Gray,
        "darkgray" => ConsoleColor.DarkGray,
        "blue" => ConsoleColor.Blue,
        "green" => ConsoleColor.Green,
        "cyan" => ConsoleColor.Cyan,
        "red" => ConsoleColor.Red,
        "magenta" => ConsoleColor.Magenta,
        "yellow" => ConsoleColor.Yellow,
        "white" => ConsoleColor.White,
        _ => ConsoleColor.White, // Default color if the color string doesn't match
    };
}

void TotalArea()
{
    double totalArea = 0;
    foreach (var shape in listOfShapes)
    {
        totalArea += shape.CalculateArea();
    }

    Console.WriteLine($"The total area of all the shapes added together is {totalArea}");
}

void SortShapes()
{
    listOfShapes.Sort((s1, s2) => s1.CalculateArea().CompareTo(s2.CalculateArea()));
}

void SortByColor()
{
    listOfShapes.Sort((s1, s2) => string.Compare(s1.Color, s2.Color, StringComparison.OrdinalIgnoreCase));
}