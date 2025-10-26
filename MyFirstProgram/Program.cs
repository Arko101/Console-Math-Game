// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.WriteLine("Enter two numbers for calculation:");

double num1 = double.Parse(Console.ReadLine());

double num2 = double.Parse(Console.ReadLine());

bool running = true;

while (running)
{

    Console.WriteLine("Select operation to perform:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");

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

        default:
            running = false;
            break;
    }

}

double add(double a, double b)
{
    double result =  a + b;
    Console.WriteLine("The sum is: " + result);
    return result;
}

double subtract(double a, double b)
{
    if (a > b)
    {
        double result = a - b;
        Console.WriteLine("The answer is:" + result);
        return result;
    }
    else
    {
        double result = b - a;
        Console.WriteLine("The answer is:" + result);
        return result;
    }
}

double multiply(double a, double b)
{
    double result = a * b;
    Console.WriteLine("The product is: " + result);
    return result;
}

int divide(double a, double b)
{
    if (b != 0)
    {
        double div = a / b;
        int divInt = (int)div;
        Console.WriteLine("The result is :" + divInt);
        return divInt;

    }
    else
    {
        throw new DivideByZeroException("Division by zero is not allowed.");
    }
}