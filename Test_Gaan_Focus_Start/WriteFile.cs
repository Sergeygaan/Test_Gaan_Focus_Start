using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Gaan_Focus_Start
{
    class WriteFile
    {
        public WriteFile(string link, List<String> String)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(link))
            {
                for (int i = 0; i < String.Count; i++)
                    sw.WriteLine(String[i].ToString());
            }
        }

    }
}
