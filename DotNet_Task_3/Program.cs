using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(5, 2);
            Rectangle rectangle = new Rectangle(5, 2); ;
            Square square = new Square(5, 2);
            rectangle.Draw();
            square.Draw();
            figure.Draw();
            Console.WriteLine();
            figure.DrawAll(square, rectangle, figure);
        }
    }
}
