﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numero = 1;
            while(numero <= 10)
            {
                Console.WriteLine(numero);
                Console.ReadKey();

                numero++;   
            }
        }
    }

}
