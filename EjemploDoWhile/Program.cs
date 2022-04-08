using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 15;
            do
            {
                Console.WriteLine(i);
                i++;
                Console.ReadKey();
            }
            while (i <= 10);
            }
    }
}
