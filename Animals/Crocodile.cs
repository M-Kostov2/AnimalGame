using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Crocodile : Animal
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

        public Crocodile(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //Crocodile  = new Animal("Crocodilе", 12, "🐊", 80, 10, "Savanha", 500);
        //crocodile       kilograms-500      ,attack-10    ,hp-80


        //Name = "Crocodile";
        //ID = 12;
        //Icon = "🐊";
        //Hp = 80;
        //Attack = 10;
        //killCount = 0;
        //Habitat = "Savanha";
        //Kilograms = 500;
        //Category = 0;


    }
}
