using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_1_
{
    class Softwarea
    {
        public int number;
        public bool possibilityOfUse;
        //public string[] systemSoftware;
        public string[,] softwareList;

        public void GetTypeOfSystemSoftware()
        {
            string[][] systemSoftware = new string[5][];

            systemSoftware[0] = new string[9] { "Operating Systems: ", "MS-Windows ", "Android ", "macOS ", "IOS ", "Linux ",
                                                "Ubuntu ", "Unix ", "CentOS " };
            systemSoftware[1] = new string[10] { "Device Drivers: ", "BIOS Driver ", "Motherboard Driver", "Display Driver",
                                                "Sound Car ", "Graphics ", "USB Driver", "Printer Drivers", "VIRTUAL Device Drivers",
                                                "ROM Drivers" };
            systemSoftware[2] = new string[6] { "Firmware: ", "BIOS ", "UEFI ", "Embedded ", "Computer Peripherals ",
                                                "Computer Applications " };
            systemSoftware[3] = new string[4] { "Lanquage Translators: ", "Interpreter ", "Compiler ", "Assembler " };
            systemSoftware[4] = new string[11] { "Utility: ", "Windows File Explorer ", "WinRAR ", "WinZip ", "Avast Antivirus ",
                                                "McAfee Antivirus", "Norton Antivirus", "Directory Opus", "Piriform Defraggler",
                                                "Piriform CCileaner ", "Razer Cortex " };
            Console.WriteLine("Available types of software ");
            Console.WriteLine();
            for (int i = 0; i < systemSoftware.Length; i++)
            {
                for (int j = 0; j < systemSoftware.Length; j++)
                {
                    Console.WriteLine($"{i}.{j}. {systemSoftware[i][j]}");
                }
                Console.WriteLine();
            }
        }
        public void GetSoftwareList()
        {
            softwareList = new string[2,10]
            { { "Microsoft Office Home & Business 2021 ", "Microsoft Windows Server 2022  ", "Microsoft Visual Studio Enterprise 2019 ",
                "Microsoft Outlook 2021 ","Microsoft SQL Server 2019 ", "Laplink PCmover Professional ", "PDF Suite Standard ",               
                "Nuance Power PDF ","AVAST Driver Updater ", "ESET NOD32 Antivirus "
              },
              { "available ","available ", "unavailable ", "available ", "available ", "unavailable ", "available ","available ",
               "available ", "unavailable "
              }
            };
            //int k = 1;
             for(int i = 0; i < 1 ; i++)
             {
                for( int j = 0; j < softwareList.GetLength(1) ; j++)
                {
                   // k++;
                    Console.WriteLine($"{j+1}. {softwareList[i,j]}");

                }
                Console.WriteLine();

             }               
           


            //softwareList = new string[10]
            //int i = 0;
            //foreach (string software in softwareList)
            
        }
        public void SearchForRequiredSoftware()
        {
            Console.Write("Enter the number from the list of required software ");
            number = int.Parse(Console.ReadLine());
           /* for (int i = 0; i < softwareList.Length; i++)
            {
                if(i == number - 1) 
                {
                    Console.WriteLine(softwareList[i,j]);
                }
            }*/
            Console.WriteLine();
        }
    }
}
