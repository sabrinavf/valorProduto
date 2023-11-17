using System;
using System.Globalization;

namespace Estudo
{
    class somaSimples
    {
        static void Main(string[] args)
        {
            int PROD, A, B;

            A = int.Parse (Console.ReadLine());
            B= int.Parse (Console.ReadLine());

            PROD = A * B;

            Console.WriteLine("PROD = " + PROD);

        }
    }
}