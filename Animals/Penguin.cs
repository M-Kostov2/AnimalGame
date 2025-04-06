using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Penguin : Animal
    {


        
        public string  Name;
        public int     ID;
        public string  Icon;
        public int     Hp;
        public int     Attack;
        public int     killCount;
        public string  Habitat;
        public int     Kilograms;
        protected  int Category;

        public Penguin(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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


        //Penguin    = new Animal("Penguin", 11, "🐧", 10, 0, "South Pole", 30);
        //🐧 penguin         kilograms-30      ,attack-0      ,hp-10

        //Name = "Penguin";
        //ID = 11;
        //Icon = "🐧";
        //Hp = 10;
        //Attack = 0;
        //killCount = 0;
        //Habitat = "South Pole";
        //Kilograms = 30;
        //Category = 0;
    }
}
