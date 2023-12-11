using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    internal class Visitor : Human
    {
        public override string Login 
        { 
            get => login; 
            set
            {
                if (!String.IsNullOrEmpty(value)) login = value;
                else ExceptionPrinter.Print("Имя не может быть пустым");
            }
        }
        private string login;

        public override void LogInToAccount()
        {
            
        }

        public override string ReturnRights()
        {
            return "visitor";
        }
    }
}
