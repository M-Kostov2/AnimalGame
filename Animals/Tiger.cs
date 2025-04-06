using Animal_Game.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal_Game.Animals
{
    public class Tiger : Animal
    {
        
        public string  Name ;
        public int ID;
        public string  Icon;
        public int     Hp;
        public int     Attack;
        public string  Habitat;
        public int     Kilograms;
        public int     killCount;
        protected  int  Category;

        public Tiger(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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
        //("Tiger", 1, "🐅", 100, 10, "Forest", 300);

        //  "Forest"
        //🐅 tiger kilograms-300     ,attack-10     ,hp-100

        //Name = "Tiger";
        //ID = 1;
        //Icon = "🐅";
        //Hp = 100;
        //Attack = 10;
        //Habitat = "Forest";
        //Kilograms = 300;
        //killCount = 0;
        //Category = 0;




    }
}
