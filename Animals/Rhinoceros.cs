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
        public string Name ="Rhinoceros";
        public int ID = 7;
        public string Icon = "🦏";
        public int Hp =120;
        public int Attack =13;
        public int Category =;
        public string Habitat =;
        public int Kilograms =3000;
        public int killCount = 0;

        // Animal Rhinoceros = new Animal("Rhinoceros", 7, , 100, 10, "Savanha", 300);
        //🦏 rhinoceros      kilograms-3000      ,attack-13   ,hp-120
        public Rhinoceros(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
        {
           

        }
    }
}
