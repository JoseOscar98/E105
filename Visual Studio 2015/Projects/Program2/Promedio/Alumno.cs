using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Alumno
    {

        public string nombre { get; set; }

        public void leer()
        {
            Console.Write("Nombre del alumno: ");
            nombre = Console.ReadLine();
        }
    }
}
