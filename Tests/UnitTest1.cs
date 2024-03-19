using ConsoleApp;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var result = MyFactorial.FactorialThis(1);
        Assert.Equal((double)result, (double)1);
    }

    [Fact]
    public void Test0()
    {
        var result = MyFactorial.FactorialThis(0);
        Assert.Equal((double)result, (double)1);
    }

    [Fact]
    public void Test10()
    {
        var result = MyFactorial.FactorialThis(10);
        Assert.Equal((double)result, (double)3628800);
    }
}