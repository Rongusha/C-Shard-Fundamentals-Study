using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSong; i++)
            {
                string[] info = Console.ReadLine().Split("_");

                string playlist = info[0];
                string name = info[1];
                string time = info[2];

                Song song = new Song();

                song.TypeList = playlist;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
