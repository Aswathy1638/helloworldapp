// See https://aka.ms/new-console-template for more information
class myCircle
{
    public double radius;

    public myCircle(double radius)
    {
        this.radius = radius;

    }

    public double GetArea()
    {
        double area;
        area = 3.14 * radius * radius;
        return area;
    }

    public double GetCircumference()
    {
        double circ;
        circ = 2 * 3.14 * radius;
        return circ;

    }
    public static void Main()
    {
        myCircle ci = new myCircle(5);
        Console.WriteLine("Area of Circle is :" + ci.GetArea());
        Console.WriteLine("Circumference of Circle is :" + ci.GetCircumference());
    }
}
