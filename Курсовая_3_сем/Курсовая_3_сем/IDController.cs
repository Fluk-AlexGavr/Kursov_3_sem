using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public static class IDController
    {
        public static int IdControll(List<Human> humans)
        {
            int max = -1;
            if(humans is null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < humans.Count; i++)
                {
                    if (max < humans[i].id)
                    {
                        max = humans[i].id;
                    }
                }
                return max + 1;
            }
        }
    }
}
