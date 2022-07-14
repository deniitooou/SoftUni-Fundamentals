using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> listOfSongs = new List<Song>();

            int songsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsCount; i++)
            {
                string[] songProperties = Console.ReadLine().Split('_');

                Song song = new Song(songProperties[0], songProperties[1], songProperties[2]);

                listOfSongs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in listOfSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in listOfSongs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    }

