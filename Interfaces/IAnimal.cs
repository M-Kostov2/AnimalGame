using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        int ID { get; }
        string Icon { get; }
        int Hp { get; }
        int Attack { get; }
        int Category { get; }
        string Habitat { get; }
        int Kilograms { get; }
        int killCount { get; }




    }
}
