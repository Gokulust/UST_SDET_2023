﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle:Shape,IDrawable
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return 3.14*Radius*Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("Shape : Circle \nArea of Circle : {0} \nPerimeter of Circle : {1}",CalculateArea(),CalculatePerimeter());
        }
    }
}
