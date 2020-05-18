/**
 * Övningsuppgifter 2 - Uppgift 3
Gör ett räkneprogram som frågar efter två tal samt visar en meny på olika räknesätt som man kan välja. Använd gärna Console.Clear() för att rensa skärmen. Ex.
Ange tal 1:________
Ange tal 2:________
Ange räknesätt:
1. division
2. multiplikation
3. addition
4. subtraktion
Du valde subtraktion. Differensen mellan 78 och 12 är 66.

* Formatera textsträngar i .NET
* https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8
* https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
* 

 * */
using System;

namespace uppg3
{
    class Program
    {
        private static double tal1 = 0;
        private static double tal2 = 0;
        private static int choice = 0;

        static void Main(string[] args)
        {
            //Skriv ut en hjälptext
            Console.Write("Ange tal 1: ");

            //Läs in som en textsträng
            string inputValue = Console.ReadLine();

            //Försök konvertera textinmatningen till ett användbart tal
            while (!double.TryParse(inputValue, out tal1))
            {
                Console.WriteLine("Felaktig inmatning");
                Console.Write("Ange tal 1: ");
                inputValue = Console.ReadLine();
            }

            //Skriv ut en hjälptext
            Console.Write("Ange tal 2: ");

            //Läs in som en textsträng
            inputValue = Console.ReadLine();

            //Försök konvertera textinmatningen till ett användbart tal
            while (!double.TryParse(inputValue, out tal2))
            {
                Console.WriteLine("Felaktig inmatning");
                Console.Write("Ange tal 2: ");
                inputValue = Console.ReadLine();
            }

            //Skriv ut menyn
            ShowMenu();

            //Läs in som en textsträng
            inputValue = Console.ReadLine();

            //Försök konvertera textinmatningen till ett användbart tal
            while ((!int.TryParse(inputValue, out choice)) || choice < 1 || choice > 4)
            {
                {
                    Console.WriteLine("Felaktig inmatning");
                    ShowMenu();
                    inputValue = Console.ReadLine();
                }
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Du valde division. " +
                        "Kvoten mellan {0} och {1} är {2}.", tal1, tal2, tal1 / tal2);
                break;

                case 2:
                    Console.WriteLine("Du valde multiplikation. " +
                        "Produkten av {0} och {1} är {2}.", tal1, tal2, tal1 * tal2);
                break;

                case 3:
                    Console.WriteLine("Du valde addition. " +
                        "Summan av {0} och {1} är {2}.", tal1, tal2, tal1 + tal2);
                break;

                case 4:
                    Console.WriteLine("Du valde subtraktion. " +
                        "Differensen mellan {0} och {1} är {2}.", tal1, tal2, tal1 - tal2);
                break;

                default:
                break;
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Ange räknesätt:");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Division");
            Console.WriteLine("2. Multiplikation");
            Console.WriteLine("3. Addition");
            Console.WriteLine("4. Subtraktion");
        }
    }
}
