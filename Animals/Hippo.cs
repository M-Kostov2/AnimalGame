using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Animals
{
    public class Hippo
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public string Icon { get; private set; }
        public int Hp { get; private set; }
        public int Attack { get; private set; }
        public int Category { get; private set; }
        public string Habitat { get; private set; }
        public int Kilograms { get; private set; }
        public int killCount { get; set; }

        public Hippo(string name, int id, string icon, int hp, int attack, string habitat, int kilograms) : base(name, id, icon, hp, attack, habitat, kilograms)
        {
            Name = name;
            ID = id;
            Icon = icon;
            Hp = hp;
            Attack = attack;
            Habitat = habitat;
            Kilograms = kilograms;
            Category = CategorySetter(kilograms, attack, hp);
            killCount = 0;

        }
    }
}
