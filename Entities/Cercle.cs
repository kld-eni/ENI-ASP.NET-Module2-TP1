using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double computeArea()
        {
            return Math.PI * this.Rayon * this.Rayon;
        }

        public override double computePerimeter()
        {
            return Math.PI * 2 * this.Rayon;
        }

        public override string getDescription()
        {
            return "Cercle de rayon=" + this.Rayon;
        }
    }
}
