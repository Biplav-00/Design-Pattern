using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Music_App
{
    public class AudioPlayer
    {
        private List<string> allAvailableSong = new List<string>();
        private PlayList _playList;
        private string currentSong;
        public AudioPlayer()
        {
            try
            {
                allAvailableSong = _playList.SongPlayList;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Empty song list");
            }
        }
        
        public void play(string songName)
        {
            if (allAvailableSong.Count > 0)
            {
                if (allAvailableSong.Contains(songName))
                {
                    currentSong = songName;
                    Console.WriteLine("{0} song is playing");

                }
                else
                {
                    Console.WriteLine("Song name = {0} couldnot found ", songName);
                }
            }
            else
            {
                Console.WriteLine("No song available right now");
            }
        }

        public void paush(string songName)
        {
            if (currentSong.Equals(songName))
            {
                Console.WriteLine("song name ={0} is paushed",songName);
            }
        }
    }
}