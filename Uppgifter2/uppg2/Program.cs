/**
 * Övningsuppgifter 2 - Uppgift 2
 Gör ett program som räknar diametern (d) på en cylinder från att du bara matar in 
 bottenarean (A). Formeln finns nedan. 
 Använd konstanten samt metoden för pi resp. roten ur, dvs Math.PI samt Math.Sqrt().

                     d =  (√4A)/π

 * Formatera textsträngar i .NET
* https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8
* https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
* 

 * */
using System;

namespace uppg2
{
    class Program
    {
        //Medlemsvariabel (statisk, så att vi slipper skapa objekt av klassen)
        private static double bottenArea;

        static void Main(string[] args)
        {
            //Skriv ut en hjälptext
            Console.Write("Ange cylinderns bottenarea (ae): ");

            //Läs in som en textsträng
            string inputValue = Console.ReadLine();

            //Försök konvertera textinmatningen till ett användbart tal
            while (!double.TryParse(inputValue, out bottenArea))
            {
                Console.WriteLine("Felaktig inmatning");
                Console.Write("Ange cylinderns bottenarea (ae): ");
                inputValue = Console.ReadLine();
                //return;
            }

            //Beräkna diametern
            double diameter = Math.Sqrt(4 * bottenArea / Math.PI);

            //Formatera utskriften som ett flyttal med 3 decimaler
            Console.WriteLine("Cylinderns diameter är då {0:N3} (le)", diameter);
        }
    }
}
