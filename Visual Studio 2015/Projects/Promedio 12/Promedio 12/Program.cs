using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno = new Alumno();
            alumno.leer();
            Console.WriteLine("Promedio = {0}", alumno.promedio);
               
        }
    }
}
