using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class CollectHumanList
    {
        private static HumansRepository humansRepository = new HumansRepository(@"C:\Users\alesh\OneDrive\Desktop\лабы\2 курс\ООП\курсовая\Kursov_3_sem\List.txt");
        public static List<Human> CollectList()
        {
            List<string> fileData = humansRepository.DataRead();
            List<Human> humans = new List<Human>();
            string[] pole;

            foreach (string s in fileData)
            {
                try
                {
                    pole = s.Split(" ::: ");
                    if (pole[4] == "admin")
                        humans.Add(new Admin(Convert.ToInt32(pole[0]), pole[1], pole[2], pole[3]));
                    else
                        humans.Add(new Visitor(Convert.ToInt32(pole[0]), pole[1], pole[2], pole[3]));

                }
                catch
                {
                    ExceptionPrinter.Print("В сборщике списка что-то сломалось");
                }
            }

            return humans;
        }
    }
}
