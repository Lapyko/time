using System;
using System.Text.RegularExpressions;

namespace RegVir
{
    internal class Program : Raspisanie
    {
        static void Main(string[] args)
        {

            Raspisanie cl = new Raspisanie();
            cl.raspisanie();
            Console.ReadLine();
        }
    }
}
