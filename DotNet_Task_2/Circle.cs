namespace DotNet_Task_2
{
    internal class Circle
    {
        private readonly double pi = 3.14;
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public double Circuit()
        {
            return 2 * this.pi * this.r;
        }

        public double Area()
        {
            return this.pi * this.r * r;
        }
    }
}
