using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void PositiveRadiusTest()
    {
        IShape circle = new Circle(3);
        double result = circle.Area();
        double expected = Math.PI * 3 * 3;
        Assert.AreEqual(expected, result, 1e-7);
    }

    [TestMethod]
    public void ZeroRadiusTest()
    {
        IShape circle = new Circle(0);
        double result = circle.Area();
        Assert.AreEqual(0, result, 1e-7);
    }

    [TestMethod]
    public void NegativeRadiusTest()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(-3));
    }
}
