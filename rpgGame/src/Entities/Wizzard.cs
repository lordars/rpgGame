﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.src.Entities
{
    internal class Wizzard : heroEntitiesNew
    {

        public Wizzard(string Name, int Level, string TypeHero, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHero = TypeHero;
            this.HP = HP;
            this.MP = MP;
        }
        public override string AtackHero()
        {
            return this.Name + " Ataca Com poder magico";

        } 


        public  string AtackHero(int Bonus)
        {

            if (Bonus > 6)
            {
                return this.Name + " Ataque super poder!! daño: " + Bonus;
            }
            else
            {
                return this.Name + " Fail power Magia low Atact " + Bonus;
            }
            

        }
    }
}
