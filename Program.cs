using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        Circle circleDefault = new Circle();
        Console.WriteLine("Circle:");
        Console.WriteLine(circleDefault);

        Circle circle1 = new Circle(2, "Pink");
        Console.WriteLine("Circle:");
        Console.WriteLine(circle1);
        circle1.SetColor("White");
        Console.WriteLine("Circle:");
        Console.WriteLine(circle1);

        /*Cylinder cylinderDefautl = new Cylinder();
        Console.WriteLine("Cylinder:");
        Console.WriteLine(cylinderDefautl);

        Cylinder cylinder1 = new Cylinder(2, "Xanh", 3);
        Console.WriteLine("Cylinder:");
        Console.WriteLine(cylinder1);*/
    }
}

public class Circle
{
    protected double Radius { get; set; }
    protected string Color { get; set; }

    public Circle()
    {
        Radius = 0;
        Color = "Black";
    }
    public Circle(double Radius, string Color)
    {
        this.Radius = Radius;
        this.Color = Color;
    }

    public void SetColor(string Color)=> this.Color = Color;

    public double GetArea() => Radius * Radius * Math.PI;

    public double GetPerimeter() => 2 * Radius * Math.PI;


    public override string ToString()
    {
        return $"- Radius: {Radius}\n- Color: {Color}\n- Area: {GetArea():F2}\n- Perimeter: {GetPerimeter():F2}\n";
    }
}

public class Cylinder : Circle
{
    private double Height { get; set; }

    public Cylinder() : base()
    {
        Height = 0;
    }
    public Cylinder(double Radius, string Color, double Height) : base(Radius, Color)
    {
        this.Height = Height;
    }

    public double GetVolume()
    {
        return GetArea() * Height;
    }

    public override string ToString()
    {
        return base.ToString() +
                $"- Height: {Height}\n- Volume: {GetVolume():F2}\n";
    }
}