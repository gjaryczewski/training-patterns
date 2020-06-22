using System;

namespace FactoryMethod
{
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType == "CIRCLE")
            {
                return new Circle();
            }
            else if (shapeType == "RECTANGLE")
            {
                return new Rectangle();
            }
            else if (shapeType == "SQUARE")
            {
                return new Square();
            }

            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            Shape shape1 = shapeFactory.GetShape("CIRCLE");

            //call draw method of Circle
            shape1.draw();

            //get an object of Rectangle and call its draw method.
            Shape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call draw method of Rectangle
            shape2.draw();

            //get an object of Square and call its draw method.
            Shape shape3 = shapeFactory.GetShape("SQUARE");

            //call draw method of square
            shape3.draw();
        }
    }
}
