using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class PrinterForUser
    {
        static readonly string dataLost = "Данные отсутствуют";
        private static void Printer(string? str)
        {
            Console.WriteLine(str);
        }
        public static void Print(string? str)
        {
            Printer(str ?? dataLost);
        }
    }
}
