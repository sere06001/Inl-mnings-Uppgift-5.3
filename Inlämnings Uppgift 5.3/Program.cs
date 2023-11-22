using System;
namespace Uppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in tre heltal på en rad");
            string[] text = Console.ReadLine().Split();
            int tal1 = int.Parse(text[0]);
            int tal2 = int.Parse(text[1]);
            int tal3 = int.Parse(text[2]);
            Console.WriteLine("Summan av talen är: "+(tal1+tal2 + tal3));
            Console.ReadKey();
        }
    }
}
