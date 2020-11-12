using System;

namespace RectangleAndCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine("The area of a circle with a {myCircle.Radius} is {myCircle.CalculateArea()}\n)" + $"  and a perimeter of {myCircle.CalculatePerimeter()}");
            


            Rectangle myRectangle = new Rectangle();
            myRectangle.Width = 8;
            myRectangle.Length = 7;
            Console.WriteLine("The area of a rectangle with {myCircle.Width} and {myRectangle.Length} is {myRectangle.CalculateArea()}\n" + "  and a perimeter of {myRectangle.CalculatePerimeter()}");

            Console.ReadKey();


        }
    }
}
