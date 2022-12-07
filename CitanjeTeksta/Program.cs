using System;
using System.IO;
namespace CitanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\ucenik\Documents\LukaRadetic\datoteka.txt");
            // Čitamo datoteku liniju po liniju
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            // Zatvaramo datoteku
            sr.Close();
            Console.ReadKey();
        }
    }
}