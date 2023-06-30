using System;
namespace Learnig05
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape Square = new Square("Blue", 6);
            Rectangle Rectangle = new Rectangle("Green",5,7);
            Circle Circle = new Circle("Red", 8);

            List<Shape> Shapes = new List<Shape>();

            Shapes.Add(Square);
            Shapes.Add(Rectangle);
            Shapes.Add(Circle);

            foreach (Shape shape in Shapes)
            {
                Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}\n");
            }
                       
        }

    }
}