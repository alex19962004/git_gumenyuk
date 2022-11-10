
namespace ConsoleApp_15_Catalog_of_CDs_
{
    public class Disk
    {
        public string DiskName { get; }
        public List<Song> _songs;

        public Disk(string diskName, List<Song> songs)
        {
            DiskName = diskName;
            _songs = songs;
        }
        
        public void RemoveSong(string desiredSongName)
        {

            foreach (Song song in _songs)
            {
                if (song.SongName == desiredSongName)
                { 
                    _songs.Remove(song);
                    Console.WriteLine("Song remove!!!");
                    return;
                }                                         
            } 
            Console.WriteLine("Wrong input!!!");        
        }
    }
}
