using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rpgGame.src.Entities
{



    internal abstract class heroEntitiesNew
    {
        public heroEntitiesNew(string Name, int Level,  string TypeHero, int HP ,int MP)
        {
            this.Name = Name;
            this.HP = HP;
            this.MP = MP;
            this.Level = Level;
           this.TypeHero = TypeHero;
        }

        public heroEntitiesNew()
            {
            }

        public string Name;
        public int Level;
        public string TypeHero;
        public int HP;
        public int MP;

        public override string ToString()
        {
            return this.Name + " \n Level: " + this.Level + "\n Type: " + this.TypeHero + "\n Health: " + this.HP + "\n Magic Point: " + this.MP + "\n";
        }
  

        public virtual string AtackHero()
        {
            return this.Name + " Ataque com Espada";
        }
        public string AtackHero(int Bonus)
        {
            return this.Name + " Ataque com Espada" + Bonus;
        }
    }


}
