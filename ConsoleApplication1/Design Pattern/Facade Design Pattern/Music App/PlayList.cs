using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Music_App
{
    public class PlayList
    {
        private List<string> songPlayList;
        
        public PlayList()
        {
            songPlayList = new List<string>(){"dummy music"};
        }
        
        public void addSong(string songName)
        {
            if (!songPlayList.Contains(songName))
            {
                songPlayList.Add(songName);
                Console.WriteLine(" song {0} is added to playlist successfully..",songName);
            }
            else
            {
                Console.WriteLine("Song name = {0} already exist you cannot add twice...");
            }

        }

        public void removeSong(string songName)
        {
            if (songPlayList.Contains(songName))
            {
                songPlayList.Remove(songName);
                Console.WriteLine("song name ={0} removed successfully",songName);
            }
            else
            {
                Console.WriteLine("couldnot find the song name = {0} in playlist",songName);
            }
            
        }
        public List<string> SongPlayList{get { return songPlayList;}}
    }
}