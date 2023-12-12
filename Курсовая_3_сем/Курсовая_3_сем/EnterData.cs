using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public class EnterData
    {
        public string EntData()
        {
            string str = Console.ReadLine();
            return str; 
            
        }
        public string StringData()
        {
            return EntData();
        }
        public int IntData(string str)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(str);
                return i;
            }
            catch
            {
                ExceptionPrinter.Print("Ожидалось число");
                return i;
            }
        }
        public double DoubleData(string str)
        {
            double i = 0;
            try
            {
                i = Convert.ToDouble(str);
                return i;
            }
            catch
            {
                ExceptionPrinter.Print("Ожидалось число");
                return i;
            }
        }

    }
}
