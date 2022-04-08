using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            double cal1, cal2, cal3, cal4, cal5, cal6, cal7, prom;

            //Hacemos la primera peticion
            Console.Write("Dame la calificacion del primer alumno: ");
            cal1 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la segunda peticion
            Console.Write("Dame la calificacion del segundo alumno: ");
            cal2 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la tercera peticion
            Console.Write("Dame la calificacion del tercer alumno: ");
            cal3 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la tercera peticion
            Console.Write("Dame la calificacion del cuarto alumno: ");
            cal4 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la tercera peticion
            Console.Write("Dame la calificacion del quinto alumno: ");
            cal5 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la tercera peticion
            Console.Write("Dame la calificacion del sexto alumno: ");
            cal6 = Convert.ToDouble(Console.ReadLine());

            //Hacemos la tercera peticion
            Console.Write("Dame la calificacion del septimo alumno: ");
            cal7 = Convert.ToDouble(Console.ReadLine());

            //Calculamos el promedio
            prom = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6 + cal7) / 7;

            //Mostramos el promedio
            Console.WriteLine("El promedio es: {0}", prom);
            Console.ReadKey();
        }
    }
}
