using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class Animal : IAnimal
    {

        public string Name { get; set; }
        public char icon { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Category { get; set; }
        public string Habitat { get; set; }
        public int Kilograms { get; set; }
        public List<int> killCount { get; set; }

    }
}
