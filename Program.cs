using System;
using System.Collections.Generic;
using JokeTeller.Classes;

namespace JokeTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Jokes knockKnock = new KnockKnockJokes();
                Jokes oneLiner = new OneLinerJokes();
                Jokes dadJokes = new DadJokes();

                Console.WriteLine("Welcome to the Joke Generator! What type of joke would you like to hear?");
                Console.WriteLine("[1] Knock-Knock Joke");
                Console.WriteLine("[2] One-Liner");
                Console.WriteLine("[3] Dad Joke");
                Console.WriteLine("[4] Any Type");
                Console.WriteLine("Please select a joke type >>> ");
                string userChoice = Console.ReadLine();
                Console.WriteLine();

                switch(userChoice)
                {
                    case "1":
                        knockKnock.TellJoke(GetRandomIndexValue(knockKnock.JokeList.Count));
                        Console.WriteLine();
                        ReturnToMenu();
                        break;

                    case "2":
                        oneLiner.TellJoke(GetRandomIndexValue(oneLiner.JokeList.Count));
                        Console.WriteLine();
                        ReturnToMenu();
                        break;

                    case "3":
                        dadJokes.TellJoke(GetRandomIndexValue(dadJokes.JokeList.Count));
                        Console.WriteLine();
                        ReturnToMenu();
                        break;

                    case "4":
                        Console.WriteLine(TellRandomJokeOfAnyType(knockKnock.JokeList, oneLiner.JokeList, dadJokes.JokeList));
                        Console.WriteLine();
                        ReturnToMenu();
                        break;
                    default:
                        Console.WriteLine("Selection was invalid, so you get a random joke!");
                        Console.WriteLine();
                        Console.WriteLine(TellRandomJokeOfAnyType(knockKnock.JokeList, oneLiner.JokeList, dadJokes.JokeList));
                        Console.WriteLine();
                        ReturnToMenu();
                        break;
                }
            }

            static int GetRandomIndexValue(int jokeListLength)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, jokeListLength - 1);

                return index;
            }

            static string TellRandomJokeOfAnyType(List<string> listOfJokes1, List<string> listOfJokes2, List<string> listOfJokes3)
            {
                List<string> combinedListOfJokes = new List<string>();

                foreach (string joke in listOfJokes1)
                {
                    combinedListOfJokes.Add(joke);
                }

                foreach (string joke in listOfJokes2)
                {
                    combinedListOfJokes.Add(joke);
                }

                foreach (string joke in listOfJokes3)
                {
                    combinedListOfJokes.Add(joke);
                }

                return combinedListOfJokes[GetRandomIndexValue(combinedListOfJokes.Count)];
            }

            static void ReturnToMenu()
            {
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
