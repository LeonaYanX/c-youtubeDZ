internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the First value");

        double firstValue = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter what operation you want to do?");

        string actionstr = Console.ReadLine();

        Console.WriteLine("Enter the Second value");

        double secondValue = Convert.ToDouble(Console.ReadLine());

        double memoryValue ;

        switch (actionstr)
        {
            case "+":
                Console.WriteLine($"= {firstValue + secondValue}");
                break;
            case "-":
                Console.WriteLine($"= {firstValue - secondValue}");
                break;
            case "/":
                Console.WriteLine($"={firstValue / secondValue}");
                break;
            case "*":
                Console.WriteLine($"={firstValue * secondValue}");
                break;
            case "%":
                Console.WriteLine($"={firstValue * secondValue / 100}");
                break;
           
            default:
                Console.WriteLine("You enter the wrong action button");
                Console.WriteLine("Enter the action again");
                actionstr = Console.ReadLine();
                break;

        }
    }
}