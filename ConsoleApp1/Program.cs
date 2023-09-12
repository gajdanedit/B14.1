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
            szamA = szamotKer("Írj be egy számot");
            szamB = szamotKer("Írj be egy számot");
            Console.WriteLine("A szám összege:" +(szamA+szamB).ToString());


            Console.ReadLine();
        }

        private static int szamotKer(string szoveg)
        {
            int bekertszam;
            Console.Write(szoveg);
            bekertszam = int.Parse(Console.ReadLine());
            return bekertszam;
        }
    }
}
