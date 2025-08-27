namespace Shapes;

public class Rectangle : IShape
{
    public double Length { get; }
    public double Width { get; }

    public Rectangle(double length, double width)
    {
        if (length < 0 || width < 0)
        {
            throw new ArgumentException("Length and Width must be non-negative.");
        }
        Length = length;
        Width = width;
    }

    public double Area()
    {
        return Length * Width;
    }
}
