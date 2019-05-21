using System;

namespace Pa159_Ej4
{
    class Program
    {
        static void Main(string[] args)


        {
            //Grupo: Rosa Elena Jimenez Gonzalez
            //   Angela Patricia Carlos Siatama


            Random rnd = new Random();
            int num = rnd.Next();
            Console.WriteLine("Numeros al azar:  {0}",num);

            Console.WriteLine("Digite un numero: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("n");

            int num1 = rnd.Next(0,10);
            Console.WriteLine("Numeros entre 0 y 10:  {0}",num1);

            if (n == num1)
            {
                Console.WriteLine(" GNASTE");
            }
            else
            {
                Console.WriteLine("PERDISTE");

            }

            Console.ReadKey();

        
        }
    }
}
