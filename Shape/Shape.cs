using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        // test for pushing to github
        static void Main()
        {
            Console.WriteLine("pushing to github");
            Console.WriteLine("change has been made");
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}