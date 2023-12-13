﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public class Visitor : Human
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
            get => stringTime;
            set
            {
                if (!String.IsNullOrEmpty(value)) stringTime = value;
                else ExceptionPrinter.Print("Время не может быть пустым");
            }
        }
        private string stringTime;
        public override string ReturnRights()
        {
            return "visitor";
        }
        public override DateTime Time { get; set; }
        public Visitor(string login, string password, string stringTime)
        {
            Login = login;
            Password = password;
            StringTime = stringTime;
            Time = StringTimeConverter.StringToTime(this);
        }

        public Visitor(string login, string password)
        {
            Login=login;
            Password = password;
        }

        public Visitor(int id, string login, string password, string stringTime)
        {
            this.id = id;
            Login = login;
            Password = password;
            StringTime = stringTime;
            Time = StringTimeConverter.StringToTime(this);
        }
    }
}
