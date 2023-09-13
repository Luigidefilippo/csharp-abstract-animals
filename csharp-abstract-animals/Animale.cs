using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("ZzzzZ");
        }
        public abstract void GetName();
        public abstract void Verso();
        public abstract void CosaMangi();
    }
}
