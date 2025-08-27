using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests;

[TestClass]
public class RectangleTests
{
    [TestMethod]
    public void PositiveLengthBreadthTest()
    {
        IShape rect = new Rectangle(4, 5);
        double expected = 4 * 5;
        double result = rect.Area();
        Assert.AreEqual(expected, result, 0.0);
    }

    [TestMethod]
    public void ZeroLengthOrWidthTest()
    {
        IShape rect1 = new Rectangle(0, 5);
        Assert.AreEqual(0, rect1.Area(), 0.0);
        IShape rect2 = new Rectangle(4, 0);
        Assert.AreEqual(0, rect2.Area(), 0.0);
    }

    [TestMethod]
    public void NegativeLengthOrWidthTest()
    {
        Assert.ThrowsException<ArgumentException>(() => new Rectangle(-4, 5));
        Assert.ThrowsException<ArgumentException>(() => new Rectangle(3, -5));
    }
}
