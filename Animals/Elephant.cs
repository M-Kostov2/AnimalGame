using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Elephant : Animal
    {
        
       public  string Name;
       public  int    ID;
       public  string Icon;
       public  int    Hp;
       public  int    Attack;
       public  int     killCount;
       public  string Habitat;
       public  int    Kilograms;
       protected int  Category;

        public Elephant(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //Elephant   = new Animal("Elephant", 4, "🐘", 150, 1, "Savanha", 5000);
        // elephant        kilograms-5000      ,attack-15   ,hp-150
        //Name = "Elephant";
        //ID = 4;
        //Icon = "🐘";
        //Hp = 150;
        //Attack = 15;
        //killCount = 0;
        //Habitat = "Savanha";
        //Kilograms = 5000;
        //Category = 0;

    }
}
