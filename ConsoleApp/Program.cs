using System.Numerics;
using ConsoleApp;
using static System.Console;

Write("You put in an integer, and I will give you the factorial of that integer: ");

string? input = ReadLine();

try
{
    WriteLine(MyFactorial.FactorialThis(BigInteger.Parse(input)));
}
catch
{
    WriteLine("Invalid input. Try again later");
}


