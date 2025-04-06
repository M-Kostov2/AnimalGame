using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Giraffe : Animal
    {
        
        public string   Name;
        public int      ID;
        public string   Icon;
        public int      Hp;
        public int      Attack;
        public int      killCount;
        public string   Habitat;
        public int      Kilograms;
        protected int    Category;

        public Giraffe(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        // ("Giraffe", 9, "🦒", "Savanha",70,6,1100)
        //🦒 giraffe         kilograms-1100       ,attack-6   ,hp-70
        //Name = "Giraffe";
        //ID = 9;
        //Icon = "🦒";
        //Hp = 70;
        //Attack = 6;
        //killCount = 0;
        //Habitat = "Savanha";
        //Kilograms = 1100;
        //Category = 0;


    }
}
