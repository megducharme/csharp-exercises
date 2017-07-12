using System;
using System.Collections.Generic;

namespace killNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> songs = new HashSet<(string, string)>(){
              ("Landslie", "Dixie Chicks"),
              ("I and Love and You", "Avett Brothers"),
              ("Photograph", "Nickelback"),
              ("Small Bump", "Ed Sheeran"),
              ("You'll Never Leave Harlan Alive", "Patty Loveless"),
              ("Wagon Wheel", "OCMS"),
              ("How You Remind Me", "Nickelback"),
              ("Stable Song", "Gregory Alan Isakov"),
              ("Wide Open Spaces", "Dixie Chicks")  
            };

            foreach(var song in songs)
            {
                if (song.Item2 != "Nickelback")
                {
                    goodSongs.Add(song);
                }
            }

            foreach(var song in goodSongs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
