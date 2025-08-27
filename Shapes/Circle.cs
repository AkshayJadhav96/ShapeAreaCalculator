namespace Shapes;
public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius must be non-negative.");
        }
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
