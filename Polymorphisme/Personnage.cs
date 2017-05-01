using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    abstract class Personnage
    {
        private string nom;
        private int pv;

        public Personnage()
        {
            pv = 100;
        }

        public Personnage(string nom)
        {
            this.nom = nom;
            pv = 100;
        }

        public abstract void attack(Personnage personnage);

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }
    }
}
