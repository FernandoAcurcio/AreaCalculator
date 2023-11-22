namespace AreaCalculator
{
    public class Circle : Shape, IDrawable
    {
        public Circle(double radius) : base(radius, radius)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * width * width / 4;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
