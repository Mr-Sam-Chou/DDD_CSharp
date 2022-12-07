using System;
using Prime.Service;
namespace Prime.Service.Tests;

[TestFixture]
public class Tests2
{
    private PrimeService primeService = null!;
    [OneTimeSetUp]
    public void prepare()
    {
        primeService = new PrimeService();
    }
    [Test]
    public void test1()
    {
        bool result = primeService.IsPrime(3);
        Assert.IsFalse(result, "Is not be a prime");
        Console.WriteLine("Test2");
    }
}