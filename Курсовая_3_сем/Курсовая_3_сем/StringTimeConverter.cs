using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class StringTimeConverter
    {
        public static DateTime StringToTime(Human human)
        {
            string strTime = human.StringTime;
            string[] strings = strTime.Split(" ");
            try
            {
                DateTime dateTime = new DateTime(
                Convert.ToInt32(strings[0]),
                Convert.ToInt32(strings[1]),
                Convert.ToInt32(strings[2]),
                Convert.ToInt32(strings[3]),
                Convert.ToInt32(strings[4]),
                Convert.ToInt32(strings[5])
                );
                return dateTime;
            }
            catch
            {
                ExceptionPrinter.Print("Ожидался формат yyyy MM dd HH mm ss");
                return DateTime.Now;
            }
        }
    }
}
