using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class Queue
    {
        public static List<Human> humans;

        public static void AddHuman(Human human)
        {
            humans.Add(human);
            //CollectString.CollectStr(students);  
        }

        public static void DeleteHuman(Human human)
        {
            int count = 0;
            foreach (Human hum in humans)
            {

                if (hum.Login == human.Login)
                {
                    humans.RemoveAt(count);
                    //CollectString.CollectStr(students);
                    break;
                }
                count++;
            }
        }

        
    }
}
