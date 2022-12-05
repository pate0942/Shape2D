//using System;
public abstract class Shape2D{
  public double X {get; set;}
  public double Y {get; set;}  
  public double NumberOfSides { get; }

  public abstract double Area();

  public abstract double Perimeter();

  public override string ToString()
  {
     return  $"A shape at position {X}, {Y}" ;
  }

public Shape2D(double x, double y, double numberOfSides)
{
    this.X = x;
    this.Y = y;
    this.NumberOfSides = numberOfSides;
}

static void Main(string[] args)
{
  Rectangle rect = new Rectangle(5.5,4.5,4,4,4);
  Circle crl = new Circle(10.5,4,4,1);

  double Area = rect.Area();
  Console.WriteLine("The area of the rectangle is" + " " + Area);

  double Perimeter = crl.Perimeter();
  Console.WriteLine("The perimeter of the Circle is" + " " + Perimeter);

}
}
