namespace ShapeInteraces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(2);

            Rectangle rectangle = new Rectangle(2, 4);

            Triangle triangle = new Triangle(9, 5, 7, 6);

            circle.DisplayDetails();
            Console.WriteLine();

            rectangle.DisplayDetails();
            Console.WriteLine();
            
            triangle.DisplayDetails();
            Console.WriteLine();
        }
    }
}