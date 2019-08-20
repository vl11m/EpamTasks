namespace DotNet_Task_2
{
    using System;

    internal class Rectangle
    {
        private int dovzh;
        private int shir;
        private int a_x;
        private int a_y;
        private int b_x;
        private int b_y;

        public Rectangle(int a_x, int a_y, int b_x, int b_y)
        {
            this.a_x = a_x;
            this.a_y = a_y;
            this.b_y = b_y;
            this.b_x = b_x;

            this.Check();
        }

        public Rectangle()
        {
        }

        public int A_x { get { return this.a_x; } set { this.a_x = value; } }

        public int A_y { get { return this.a_y; } set { this.a_y = value; } }

        public int B_x { get { return this.b_x; } set { this.b_x = value; } }

        public int B_y { get { return this.b_y; } set { this.b_y = value; } }

        public void Check()
        {
            if (this.a_x < this.b_x && this.a_y > this.b_y)
            {
                if (this.a_x < 0 && this.b_x < 0)
                {
                    this.dovzh = this.b_x - this.a_x;
                }

                if (this.a_x >= 0 && this.b_x > 0)
                {
                    this.dovzh = this.b_x - this.a_x;
                }

                if (this.a_x < 0 && this.b_x >= 0)
                {
                    this.dovzh = this.b_x + (this.a_x * -1);
                }

                if (this.a_y > 0 && this.b_y >= 0)
                {
                    this.shir = this.a_y - this.b_y;
                }

                if (this.a_y > 0 && this.b_y < 0)
                {
                    this.shir = this.a_y + (this.b_y * -1);
                }

                if (this.a_y <= 0 && this.b_y < 0)
                {
                    this.shir = (this.b_y - this.a_y) * -1;
                }
            }
            else
            {
                Console.WriteLine("Please at first enter the coordinates of the upper left corner point and then the lower right corner");
            }
        }

        public int Perimeter()
        {
            return (this.dovzh + this.shir) * 2;
        }

        public int Area()
        {
            return this.dovzh * this.shir;
        }
    }
}
