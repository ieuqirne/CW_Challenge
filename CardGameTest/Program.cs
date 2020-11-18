using System;
using CodingChallenge.CardGame;
using System.Threading;
namespace CardGameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int option = 1;

            IPackOfCardsCreator packOfCC = new PackOfCardsCreator();
            IPackOfCards packOfC = new PackOfCards();
            packOfC = packOfCC.Create();
            int count = packOfC.Count;
            
            while (option != 0)
            {
                Console.Clear();
                Console.WriteLine("Choose one of the following options: ");
                Console.WriteLine("1. Create a new Pack. ");
                Console.WriteLine("2. Suffle Cards. ");
                Console.WriteLine("3. Print Cards. ");
                Console.WriteLine("4. Remove Top Card. ");
                Console.WriteLine("5. Check Number Cards Left. ");


                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        packOfC = packOfCC.Create();
                        break;
                    case 2:
                        packOfC.Shuffle();
                        break;
                    case 3:
                        packOfC.PrintAllCards();
                        break;
                    case 4:
                        Console.WriteLine("Taking Card From Top...");                       
                        packOfC.TakeCardFromTopOfPack();
                        count = packOfC.Count;
                        break;
                    case 5:
                        Console.WriteLine("There is " + packOfC.Count+ " cards remaining.");
                        break;
                }

                Thread.Sleep(4000);
            }
            Console.WriteLine("Bye!");
        }
    }
}
