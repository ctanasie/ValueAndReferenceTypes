using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

        /// <summary>
        /// A custom constructor
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        /// <summary>
        /// Add 1 to the (X, Y) position. 
        /// </summary>
        public void Increment()
        {
            X++;
            Y++;
        }

        /// <summary>
        /// Subtract 1 from the (X, Y) position.
        /// </summary>
        public void Decrement()
        {
            X--;
            Y--;
        }

        /// <summary>
        /// Display the current position.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class PointRef
    {
        public int X;
        public int Y;

        /// <summary>
        /// Same members as the Point structure...
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        public PointRef(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        /// <summary>
        /// Add 1 to the (X, Y) position. 
        /// </summary>
        public void Increment()
        {
            X++;
            Y++;
        }

        /// <summary>
        /// Subtract 1 from the (X, Y) position.
        /// </summary>
        public void Decrement()
        {
            X--;
            Y--;
        }

        /// <summary>
        /// Display the current position.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAssignment();
            ReferenceTypeAssignment();
            ValueTypeContainingRefType();

            Console.ReadLine();
        }

        /// <summary>
        /// Assigning two intrinsic value types results in
        /// two independent variables on the stack.
        /// </summary>
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types.\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            // Print both points.
            p1.Display();
            p2.Display();

            // Change p1.X and print again. p2.X is not changed.
            p1.X = 100;
            Console.WriteLine("\nChanged p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types.\n");

            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            // Print both point refs.
            p1.Display();
            p2.Display();

            // Change p1.X and print again.
            p1.X = 100;
            Console.WriteLine("\n=>Changed p1.X\n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            // Create the first rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Now, assign a new Rectangle to r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            // Print values of both rectangles.
            r1.Display();
            r2.Display();
        }
    }
}
