using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double computeArea()
        {
            double halfPerimeter = computePerimeter() / 2;
            return Math.Sqrt(halfPerimeter*(halfPerimeter - A)*(halfPerimeter - B)*(halfPerimeter - C));
        }

        public override double computePerimeter()
        {
            return this.A + this.B + this.C;
        }

        public override string getDescription()
        {
            return "Triangle de coté A=" + this.A + ", B=" + this.B + ", C=" + this.C;
        }
    }
}
