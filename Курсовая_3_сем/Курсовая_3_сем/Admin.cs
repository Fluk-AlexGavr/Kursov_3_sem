using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    internal class Admin : Human
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
        public override string Password
        {
            get => password;
            set
            {
                if (!String.IsNullOrEmpty(value)) password = value;
                else ExceptionPrinter.Print("Пароль не может быть пустым");
            }
        }
        private string password;
        public override string StringTime 
        {
            get => "admin не является посетителем";
            set{}
        }
        
        public override string ReturnRights()
        {
            return "admin";
        }
    }
}
