using System;
using System.Reflection.Metadata.Ecma335;

namespace InlamningListUppgift4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = false;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Skriv in en bokstav du vill testa ord på");
                    char characterToFind = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();

                    string[] inputArray = new string[3];
                    Console.WriteLine("Skriv nu 3 ord du vill testa tecknet på, använd ett mellanslag för att skilja på orden.");
                    inputArray = Console.ReadLine().Split(" ");
                    Console.Clear();



                    bool result = FinnsTecknetIAllaSträngar(inputArray, characterToFind);
                    if (result == true)
                    {
                        Console.WriteLine($"Alla orden innehåller {characterToFind}");

                    }
                    else
                    {
                        Console.WriteLine($"Alla orden innehåller inte {characterToFind}");

                    }

                    Console.ReadKey();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Något gick fel, testa igen");
                    Console.ReadLine();
                    error = true;
                }

            } while (error = true);
        }

        static bool FinnsTecknetIAllaSträngar(string[] inputArray, char character)
        {
            foreach (string str in inputArray)
            {
                if (!str.Contains(character))
                {
                    return false;
                }

            }
            return true;
        }

    }

}
