// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter two numbers for calculation:");

int num1 = int.Parse(Console.ReadLine());

int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter choice of operation");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Addition: " + (num1 + num2));
        break;
    case 2:
        if (num1 > num2)
        {
            Console.WriteLine("Subtraction: " + (num1 - num2));
        }
        else
        {
            Console.WriteLine("Subtraction: " + (num2 - num1));
        }
        break;
    case 3:
        Console.WriteLine("Multiplication: " + (num1 * num2));
        break;
    case 4:
        if (num2 != 0)
        {
            Console.WriteLine("Division: " + (num1 / num2));
        }
        else
        {
            Console.WriteLine("Error: Division by zero");
        }
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

