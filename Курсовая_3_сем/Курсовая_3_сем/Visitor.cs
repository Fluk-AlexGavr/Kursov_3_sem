using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    internal class Visitor : Human
    {
        public override string Name 
        { 
            get => name; 
            set
            {
                if (!String.IsNullOrEmpty(value)) name = value;
                else ExceptionPrinter.Print("Имя не может быть пустым");
            }
        }
        private string name;

        public override void LogInToAccount()
        {
            
        }
    }
}
