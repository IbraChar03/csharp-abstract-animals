﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Passerotto : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("verso passerotto");
        }
        public override void Mangia()
        {
            Console.WriteLine("semi");
        }
    }
}
