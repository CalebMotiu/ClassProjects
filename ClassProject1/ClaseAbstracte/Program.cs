namespace ClaseAbstracte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(12);
            s.PrintArea();
            s.PrintPerimeter();

            Circle c = new Circle(4);
            c.PrintArea();
            c.PrintPerimeter();
            c.PrintDiameter();
        }
    }
}
