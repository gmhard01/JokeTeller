using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JokeTeller.Classes
{
    public abstract class Jokes
    {
        public List<string> JokeList { get; set; }

        public string JokesFile { get; set; }

        public List<string> GetJokes(string jokeFile)
        {
            List<string> jokeList = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(jokeFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        jokeList.Add(line);
                    }
                }
            }
            catch (IOException IOE)
            {
                Console.WriteLine("There was a problem reading the source file.");
            }

            return jokeList;
        }

        public void TellJoke(int index)
        {
            Console.WriteLine($"{JokeList[index]}");
        }
    }
}
