using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Bear :Animal
    {
        
        public  string Name;
        public  int    ID;
        public  string Icon;
        public  int    Hp;
        public  int    Attack;
        public  int    killCount;
        public  string Habitat;
        public  int    Kilograms;  
        protected int  Category;

        public Bear(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
        {
            Name = name;
            ID = id;
            Icon =icon;
            Hp = hp;
            Attack = attack;
            killCount = 0;
            Habitat = habitat;
            Kilograms = kilograms;
            Category = 0;
        }

        // Bear       = new Animal("Bear", 14, "🐻", 100, 12, "Forest", 500);

        //🐻 bear kilograms-500     , attack-12     , hp-100

            //Name = "Bear";
            //ID = 14;
            //Icon = "🐻";
            //Hp = 100;
            //Attack = 12;
            //killCount = 0;
            //Habitat = "Forest";
            //Kilograms = 500;
            //Category = 0;

    }
}
