using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Task_3
{
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(int x, int y) : base(x, y)
        {
        }

        public new void Draw()
        {
            Console.WriteLine("In Draw method of Rectangle class"); ;
        }
    }
}
