﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("ZZZZ");

        }
        public abstract void Verso();
        public abstract void Mangia();
        public void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }
        public void FaiNuotare(INuotante animale)
        {
           animale.Nuota();
        }


    }
}
