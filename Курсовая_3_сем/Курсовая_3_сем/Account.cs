﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_3_сем
{
    public class Account
    {
        public Human? Autorization(List<Human> humans, Human human)
        {
            foreach (Human hum in humans)
            {
                if (human.Login == hum.Login && human.Password == hum.Password)
                {
                    return hum;
                }
                
            }
            return null;
        }
        public void CreateNewAccount(Human human)
        {
            Queue.AddHuman(human);
        }
        public void DeleteAccount(Human human)
        {
            Queue.DeleteHuman(human);
        }

    }
}
