using Animal_Game.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Rabbit : Animal
    {



        public string Name;
        public int ID;
        public string Icon;
        public int Hp;
        public int Attack;
        public int killCount;
        public string Habitat;
        public int Kilograms;
        protected int Category;

        public Rabbit(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
        {
            Name = name;
            ID = id;
            Icon = icon;
            Hp = hp;
            Attack = attack;
            killCount = 0;
            Habitat = habitat;
            Kilograms = kilograms;
            Category = 0;

        }



        //🐇 rabbit          kilograms-4       ,attack-1      ,hp-10
        //Rabbit     = new Animal("Rabbit", 5, "🐇", 10, 1, "Forest", 4);
        //Name = "Rabbit";
        //ID = 5;
        //Icon = "🐇";
        //Hp = 10;
        //Attack = 1;
        //killCount = 0;
        //Habitat = "Forest";
        //Kilograms = 4;
        //Category = 0;



    }
}
