using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
           return Length*Width;
        }

        public override double CalculatePerimeter()
        {
           return 2 * (Length + Width);
        }
        public void Draw()
        {
            Console.WriteLine("Shape : Rectangle \nArea of Rectangle : {0} \nPerimeter of Rectangle : {1}", CalculateArea(), CalculatePerimeter());
        }
    }
}
