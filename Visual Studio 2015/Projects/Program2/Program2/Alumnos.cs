using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Alumnos
    {
        //Atributo
        //private string _nombre;

        //Propiedades
        //public string nombre
        //{
        //get { return _nombre; }
        //set { _nombre = value; }
        //}
        public string nombre { get; set;}

        //Metodos

        //sintaxis
        //MA tipo_retorno Nombre ([parametros)]
        //Definicion de un metod
        public void leer()
        {
            Console.Write("Nombre. ");
            nombre = Console.ReadLine();            
        }
    }
}