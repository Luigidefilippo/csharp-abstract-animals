﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale , IVolante
    {
        public override void GetName()
        {
            Console.WriteLine("Giacomo il passerotto");
        }
        public override void Verso()
        {
            Console.WriteLine("Cinguettio");
        }
        public override void CosaMangi()
        {
            Console.WriteLine("Mangio semi ");
        }
        public void Vola()
        {
            Console.WriteLine("Voleggio");
        }
    }
}
