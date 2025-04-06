using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Deer : Animal
    {
        
        public string Name;
        public int    ID;
        public string Icon;
        public int    Hp;
        public int    Attack;
        public int    killCount;
        public string Habitat ;
        public int    Kilograms;
        protected int  Category;

        public Deer(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //🦌 deer            kilograms-       ,attack-2    ,hp-
        //Deer      ("Deer", 10, "🦌", "Forest",40,2,200);

        //Name = "Deer";
        //ID = 10;
        //Icon = "🦌";
        //Hp = 40;
        //Attack = 2;
        //killCount = 0;
        //Habitat = "Forest";
        //Kilograms = 200;
        //Category = 0;
    }
}
