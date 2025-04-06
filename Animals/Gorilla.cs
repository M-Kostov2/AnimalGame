using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Gorilla :Animal
    {
       
        public  string    Name;
        public  int       ID;
        public  string    Icon;
        public  int       Hp;
        public  int       Attack;
        public int        killCount;
        public  string    Habitat;
        public  int       Kilograms; 
        protected int      Category;

        public Gorilla(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //🦍 gorilla         kilograms-300       ,attack-8    ,hp-80
        //Gorilla    = new Animal("Gorilla", 6, "🦍", 80, 8, "Forest", 300);

        //"Jungle"/
        //Name = "Gorilla";
        //ID = 6;
        //Icon = "🦍";
        //Hp = 80;
        //Attack = 8;
        //killCount = 0;
        //Habitat = "Forest";
        //Kilograms = 300;
        //Category = 0;
    }
}
