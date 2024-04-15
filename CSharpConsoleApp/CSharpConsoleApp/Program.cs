using HalloKlassen;
using System;


namespace CSharpConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Klasse C#");

            var meinAuto = new Fahrzeug("HD-XX-1234");

            meinAuto.MachSignal();


            Console.ReadLine();
        }
    }
}
