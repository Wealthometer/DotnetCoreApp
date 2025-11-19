using System;

namespace _04_07_GeometryTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // we instantiate the square with an instantiated width property of 2 
            var square = new Square() { Width = 2 };
            // we instantiate the triangle with an instantiated base property of 2 & height of 5
            var triangle = new Triangle() { Base = 2, Height = 5 }; 

            // we both square & triangle methods(OLD)
            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(triangle.GetArea());

            // we both square & triangle methods(NEW)
            square.Display();
            triangle.Display();
        }
    }


    abstract class Shape
    {
        public abstract int GetArea();

        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());        
        } 
         
    }

    class Square : Shape
    {
        public int Width;

        // we unify the function with the abstract class function above
        public override int GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        // we unify the function with the abstract class function above
        public override int GetArea()
        {
            return (Base * Height) / 2;
        }
    }
}
