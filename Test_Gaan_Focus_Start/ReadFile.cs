using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Test_Gaan_Focus_Start
{
    class ReadFile
    {
        public List<String> ReadList(string Link, List<String> String)
        {
            using (StreamReader Sr = new StreamReader(Link))
            {
                while (!Sr.EndOfStream)
                {
                    String.Add(Sr.ReadLine());
                }
            }
            return String;
        }

    }
}
