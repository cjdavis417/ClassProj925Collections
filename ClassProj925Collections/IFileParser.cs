using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProj925Collections
{
    interface IFileParser
    {
        string[] Read(string path);
        void Write(string value, string path);


    }
}
