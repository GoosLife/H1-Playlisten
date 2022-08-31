using System;
using System.Collections.Generic;

namespace H1_Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tracks = new string[]
            {
                "Willy Oneka",
                "The Second Track",
                "Third Time's The Charm",
                "Fourk you",
            };

            LinkedList<string> playlist = new LinkedList<string>(tracks);
            int totalTrackCount = playlist.Count; // Using variable because playlist.Count changes in my for-loop.

            for (int i = 0; i < totalTrackCount; i++)
            {
                Console.WriteLine(playlist.First.Value);
                playlist.RemoveFirst();
            }

            Console.ReadKey();
        }
    }
}
