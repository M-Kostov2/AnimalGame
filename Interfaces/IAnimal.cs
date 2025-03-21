using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Hp { get; set; }
        int Attack { get; set; }
        int Category { get; set; }
        string Habitat { get; set; }
        int Kilograms { get; set; }
        List<int> killCount { get; set; }



     
    }
}
