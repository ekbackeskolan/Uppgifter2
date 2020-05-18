/**
 * Övningsuppgifter 2 - Uppgift 4
Gör ett program som skriver ut om ett inmatat heltal är udda eller jämnt. 
Använd modulus-operatorn.

* Formatera textsträngar i .NET
* https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8
* https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
* 

 * */
using System;

namespace uppg4
{
    class Program
    {
        //Medlemsvariabel (statisk, så att vi slipper skapa objekt av klassen)
        private static int heltalet;

        static void Main(string[] args)
        {
            //Skriv ut en hjälptext
            Console.Write("Ange ett heltal: ");

            //Läs in som en textsträng
            string inputValue = Console.ReadLine();

            //Försök konvertera textinmatningen till ett användbart tal
            while (!int.TryParse(inputValue, out heltalet))
            {
                Console.WriteLine("Felaktig inmatning");
                Console.Write("Ange ett heltal: ");
                inputValue = Console.ReadLine();
            }

            //Kolla om udda
            bool udda = true;
            if (heltalet % 2 == 0)
            {
                udda = false;
            }

            //Formatera utskriften som ett flyttal med 3 decimaler
            Console.WriteLine("{0} är {1}", heltalet, udda?"udda":"jämnt");
        }
    }
}
