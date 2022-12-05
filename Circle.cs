public class Circle : Shape2D
{
   public double radius{get; set;}
   double pi = Math.PI;

        public override double Area()
        {
            return  pi * radius * radius  ;
        }

        public override double Perimeter()
        {
            return 2 * pi * radius ;
        }

        public override string ToString()
        {
            return  $"A circle at position {X}, {Y} with radius of {radius}" ;
        }

        public Circle(double radius,double x, double y,double numberOfSides)
            :base(numberOfSides,x,y)
        {
            this.radius =radius;
        }

}


  
