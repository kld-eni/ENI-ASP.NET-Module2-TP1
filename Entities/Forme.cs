using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    abstract class Forme
    {
        public abstract double computeArea();
        public abstract double computePerimeter();
        public abstract string getDescription();

        public override string ToString()
        {
            string description = this.getDescription();
            string area = "Aire = " + this.computeArea();
            string perimeter = "Périmètre = " + this.computePerimeter();
            return description + "\n" + area + "\n" + perimeter + "\n";
        }
    }
}
