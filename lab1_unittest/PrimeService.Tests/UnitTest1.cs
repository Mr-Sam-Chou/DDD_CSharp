using System;
namespace Prime.Service.Tests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine("Ready!!");
    }
    [TearDown]
    public void StoreData()
    {
        Console.WriteLine("Reverted!!");
    }
    [OneTimeSetUp]
    public void init()
    {
         //Console.WriteLine("onetime start action");
        TestContext.Progress.WriteLine("onetime start action");
    }
    [OneTimeTearDown]
    public void finalize()
    {
        //Console.WriteLine("onetime finalize action");
        TestContext.Progress.WriteLine("onetime finalize action");
    }
    [Test]
    public void Test1()
    {
        Console.WriteLine("Test test1");
        Assert.Pass();
    }
    [Test]
    [Ignore("to do....")]
    public void Test2()
    {
        Console.WriteLine("Test test2");
        Assert.Fail("Test Fail");
    }
}