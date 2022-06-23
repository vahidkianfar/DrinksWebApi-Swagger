using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers;

public class CoffeeControllerTests
{
    [Test]
    public void TestCoffeeLover()
    {
        var expectedContent = "I like coffee!";
        var controller = new CoffeeController();
        var result = controller.GetLoveTheCoffee();
        Assert.AreEqual(expectedContent, result);
    }
    [Test]
    public void GetAvailableCoffees_by_NULL()
    {
        var expectedContent = "latte";
        var controller = new CoffeeController();
        var result = controller.GetAvailableCoffees(null);
        
        Assert.AreEqual(expectedContent, result.Name);
    }
    [Test]
    public void GetAvailableCoffees_by_Name()
    {
        var expectedContent = "Americano";
        var controller = new CoffeeController();
        var result = controller.GetAvailableCoffees("Americano");
        
        Assert.AreEqual(expectedContent, result.Name);
    }
}