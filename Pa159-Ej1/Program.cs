using System;

namespace Pa159_Ej1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Grupo: Rosa Elena Jimenez Gonzalez
            //   Angela Patricia Carlos Siatama

            Console.WriteLine("Ingrese el Primer valor A ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine(" Digite el Primer valor B ");
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            double sum1 = b + a;

            if ((a >= 0) && (b >= 0))
            {
                Console.WriteLine(" \n ");

                Console.WriteLine(" Solucion");

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(" \n ");


                Console.WriteLine(" Numeros negativos no pueden ser Operados ");
            }

            if (a < b)
            {
                Console.WriteLine(" \n ");


                Console.WriteLine($" A es menor que B/ Se invertiran los valores ");


                Console.WriteLine(sum1);


            }
        }
    }
}