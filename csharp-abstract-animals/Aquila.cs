using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        public override void GetName()
        {
            Console.WriteLine("Falco");
        }
        public override void Verso()
        {
            Console.WriteLine("Aquileggia");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Mangio mammiferi");
        }
    }
}
