namespace ConsoleApp_15_Catalog_of_CDs_
{
     class Program
     {      
        static void Main(string[] args)
        {
            string choice;
            string desiredDiskName;
            string songName;
            string singerName;          
            List<Song> songs = new List<Song>();

            var song1 = new Song("Song1Name", "Singer1Name");
            var song2 = new Song("Song2Name", "Singer2Name");
            var song3 = new Song("Song3Name", "Singer3Name");
            var song4 = new Song("Song4Name", "Singer1Name");
            var song5 = new Song("Song5Name", "Singer3Name");
            var song6 = new Song("Song6Name", "Singer2Name");

            Disk disk1 = new Disk("disk1", new List<Song> { song1, song2, song4, song5 });      
            Disk disk2 = new Disk("disk2", new List<Song> { song3, song6 });
            
            Catalog catalog = new Catalog("cat", new List<Disk> { disk1, disk2 });          

            Console.WriteLine("Choose the actions you want to take ...");
            Console.WriteLine(" - Add a new disk with songs to the collection                  - enter - 1");
            Console.WriteLine(" - Delete the disk with songs from the collection               - enter - 2");
            Console.WriteLine(" - Add song to disk                                             - enter - 3");
            Console.WriteLine(" - Remove the song from the disk                                - enter - 4");
            Console.WriteLine(" - View the contents of a desired disc                          - enter - 5");
            Console.WriteLine(" - View all contents of the collection                          - enter - 6");
            Console.WriteLine(" - Search for all contents of a given singer in the collection  - enter - 7");
                        
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter the name of the desired Disk ...");
                    desiredDiskName = Console.ReadLine();
                    Disk disk = new Disk(desiredDiskName, songs);
                    catalog.AddDisk( disk);                   
                    break;
                case "2":
                    Console.Write("Enter the desired Disk ...");
                    desiredDiskName = Console.ReadLine();
                    catalog.RemoveDisk(desiredDiskName);
                    break;                                  
                case "3":  
                    Console.Write("Enter the desired Disk ...");                 
                    desiredDiskName = Console.ReadLine();
                    Console.Write("Enter the new song ...");
                    songName = Console.ReadLine();
                    Console.Write("Enter the singer's name ...");
                    singerName = Console.ReadLine();
                    var song = new Song(songName, singerName);
                    catalog.AddSong(desiredDiskName, song);
                    break;
                case "4":                   
                    Console.Write("Enter the desired Disk ...");
                    desiredDiskName = Console.ReadLine();
                    Console.Write("Enter the song ...");
                    songName = Console.ReadLine();                                
                    catalog.RemoveSong(desiredDiskName, songName);
                    break;

                case "5":
                    Console.Write("Enter the desired Disk ...");
                    desiredDiskName = Console.ReadLine();
                    catalog.ViewAllSogsOfDisk(desiredDiskName);
                    break;

                case "6":
                    catalog.ViewAllSogsOfCatalog();
                    break;

                case "7":
                    Console.Write("Enter the singer's name ...");
                    singerName = Console.ReadLine();
                    catalog.SearchAllSingerSongs(singerName);
                    break;
                                
                default:
                    Console.WriteLine("Wrong input!!!");
                    break;                    
            }          
        }        
     }
}