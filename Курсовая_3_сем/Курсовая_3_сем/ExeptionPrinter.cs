using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class ExceptionPrinter
    {
        public static void Print(string ex)
        {
            GetString(ex.ToString());
        }

        private static void GetString(string str)
        {
            throw new Exception(str);
        }
    }
}
