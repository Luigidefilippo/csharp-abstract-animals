using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale 
    {
        public override void GetName()
        {
            Console.WriteLine("Giacomo");
        }
        public override void Verso()
        {
            Console.WriteLine("Cinguettio");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Mangio semi ");
        }
    }
}
