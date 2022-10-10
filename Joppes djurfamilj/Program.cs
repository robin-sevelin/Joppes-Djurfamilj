using System;
using System.Collections.Generic;
using System.Text;

namespace Joppes_hundar
{
    class Program
    {
        static void Main(string[] args)
        {
            Petowner petowner = new Petowner(20); // skaper en instans av petowner med åldern 20 år
            petowner.Menu(); // metodanrop för menu i klassen petowner

            Console.WriteLine("..tryck för att avsluta");
            Console.ReadLine();
        }
    }
}
