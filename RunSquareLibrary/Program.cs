using LibrarySquare;

class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square(5);
        Console.WriteLine(square.GetSquare());     
    }
}
public class Square : Shape
{
    public double Lenght { get; set; }
    public Square(double lenght)
    {
        Lenght = lenght;
    }

    public override double GetSquare()
    {
        Area = Lenght * Lenght;
        return Area;
    }
}