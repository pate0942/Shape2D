
public class Rectangle : Shape2D
{

    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }

    public override string ToString()
    {
        return $"A rectangle at position {X}, {Y} with dimensions {Width} x {Height}";
    }
    public Rectangle(double width, double height, double x, double y, double numberOfSides)
    : base (numberOfSides, x, y)
    {
        this.Width = width;
        this.Height = height;
    }
}