using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Hippo : Animal
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

        public Hippo(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //🦛 hippo           kilograms-4000     ,attack-11    ,hp-110
        // Hippo      = new Animal("Hippo", 8, "🦛", 110, 11, "Savanha", 4000);


        //Name = "Hippo";
        //ID = 8;
        //Icon = "🦛";
        //Hp = 110;
        //Attack = 11;
        //killCount = 0;
        //Habitat = "Savanha";
        //Kilograms = 4000;
        //Category = 0;    
    }
}
