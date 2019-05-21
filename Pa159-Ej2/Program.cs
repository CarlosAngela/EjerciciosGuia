using System;

namespace Pa159_Ej2
{
    class Program
    {
        static void Main(string[] args)

        {

            //Grupo: Rosa Elena Jimenez Gonzalez
            //   Angela Patricia Carlos Siatama


            Console.WriteLine("Ejercio de Sumatoria");
            Console.WriteLine("\n");
            Console.WriteLine("b\n Σ 1 / x+ay \n a=0");
            Console.WriteLine("\n");


            Console.WriteLine("Digite el valor para b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor para  x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor para y: ");
            double y = double.Parse(Console.ReadLine());


            for (int a=0; a < b; a++)
            {
                double opera = 1 / x + a * y;
                Console.WriteLine($"Su resultado es {opera}");
            }
            Console.ReadKey();
        }
    }
}
