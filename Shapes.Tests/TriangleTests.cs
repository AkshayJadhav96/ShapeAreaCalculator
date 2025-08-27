using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void PositiveBaseAndHeight()
    {
        IShape tri = new Triangle(10, 5);
        double result = tri.Area();
        double expected = 0.5 * 10 * 5;
        Assert.AreEqual(expected, result, 0.0);
    }

    [TestMethod]
    public void ZeroBaseOrHeight()
    {
        var tri1 = new Triangle(0, 5);
        Assert.AreEqual(0, tri1.Area());
        var tri2 = new Triangle(8, 0);
        Assert.AreEqual(0, tri2.Area());
    }

    [TestMethod]
    public void NegativeHeightOrWidth()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(10, -5));
        Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, -5));
    }
}
