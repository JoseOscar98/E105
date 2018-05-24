using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_12
{
    class Alumno
    {
        public string nombre { get; set; }
        public decimal c1 { get; set; }
        public decimal c2 { get; set; }
        public decimal c3 { get; set; }
        public decimal promedio { get; set; }
        public void leer()
        {
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Calificacion 1: ");
            c1 = decimal.Parse(Console.ReadLine());

            Console.Write("Calificacion 2: ");
            c2 = decimal.Parse(Console.ReadLine());

            Console.Write("Calificacion 3: ");
            c3 = decimal.Parse(Console.ReadLine());
            promedio = (c1 + c2 + c3) / 3;
        }
    }
}
