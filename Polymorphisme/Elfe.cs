using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Elfe : Personnage
    {
        public Elfe() : base()
        {

        }

        public Elfe(string nom) : base(nom)
        {

        }
        public override void attack(Personnage personnage)
        {
            Console.WriteLine(Nom + " attaque " + personnage.Nom);
            Console.WriteLine(personnage.Pv);
            personnage.Pv -= 20;
            Console.WriteLine(personnage.Pv);
        }
    }
}
