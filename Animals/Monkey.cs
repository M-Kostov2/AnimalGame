using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Monkey : Animal
    {

        public string Name;
        public int ID;
        public string Icon;
        public int Hp;
        public int Attack;
        public int killCount;
        public string Habitat;
        public int Kilograms;
        public int Category;

        public Monkey(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //🐒 monkey          kilograms-50       ,attack-3     ,hp-20
        //Monkey     = new Animal("Monkey", 3,   "🐒", 20, 3, "Forest", 50);

        //Name = "Monkey";
        //ID = 3;
        //Icon = "🐒";
        //Hp = 20;
        //Attack = 3;
        //killCount = 0;
        //Habitat = "Forest";
        //Kilograms = 50;
        //Category = 0;
    }
}
