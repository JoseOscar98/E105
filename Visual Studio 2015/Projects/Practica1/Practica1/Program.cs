using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            operaciones opera = new operaciones();
            opera.leer();
            opera.Calcularsuma();
            opera.Calcularesta();
            opera.Calcularmulti();
            opera.Calculardiv();
            Console.WriteLine("Suma = {0}", opera.suma);
            Console.WriteLine("Resta = {0}", opera.resta);
            Console.WriteLine("Multiplicacion = {0}", opera.multipli);
            Console.WriteLine("Division = {0}", opera.division);


        }
    }
}
