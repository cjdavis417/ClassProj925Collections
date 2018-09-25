using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassProj925Collections
{
    class FileParser : IFileParser
    {
        public string[] Read(string path)
        {
            int arraySize = 0;
            string[] array;


            var streamReader = new StreamReader(path);
            arraySize = int.Parse(streamReader.ReadLine());
            array = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = streamReader.ReadLine();
            }

            streamReader.Close();
            streamReader.Dispose();

            return array;
            

        }

        public void Write(string value, string path)
        {
            var streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("value");

            streamWriter.Close();
            streamWriter.Dispose();
        }

    }
}
