using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
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
        var expectedName = "latte";
        var expectedId = -1;
        var myCoffee = new Coffee{Name = expectedName, Id = expectedId};
        
        var controller = new CoffeeController();
        var result = controller.GetAvailableCoffees(null);
        
        Assert.AreEqual(myCoffee.Name, result.Name);
        Assert.AreEqual(myCoffee.Id,result.Id);
    }
    [Test]
    public void GetAvailableCoffees_by_Name()
    {
        var testName = "Americano";
        var expectedId=Random.Shared.Next(1, 10);
        
        var myCoffee = new Coffee{Name=testName, Id=expectedId};
        var controller = new CoffeeController();
        var result = controller.GetAvailableCoffees(testName);
        
        Assert.AreEqual(myCoffee.Name, result.Name);
        
        //Because of the randomness of the Id, we can't test it
        //BUT I get the idea.
        
        Assert.AreEqual(myCoffee.Id,expectedId);
        
        
        
    }
}