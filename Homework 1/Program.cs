// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a C# Sharp program that takes two numbers as user input and perform an operation on them and displays the result of that operation.");

Console.WriteLine("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("**********************\n");

Console.WriteLine("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("**********************\n");

Console.WriteLine("Enter operation (+, -, *, /): ");
char operation = Convert.ToChar(Console.ReadLine());

double result = 0;

switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
    
}

Console.WriteLine("Result: " + result);
Console.ReadKey();


