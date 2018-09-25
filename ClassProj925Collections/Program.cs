using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassProj925Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileParser parser = new FileParser();

            string[] myCatch = parser.Read("Cities.txt");

            //parser.Write("Chicago", "Cities.txt");

            for (int i = 0; i < myCatch.Count(); i++)
            {
                Console.WriteLine(myCatch[i]);
            }

            Console.ReadLine();

            


        }
    }
}
