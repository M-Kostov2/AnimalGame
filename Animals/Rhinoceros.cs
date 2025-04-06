using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Rhinoceros : Animal
    {


        
        public  string  Name;
        public  int     ID;
        public  string  Icon;
        public  int     Hp;
        public  int     Attack;
        public  int     killCount;
        public  string  Habitat;
        public  int     Kilograms ;
        protected  int   Category;

        //  "Savanha";

        public Rhinoceros(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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
        //Name = "Rhinoceros";
        //ID = 7;
        //Icon = "🦏";
        //Hp = 120;
        //Attack = 13;
        //killCount = 0;
        //Habitat = "Savanha";
        //Kilograms = 3000;
        //Category = 0;




       // ("Rhinoceros", 7, "🦏", 120, 13, "Savanha", 3000);
    }
}
