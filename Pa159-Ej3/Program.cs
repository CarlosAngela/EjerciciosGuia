using System;

namespace Pa159_Ej3
{
    class Program
    {
        static void Main(string[] args)

        {

            //Grupo: Rosa Elena Jimenez Gonzalez
            //   Angela Patricia Carlos Siatama



            Console.WriteLine("Digite dia de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite el mes de nacimiento: ");
            int mes = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite el año de nacimiento: ");
            int anio = int.Parse(Console.ReadLine());

            int sum=dia+mes + anio;

            int res1 = sum / 10;
            int res2 = sum % 10;

            int res3 = res1 / 10;
            int res4 = sum % 10;


            int res5 = res3 / 10;
            int res6 = sum % 10;

            int suma = res1 + res2 + res3 + res4 + res5 + res6;

            int resul1 = suma / 10;
            int resul2 = suma % 10;

            int resul3 = resul1 + resul2 ;

            int resul4 = resul3 / 10;
            int resul5 = resul3 % 10;

            int resul6 = resul4 - resul5;
            int resul7 = resul6 - 6;

            Console.WriteLine("\n");


            Console.WriteLine($"Numero de tarot: {resul7}");



            Console.WriteLine("Hello World!");
        }
    }
}
