using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//leen el nombre y 3 calificaciones de un alumno e impriman su promedio
namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumn;
            alumn = new Alumno();
            alumn.leer();
            Console.Write(alumn.nombre);
        }
    }
}
