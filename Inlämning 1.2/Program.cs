using System;

namespace uppgift_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör bakgrunden till mörkblå
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            //Gör texten till Vit
            Console.ForegroundColor = ConsoleColor.White;
            //Skriver ut text
            Console.WriteLine("Oh no! Looks like you've gotten an error.");
            Console.WriteLine(":/");
           

        }
    }
}