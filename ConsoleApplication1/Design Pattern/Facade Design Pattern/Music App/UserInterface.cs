using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Music_App
{
    public class UserInterface
    {
        private PlayList playList;
        private List<string> allsongsPlaylist = new List<string>();

        public UserInterface()
        {
            try
            {
                allsongsPlaylist= playList.SongPlayList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
          
        }
        public List<string> AllSongPlayList
        {
            get { return allsongsPlaylist; }
        }
        public void displayAlliSong()
        {
            Console.WriteLine("All song are displyed");
            foreach (var VARIABLE in allsongsPlaylist)
            {
                Console.WriteLine(VARIABLE);   
            }
        }
    }
}