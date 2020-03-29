/**
 * Övningsuppgifter 2 - Uppgift 1
 * Skriv ett program som används i en omröstning och frågar efter antalet ja-röster, antalet nej-röster 
 * och antalet vet ej-röster. Sedan ger programmet en ut snygg utskrift som visar andelen röster i procent. 
 * Använd en lämplig avrundningsfunktion. T ex på färdig utskrift:

Antal röster i procent:
=======================
Ja	35 %
Nej	35 %
Vet ej	30 %

* Formatera textsträngar i .NET
* https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8
* https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
* 

 */
using System;

namespace uppg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange antal JA-röster : ");
            int antalJa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ange antal NEJ-röster : ");
            int antalNej = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ange antal VET-EJ-röster : ");
            int antalVetEj = Convert.ToInt32(Console.ReadLine());

            double summa = antalJa + antalNej + antalVetEj;

            //Presentera resultatet
            Console.WriteLine();
            Console.WriteLine("Antal röster i procent:");
            Console.WriteLine("=======================");
            Console.WriteLine("{0,-10} {1,10:p0}", "Ja", (antalJa / summa));
            Console.WriteLine("{0,-10} {1,10:p0}", "Nej",(antalNej / summa));
            Console.WriteLine("{0,-10} {1,10:p0}", "Vet ej", (antalVetEj / summa));
        }
    }
}
