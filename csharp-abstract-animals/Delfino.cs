using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale 
    {
        public override void GetName()
        {
            Console.WriteLine("Delfino Armando");
        }
        public override void Verso()
        {
            Console.WriteLine("Delfino");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Mangia pesci e crostacei");
        }
    }
}
