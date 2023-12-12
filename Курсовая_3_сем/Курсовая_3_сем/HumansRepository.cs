using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public class HumansRepository
    {
        string path;

        public void DataWrite(List<string> str)
        {

            System.IO.File.WriteAllLines(path, str, Encoding.UTF8);
        }

        public List<string> DataRead()
        {
            string[] newArray = System.IO.File.ReadAllLines(path, Encoding.UTF8);
            return newArray.ToList<string>();
        }

        public HumansRepository(string _path)
        {
            path = _path;
        }
    }
}
