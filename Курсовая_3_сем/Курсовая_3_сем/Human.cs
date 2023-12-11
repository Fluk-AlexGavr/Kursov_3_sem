using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public abstract class Human
    {
        public abstract string Name { get; set; }
        public int Id { get; set; }
        public abstract void LogInToAccount();
    }
}
