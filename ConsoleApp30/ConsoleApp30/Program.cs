using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Random rnd = new Random();

            int zar1 = rnd.Next(1, 6);
            int zar2 = rnd.Next(1, 6);

            Console.WriteLine($"Ai dat {zar1} - {zar2}");
            Console.WriteLine("Porta-n casa");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
