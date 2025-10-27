// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.WriteLine("Enter two numbers for calculation:");

double num1 = double.Parse(Console.ReadLine());

double num2 = double.Parse(Console.ReadLine());

bool running = true;
List<string> solution = new List<string>();

while (running)
{

    Console.WriteLine("Select operation to perform:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Previous solutions");
    Console.WriteLine("6. Exit");

    Console.WriteLine("Enter choice of operation");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            add(num1, num2);
            break;

        case 2:
            subtract(num1, num2);
            break;

        case 3:
            multiply(num1, num2);
            break;

        case 4:
            divide(num1, num2);
            break;
        case 5:

            renderList();
            break;
            case 6:
            running = false;
            break;

        default:
            Console.WriteLine("Invalid Input");
            break;
    }

}

double add(double a, double b)
{
    double result =  a + b;
    Console.WriteLine("The sum is: " + result);
    solution.Add($"The result of addition was {result}");
    return result;
}

double subtract(double a, double b)
{
    if (a > b)
    {
        double result = a - b;
        Console.WriteLine("The answer is:" + result);
        solution.Add($"The result of substraction was {result}");
        return result;
    }
    else
    {
        double result = b - a;
        Console.WriteLine("The answer is:" + result);
        solution.Add($"The result of substraction was {result}");
        return result;
    }
}

double multiply(double a, double b)
{
    double result = a * b;
    Console.WriteLine("The product is: " + result);
    solution.Add($"The result of multiplication was {result}");
    return result;
}

int divide(double a, double b)
{
    if (b != 0)
    {
        double div = a / b;
        int divInt = (int)div;
        Console.WriteLine("The result is :" + divInt);
        solution.Add($"The result of division was {divInt}");
        return divInt;

    }
    else
    {
        throw new DivideByZeroException("Division by zero is not allowed.");
    }
}

void renderList(){
    Console.Clear();
    Console.WriteLine("Previous solutions:");
    foreach (var sol in solution)
    {
        Console.WriteLine(sol);
    }
}