using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Rectangle: Shape, IDrawable
    {
        public Rectangle(double width, double height) : base (width, height)
        {
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
