using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Leopard : Animal
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

        public Leopard(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
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

        //Leopard    = new Animal("Leopard", 13, "🐆", 70, 8, "Forest", 70);
        //🐆 leopard         kilograms-70      ,attack-8      ,hp-70

        //Name = "Leopard";
        //ID = 13;
        //Icon = "🐆";
        //Hp = 70;
        //Attack = 8;
        //killCount = 0;
        //Habitat = "Forest";
        //Kilograms = 70;
        //Category = 0;

    }
}
