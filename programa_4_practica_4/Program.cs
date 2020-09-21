using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_4_practica_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Aritmetica operaciones = new Aritmetica();
            operaciones.Suma();
           
            operaciones.resta();
            operaciones.multi();
            operaciones.division();
        }
    }
}
