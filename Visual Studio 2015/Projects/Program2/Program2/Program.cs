using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //La funcion principal o el punto de inicio del proyecto
            Alumnos alumno;//Declaracion de una variable
            alumno = new Alumnos(); //Se instancía un objeto

            //alumno.nombre == "Alumno";
            //Invocacion de un Metodo
            alumno.leer();

            Console.Write(alumno.nombre);

            //Alumnos objeto = new Alumnos();
        }
    }
}
