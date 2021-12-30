using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>()
            {
                "Madden",
                "Fortnite",
                "Tetris",
                "FIFA",
                "Zelda"
            };

            var ordered = videoGames
                .OrderByDescending(name => name.Length)
                .ToList();

           

            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }


        }
    }
}
