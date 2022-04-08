using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; //Operador
            i = 10;
            Console.WriteLine("Valor inicial del operador: {0}", i);
            Console.ReadKey();

            //Incremento como sufijo e imprimimos
            Console.WriteLine("Valor con incremento incluido: {0}", i++);
            Console.ReadKey();

            //Ya no estamos incrementando, solo imprimimos
            Console.WriteLine(i);
            Console.ReadKey();

            int n = 20;
            Console.WriteLine("----------------");
            Console.ReadKey();

            Console.WriteLine("Valor inicial del operador: {0}", n);
            Console.ReadKey();

            //Decremento como sufijo e impresion
            Console.WriteLine("Valor con dremento incluido: {0}", n--);
            Console.ReadKey();

            Console.WriteLine(n);
            Console.ReadKey();  
        }
    }
}
