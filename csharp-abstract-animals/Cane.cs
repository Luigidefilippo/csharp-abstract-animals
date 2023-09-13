using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animale , INuotante , ICamminante 
    {
        public override void GetName()
        {
            Console.WriteLine("Maradona the dog");
        }
        public override void Verso()
        {
            Console.WriteLine("BAU BAU");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Mangio croccantini");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando a cagnolino ");
        }
        public void Cammino()
        {
            Console.WriteLine("Passeggio");
        }
    }
}
