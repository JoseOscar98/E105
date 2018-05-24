using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class operaciones
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int suma { get; set; }
        public int resta { get; set; }
        public int multipli { get; set; }
        public int division { get; set; }

        public void leer()
        {
            Console.Write("Numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Numero 2:");
            num2 = int.Parse(Console.ReadLine());
        }
        public void Calcularsuma()
        {
            suma = num1 + num2;
        }
        public void Calcularesta()
        {
            resta = num1 - num2;
        }
        public void Calcularmulti()
        {
            multipli = num1 * num2;
        }
        public void Calculardiv()
        {
            division = num1 / num2;
        }
    }
}
