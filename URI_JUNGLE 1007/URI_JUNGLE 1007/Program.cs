using System;

namespace URI_JUNGLE_1007
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());


            diferenca = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);
            Console.ReadLine();

        }
    }
}
