namespace Shapes;

public class Triangle : IShape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(double b, double h)
    {
        if (b < 0 || h < 0)
        {
            throw new ArgumentException("Base and Height must be non-negative.");
        }
        Base = b;
        Height = h;
    }

    public double Area()
    {
        return 0.5 * Base * Height;
    }
}
