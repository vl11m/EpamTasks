using System;

namespace DotNet_Task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Rectangle

            int Ax, Ay, Bx, By;

            #region run with constructor
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Please enter coordinates of left upper and right down corners. Format: Ax Ay Bx By (ex: 5 10 10 5)");
                string[] coordinates = Console.ReadLine().Split(new char[] { ';', '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (coordinates.Length == 4)
                {
                    if (int.TryParse(coordinates[0], out Ax) && int.TryParse(coordinates[1], out Ay)
                  && int.TryParse(coordinates[2], out Bx) && int.TryParse(coordinates[3], out By))
                    {
                        Rectangle rectangle1 = new Rectangle(Ax, Ay, Bx, By);
                        Console.Write("Perimeter of rectangle is ");
                        Console.WriteLine(rectangle1.Perimeter());
                        Console.Write("Area of rectangle is ");
                        Console.WriteLine(rectangle1.Area());
                    }
                }
                else
                {
                    Console.WriteLine("Invalid data");
                }

                Console.WriteLine("You want to continue? (yes or no)");
                string contin = Console.ReadLine();
                if (contin == "no" || contin == "n")
                {
                    exit = false;
                }
            }

            #endregion

            Rectangle rectangle2 = new Rectangle();
            rectangle2.A_x = 5;
            rectangle2.A_y = 10;
            rectangle2.B_x = 10;
            rectangle2.B_y = 5;
            rectangle2.Check();
            Console.Write("Area of rectangle with auto-implemented properties is ");
            Console.WriteLine(rectangle2.Area());
            Console.Write("Perimeter of rectangle with auto-implemented properties is ");
            Console.WriteLine(rectangle2.Perimeter());
            #endregion

            #region Circle
            Circle circle = new Circle(10);
            Console.Write("Circuit is ");
            Console.WriteLine(circle.Circuit());
            Console.Write("Area of circle is ");
            Console.WriteLine(circle.Area());

            #endregion

            #region Static clases
            Console.Write("Area of static-class rectangle is ");
            Console.WriteLine(RectangleStatic.Area(5, 10, 10, 5));
            Console.Write("Area of static-class circle is ");
            Console.WriteLine(CircleStatic.Area(10));

            #endregion

        }
    }
}
