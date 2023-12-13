using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class CollectString
    {
        private static HumansRepository humansRepository = new HumansRepository(@"C:\Users\alesh\OneDrive\Desktop\лабы\2 курс\ООП\курсовая\Kursov_3_sem\List.txt");
        public static void CollectStr(List<Human> humans)
        {
            List<string> EnterList = new List<string>();
            EnterList.Clear();
            foreach (Human hum in humans)
            {
                EnterList.Add(@$"{hum.id} ::: {hum.Login} ::: {hum.Password} ::: {hum.StringTime} ::: {hum.ReturnRights()}");
            }
            humansRepository.DataWrite(EnterList);
        }
    }
}
