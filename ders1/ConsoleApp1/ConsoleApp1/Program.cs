using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Merhaba Dunya!");
            Console.ReadKey(); // Program tuşa basmadan kapanmasın diye 

            Console.WriteLine("Ali benim en iyi arkadasimdir!");
            Console.ReadKey(); 
            */

            string arkadas1, arkadas2;
            Console.WriteLine("1. Arkadasinizin Adi: ");
            arkadas1 = Console.ReadLine();  //okuduğum veriyi arkadas1 e at
            Console.WriteLine("2. Arkadasinizin Adi: ");
            arkadas2 = Console.ReadLine();

            // + operatörüyle
            Console.WriteLine("Hem " + arkadas1 + " hem de " + arkadas2 + " benim en iyi arkadasimdir.");
            //interpolasyon ile
            Console.WriteLine($"Hem {arkadas1} hem de {arkadas2} benim en iyi arkadasimdir.");


        }
    }
}