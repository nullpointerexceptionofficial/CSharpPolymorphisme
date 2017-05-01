using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Magicien : Personnage
    {
        public Magicien() : base()
        {

        }

        public Magicien(string nom) : base(nom)
        {

        }
        public override void attack(Personnage personnage)
        {
            Console.WriteLine(Nom + " attaque " + personnage.Nom);
            Console.WriteLine(personnage.Pv);
            personnage.Pv -= 40;
            Console.WriteLine(personnage.Pv);
        }
    }
}
