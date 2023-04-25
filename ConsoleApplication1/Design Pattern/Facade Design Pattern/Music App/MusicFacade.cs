namespace ConsoleApplication1.Design_Pattern.Facade_Design_Pattern.Music_App
{
    public class MusicFacade
    {
        private PlayList playlist;
        private AudioPlayer audioPlayer;
        private UserInterface userInterface;

        public MusicFacade()
        {
            playlist = new PlayList();
            audioPlayer = new AudioPlayer();
            userInterface = new UserInterface();
        }

        public void addSong(string songName)
        {
            playlist.addSong(songName);
            
            
        }

        public void removeSong(string songName)
        {
            playlist.removeSong(songName);
        }

        public void playSong(string songName)
        {
            audioPlayer.play(songName);
        }

        public void paushSong(string songName)
        {
            audioPlayer.paush(songName);
        }

        public void displayAllSong()
        {
            userInterface.displayAlliSong();
        }
        
    }
}