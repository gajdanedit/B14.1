using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szamA, szamB;
            Console.WriteLine("Írj be egy számot!");
            szamA = int.Parse(Console.ReadLine());
            Console.WriteLine("Írj be egy másik számot!");
            szamB = int.Parse(Console.ReadLine());
            Console.WriteLine("A szám összege:" +(szamA+szamB).ToString());


            Console.ReadLine();
        }
    }
}
