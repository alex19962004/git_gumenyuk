using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_1_
{
   
    internal class Freea: Softwarea
    {
        public string manufacturer;

        /*public string GetSoftwareList()

        {
            return softwareList;


            softwareList.ToCharArray
            
          
        }*/

        public void GetSoftwareProducer()
        {
            string[] softwareProducer = new string[10] { "Microsoft ", "Microsoft ", "Microsoft ", "Microsoft ", "Microsoft ", 
                                                        " Laplink Software ", " Adobe Systems ", "Nuance Communications ",
                                                        "Avast Software ", "ESET " };
        }

        public void GetFreeSoftware()
        {
            string[,] freeSoftware = new string[2,5];
        }
    }

 

}
