using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    class Carre : Rectangle
    {
        public new int Largeur
        {
            get { return this.Longueur; }
            set { this.Longueur = value; }
        }

        public override double computeArea()
        {
            return this.Longueur * this.Longueur;
        }

        public override double computePerimeter()
        {
            return this.Longueur * 4;
        }

        public override string getDescription()
        {
            return "Carré de coté=" + this.Longueur;
        }
    }
}
