using System.Numerics;

namespace ConsoleApp;

public static class MyFactorial
{
    public static BigInteger FactorialThis(BigInteger input)
    {
        BigInteger result = 1;
        for (BigInteger i = input; i > 0; i--)
            result *= i;
        return result;
    }
}