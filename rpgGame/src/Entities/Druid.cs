using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgGame.src.Entities
{
    internal class Druid : heroEntitiesNew 
    {
        public Druid(string Name, int Level, string TypeHero, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.TypeHero = TypeHero;
            this.HP = HP;
            this.MP = MP;
        }
        public override string AtackHero()
        {
            if(this.TypeHero == "white")
            {

            return this.Name + " Não sei atacar só curo ";
            }
            else
            {
                return this.Name + "Ataque com veneno ";
            }

        }
        public string AtackHero(int Bonus)
        {

            if(this.TypeHero == "white")
            {

            if (Bonus > 6)
            {
                return this.Name + " Cura super poderosa!! Hp Restaurados: " + Bonus;
            }
            else
            {
                return this.Name + " Fail cure " + Bonus;
            }
            }
            else
            {
                if (Bonus > 6)
                {
                    return this.Name + " venenos letal!!: " + Bonus;
                }
                else
                {
                    return this.Name + " veneno não fez efeito " + Bonus;
                }
            }


        }
    }
}
