using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Calif
    {

        public int calif1, calif2, calif3 { get; set; }

        public void leer()
        {
            Console.Write("Calificacion 1: ");
            calif1 = Console.ReadLine();
        }
    }
}
