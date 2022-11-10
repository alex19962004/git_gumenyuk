
namespace ConsoleApp_15_Catalog_of_CDs_
{
    public class Catalog
    {
        public string CatalogName { get; }
        public List<Disk> _disks;

        public Catalog(string catalogName, List<Disk> disks)
        {
            CatalogName = catalogName;
            _disks = disks;
        }
        public void AddDisk( Disk disk )                                     //  1
        {            
             _disks.Add(disk);
            Console.WriteLine("Disk added!!!");                       
        }

        public void RemoveDisk(string desiredDiskName)                        //  2
        {
            foreach (Disk disk in _disks)
                if (disk.DiskName == desiredDiskName)
                {
                    _disks.Remove(disk);
                    Console.WriteLine("Disk remove!!!");
                    return;
                }
            Console.WriteLine("Wrong input!!!");
        }
        public void AddSong(string desiredDiskName, Song song)                 // 3
        {
            foreach (Disk disk in _disks)
            {
                if (disk.DiskName == desiredDiskName)
                {
                    disk._songs.Add(song);
                    Console.WriteLine("Song added!!!"); 
                    return;
                }              
            }
            Console.WriteLine("Wrong input!!!");
        }
        public void RemoveSong(string desiredDiskName, string desiredSongName)  //  4
        {
            foreach (Disk disk in _disks)
            {
                if (disk.DiskName == desiredDiskName)
                {
                    disk.RemoveSong(desiredSongName);
                    return;
                }
            }
            Console.WriteLine("Wrong input!!!");
        }
        public void ViewAllSogsOfDisk(string desiredDiskName)              //  5
        {
            foreach (Disk disk in _disks)
            {
                if (disk.DiskName == desiredDiskName)
                {
                    foreach (Song song in disk._songs)
                    {
                        Console.WriteLine(song.SongName + " " + song.SingerName + " " + disk.DiskName);                      
                    }
                    return;
                }
            }
            Console.WriteLine("Wrong input!!!");
        }
        public void ViewAllSogsOfCatalog()                               //  6
        {                          
            foreach (Disk disk in _disks)
            {
                 foreach (Song song in disk._songs)
                 {
                       Console.WriteLine(song.SongName + " " + song.SingerName + " " + disk.DiskName);
                 }
            }           
        }

        public void SearchAllSingerSongs(string singerName)               //  7
        {
             foreach (Disk disk in _disks)
             {
                 foreach (Song song in disk._songs)
                 {
                     if (song.SingerName == singerName)
                     {
                        Console.WriteLine(song.SongName + " " + song.SingerName + " " + disk.DiskName);                      
                     }
                 }
             }            
        }        
    }
}
