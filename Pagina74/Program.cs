using System;

namespace Pagina74
{
    class Program
    {
        static void Main(string[] args)
        {


            //Grupo: Rosa Elena Jimenez Gonzalez
            //   Angela Patricia Carlos Siatama



            // Ejercicio uno

            int a = 10, b = 3, c = 1, d, e;
            float x, y;
            x = a / b;
            if ((a < b) && (a < c))
            {  //El conector logico && no se puede utlizar en in,float y double

            }
            else
            {
                //Se requiere que se inserte una condicion     
            }
            d = (a + b++);
            e = (++a - b);
            y = (float)a / b;

            Console.WriteLine($" El resultado es:{x} \n El resultado es:{d} \n El resultado es: {e} \n El resultado es: {y} \n ");
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
