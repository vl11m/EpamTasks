namespace DotNet_Task_2
{
    using System;

    internal static class RectangleStatic
    {
        private static int dovzh;
        private static int shir;

        public static int Perimeter(int a_x, int a_y, int b_x, int b_y)
        {
            if (a_x < b_x && a_y > b_y)
            {
                if (a_x < 0 && b_x < 0)
                {
                   dovzh = b_x - a_x;
                }

                if (a_x >= 0 && b_x > 0)
                {
                    dovzh = b_x - a_x;
                }

                if (a_x < 0 && b_x >= 0)
                {
                    dovzh = b_x + (a_x * -1);
                }

                if (a_y > 0 && b_y >= 0)
                {
                    shir = a_y - b_y;
                }

                if (a_y > 0 && b_y < 0)
                {
                    shir = a_y + (b_y * -1);
                }

                if (a_y <= 0 && b_y < 0)
                {
                    shir = (b_y - a_y) * -1;
                }

                return (dovzh + shir) * 2;
            }
            else
            {
                Console.WriteLine("Please at first enter the coordinates of the upper left corner point and then the lower right corner");
                return 0;
            }
        }

        public static int Area(int a_x, int a_y, int b_x, int b_y)
        {
            if (a_x < b_x && a_y > b_y)
            {
                if (a_x < 0 && b_x < 0)
                {
                    dovzh = b_x - a_x;
                }

                if (a_x >= 0 && b_x > 0)
                {
                    dovzh = b_x - a_x;
                }

                if (a_x < 0 && b_x >= 0)
                {
                    dovzh = b_x + (a_x * -1);
                }

                if (a_y > 0 && b_y >= 0)
                {
                    shir = a_y - b_y;
                }

                if (a_y > 0 && b_y < 0)
                {
                    shir = a_y + (b_y * -1);
                }

                if (a_y <= 0 && b_y < 0)
                {
                    shir = (b_y - a_y) * -1;
                }

                return dovzh * shir;
            }
            else
            {
                Console.WriteLine("Please at first enter the coordinates of the upper left corner point and then the lower right corner");
                return 0;
            }
        }
    }
}
