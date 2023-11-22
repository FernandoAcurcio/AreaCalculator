using AreaCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        var aux = 0;
        do
        {
            aux = MainMenu();
        } while (aux != 0);
    }

    private static int MainMenu()
    {
        Console.WriteLine(" Choose form the next two option, press 0 to exit.");
        Console.WriteLine("1- calculate rectangle area.");
        Console.WriteLine("2- calculate circle area.");

        if (int.TryParse(Console.ReadLine(), out int result))
        {
            switch (result)
            {
                case 0:
                    Console.WriteLine("Goodbye");
                    break;
                case 1:
                case 2:
                    LogicMenu(result);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Choose a valid option");            
        }
        Console.ReadLine();
        Console.Clear();
        return result;
    }

    private static void LogicMenu(int type)
    {
        if(type == 1)
        {
            Console.Write("\nInsert the radius of the circle: ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                var circle = new Circle(result);
                Console.WriteLine("Circle area: " + Math.Round(circle.CalculateArea(), 2));
            }
            else
                Console.WriteLine("Invalid input.");
        }
        else if(type == 2)
        {
            Console.Write("\nInsert the width of the rectangle: ");
            if (int.TryParse(Console.ReadLine(), out int result1))
            {
                Console.Write("\nInsert the height of the rectangle: ");
                if (int.TryParse(Console.ReadLine(), out int result2))
                {
                    Rectangle rectangle = new Rectangle(result1, result2);
                    Console.WriteLine("Rectangle Area: " + Math.Round(rectangle.CalculateArea(), 2));

                }
                else
                    Console.WriteLine("Invalid input.");
            }
            else
                Console.WriteLine("Invalid input.");
        }

    }

}