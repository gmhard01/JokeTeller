using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JokeTeller.Classes
{
    public class DadJokes : Jokes
    {
        static string dir = Directory.GetCurrentDirectory();
        static string file = "dadjokes.txt";

        public DadJokes()
        {
            this.JokesFile = Path.Combine(dir, file);
            this.JokeList = GetJokes(JokesFile);
        }
    }
}
