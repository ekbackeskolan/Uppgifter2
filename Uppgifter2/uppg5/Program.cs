/**
 * Övningsuppgifter 2 - Uppgift 5
Gör ett glos-program där användaren får översätta fem engelska gloser.
Beroende på användarens svar skall det efter varje fråga skrivas ut RÄTT! eller FEL! Användare får 1 poäng för rätt och 0 poäng för fel svar. 
I slutet av programmet skall användarens totala poäng skrivas ut.

 * * Formatera textsträngar i .NET
* https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8
* https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
* 

 * */
using System;
using System.Collections.Generic;

namespace uppg5
{
    class Program
    {
        //Medlemsvariabel (statisk, så att vi slipper skapa objekt av klassen)
        private static Dictionary<string, string> glosBok = new Dictionary<string, string>();
        private static int score = 0;
        static void Main(string[] args)
        {
            //Fyll glosboken
            glosBok.Add("home", "hem");
            glosBok.Add("letter", "bokstav");
            glosBok.Add("book", "bok");
            glosBok.Add("colour", "färg");
            glosBok.Add("car", "bil");

            //Skriv ut en hjälptext
            Console.WriteLine("Ett enkelt glosprogram. Mata in den svenska översättningen");
            Console.WriteLine("av de kommande engelska orden. Du får ett poäng för varje rätt svar.");

            foreach (var item in glosBok)
            {
                Console.WriteLine(item.Key);

                //Läs in som en textsträng
                string inputValue = Console.ReadLine();

                if (inputValue.ToLower().Equals(item.Value))
                {
                    Console.WriteLine("Korrekt!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Tyvärr fel svar!");
                }
            }

            //Formatera utskriften som ett heltal
            Console.WriteLine("Du fick {0} rätt av {1} möjliga.", score, glosBok.Count);
        }
    }
}
