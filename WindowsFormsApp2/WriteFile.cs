using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class WriteFile
    {
        public void Write(string fileName, List<string> data)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            foreach (var item in data)
            {
                writer.WriteLine(item);
            }
        }
    }
}
