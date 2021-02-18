using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JokeTeller.Classes
{
    public class KnockKnockJokes : Jokes
    {
        static string dir = Directory.GetCurrentDirectory();
        static string file = "knockknockjokes.txt";

        public KnockKnockJokes()
        {
            this.JokesFile = Path.Combine(dir, file);
            this.JokeList = GetJokes(JokesFile);
        }
    }
}
