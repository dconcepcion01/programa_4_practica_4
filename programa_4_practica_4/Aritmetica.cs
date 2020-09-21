using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_4_practica_4
{
    public class Aritmetica
    {
        public double numero1;
        public double numero2;
        private double resultado;

        public void Suma()


        {
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("ESTE PROGRAMA TE CALCULA LAS OPERACIONES ARITMETICA");


            //Metodo suma
            Console.SetCursorPosition(5, 8);
            Console.WriteLine("Digite el primer numero" + numero1);
            Console.SetCursorPosition(5, 9);
            numero1 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 10);
            Console.WriteLine("Digite el segundo numero" + numero2);
            Console.SetCursorPosition(5, 11);
            numero2 = double.Parse(Console.ReadLine());

            resultado = numero1 + numero2;
            Console.SetCursorPosition(5, 12);
            Console.WriteLine("El resultado de la suma es " + resultado);

            Console.ReadLine();





        }

        private static  suma (int  numero1, double  numero2, double  numero3)
        {
            //resultado = numero1 + numero2 + numero3;

           int  x = suma(numero1 + numero2 + numero3);


            resultado = numero1 + numero2 + numero3;

            
            Console.WriteLine("Digite el primer numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el primer numero");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el primer numero");
            numero3 = double.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es"+ resultado);

            Console.ReadLine();


        }
        public void resta()


        {
            //Metodo resta
            Console.SetCursorPosition(5, 13);
            Console.WriteLine("Digite el primer numero" + numero1);
            Console.SetCursorPosition(5, 14);
            numero1 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 15);
            Console.WriteLine("Digite el segundo numero" + numero2);
            Console.SetCursorPosition(5, 16);
            numero2 = double.Parse(Console.ReadLine());

            resultado = numero1 - numero2;
            Console.SetCursorPosition(5, 17);
            Console.WriteLine("El resultado de la resta  es " + resultado);

            Console.ReadLine();



        }
        //Metodo multiplicacion
        public void multi()
        {
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("Digite el primer numero              " + numero1);
            Console.SetCursorPosition(5, 19);
            numero1 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 20);
            Console.WriteLine("Digite el segundo numero              " + numero2);
            Console.SetCursorPosition(5, 21);
            numero2 = double.Parse(Console.ReadLine());

            resultado = numero1 * numero2;
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("El resultado de la multiplicacion es   " + resultado);

            Console.ReadLine();




        }
        //Metodo division
        public void division()
        {
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("Digite el primer numero    :   " + numero1);
            Console.SetCursorPosition(5, 24);
            numero1 = double.Parse(Console.ReadLine());

            Console.SetCursorPosition(5, 25);
            Console.WriteLine("Digite el segundo numero   :    " + numero2);
            Console.SetCursorPosition(5, 26);
            numero2 = double.Parse(Console.ReadLine());

            resultado = numero1 / numero2;

            Console.SetCursorPosition(5, 27);
            Console.WriteLine("El resultado de la suma es  : " + resultado);

            Console.ReadLine();



        }


    }
}
