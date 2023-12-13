using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class Queue
    {
        private static List<Human> humans = CollectHumanList.CollectList();

        public static void AddHuman(Human human)
        {
            humans.Add(human);
            CollectString.CollectStr(ReturnHumanList());  
        }

        public static void DeleteHuman(Human human)
        {
            int count = 0;
            foreach (Human hum in humans)
            {

                if (hum.Login == human.Login)
                {
                    humans.RemoveAt(count);
                    CollectString.CollectStr(ReturnHumanList());
                    break;
                }
                count++;
            }
        }

        public static List<Human> ReturnHumanList()
        {
            SortList();
            return humans;
        }

        public static void SortList()
        {
            humans.Sort((x, y) => DateTime.Compare(x.Time, y.Time));
            //Сортировка по времени
        } 
    }
}
