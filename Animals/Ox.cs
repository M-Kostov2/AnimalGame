using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Ox : Animal
    {
        
        public string Name;
        public int    ID;
        public string Icon;
        public int    Hp;
        public int    Attack;
        public int    killCount; 
        public string Habitat;
        public int    Kilograms;
        protected  int Category;

        public Ox(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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
        //ox              kilograms-1000       ,attack-5    ,hp-30
        //Ox         = new Animal("Ox", 2, "🐂 ", 30, 5, "Forest", 1000);

        //Name = "Ox";
        //ID = 2;
        //Icon = "🐂 ";
        //Hp = 30;
        //Attack = 5;
        //killCount = 0;
        //Habitat = "Forest";
        //Kilograms = 1000;
        //Category = 0;





    }
}
