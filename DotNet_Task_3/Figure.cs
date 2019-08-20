using System;

namespace DotNet_Task_3
{
    class Figure: IDrawable
    {
       

        public void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.Draw();
            } 
        }

        public void Draw()
        {
            Console.WriteLine("In Draw method of Figure class");
        }

        public int X { get; }
        public int Y { get; }

        public Figure (int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
