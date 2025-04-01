using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Tiger : Animal
    {
        public string Name = "Tiger";
        public int ID = 1;
        public string Icon = "🐅";
        public int Hp = 100;
        public int Attack = 10;
        public int Category  = 
        public string Habitat = "Forest";
        public int Kilograms = 300;
        public int killCount =

        // Animal Tiger      = new Animal("Tiger", 1, , 100, 10, "Forest", 300);
        //🐅 tiger           kilograms-300     ,attack-10     ,hp-100

        public Tiger(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
        {
           


        }
    }
}
