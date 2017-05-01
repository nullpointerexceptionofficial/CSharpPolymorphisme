using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Orque : Personnage
    {

        public Orque() : base()
        {

        }

        public Orque(string nom) : base(nom)
        {

        }
        public override void attack(Personnage personnage)
        {
            Console.WriteLine(Nom + " attaque " + personnage.Nom);
            Console.WriteLine(personnage.Pv);
            personnage.Pv -= 10;
            Console.WriteLine(personnage.Pv);
        }
    }
}
