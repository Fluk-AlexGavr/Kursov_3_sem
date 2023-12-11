using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public abstract class Human
    {
        public abstract string Login { get; set; }
        public abstract void LogInToAccount();
        public abstract string ReturnRights();

        private static int idCounter;// = IDController.IdControll(University.students);
        public int id;

        public Human()
        {
            id = idCounter;
            idCounter++;
            //Queue.AddHuman(this);
        }
    }
}
