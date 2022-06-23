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
}