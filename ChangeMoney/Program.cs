using System.Runtime.ConstrainedExecution;
using System;

namespace ChangeMoney
{
    // Skapa ett program för att ”Växla pengar”.

    // a.Låt användaren ange ett amount som ska betalas.
    // b.Ange växel i quantity 500-lappar, 100-lappar, ner till kronor.
    // c.Skriv detta till skärmen


    internal class Program
    {
        static void Main(string[] args)
        {
            // a. Låt användaren ange ett amount som ska betalas.
            Console.Write("Ange belopp som ska betalas: ");
            
            // Vad händer om jag skriver en bokstav?
            int amount = int.Parse(Console.ReadLine());

            // Definiera values
            int[] values = { 500, 100, 50, 20, 10, 5, 1 };

            // b. Ange växel i quantity 500-lappar, 100-lappar, ner till kronor.
            foreach (int value in values)
            {
                // Här beräknas hur många gånger den aktuella valören(t.ex. 500, 100)
                // får plats i det beloppet som användaren har angett.
                // Till exempel, om amount är 1234 och value är 500,
                // så blir quantity 2(då 1234 / 500 = 2 hela 500 - lappar).
                int quantity = amount / value;

                // Detta är samma sak som att skriva amount = amount % value;.
                // Det betyder att vi tar resterande pengar som inte kunde delas
                // ut i den nuvarande valören.
                // Tex, om amount är 1234 och du har delat ut två 500 - lappar(1000 totalt),
                // blir det kvar 234.
                amount %= value;

                // c. Skriv detta till skärmen
                if (quantity > 0)
                {
                    string type;
                    if (value == 500 || value == 100 || value == 50 || value == 20)
                        type = "lapp";
                    else type = "mynt";

                    Console.WriteLine($"{quantity} st {value}-{type}");
                }
            }
        }
    }
}
