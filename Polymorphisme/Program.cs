using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Elfe elfe = new Elfe("legolas");
            Magicien magicien = new Magicien("toto");
            Orque orque = new Orque("méchant");

            ArrayList tableau = new ArrayList();
            tableau.Add(magicien);
            tableau.Add(elfe);

            foreach(Personnage personnage in tableau)
            {
                personnage.attack(orque);
            }
        }
    }
}
