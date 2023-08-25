using LibrarySquare;

class Program
{
    public static void Main(string[] args)
    {
        Triangle triangle = new Triangle(3, 5, 7);
        Console.WriteLine(triangle.GetSquare());

        Console.WriteLine(new string('-',18));

        Circle circle = new Circle(10);
        Console.WriteLine(circle.GetSquare());
    }
}