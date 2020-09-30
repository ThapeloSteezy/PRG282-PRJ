using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ReadFile
    {
        public List<string> Read(string fileName)
        {
            List<string> data = new List<string>();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);

            string txt = string.Empty;
            while ((txt = reader.ReadLine()) != null)
            {
                data.Add(txt);
            }

            return data;
        }
    }
}
