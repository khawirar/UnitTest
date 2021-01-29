using System;

namespace Palin
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Wpisz proszę wyraz bądź zdanie: ");
            string zdanie = Console.ReadLine();

            CheckString cs = new CheckString();
            cs.letsCheck(zdanie);



            Console.ReadKey();
        }
    }
}
