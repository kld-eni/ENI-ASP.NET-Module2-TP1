using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Rectangle : Forme
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public override double computeArea()
        {
            return this.Largeur * this.Longueur;
        }

        public override double computePerimeter()
        {
            return (this.Longueur + this.Largeur) * 2;
        }

        public override string getDescription()
        {
            return "Rectangle de longueur=" + this.Longueur + " et largeur=" + this.Largeur;
        }
    }
}
