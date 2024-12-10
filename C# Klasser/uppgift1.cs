

public class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
 }

 class Program
 {
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);
        Console.WriteLine("Radius: " + circle.Radius);
        Console.WriteLine("Circumference: " + circle.GetCircumference());
        Console.WriteLine("Area: " + circle.GetArea());
    }
}