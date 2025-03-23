using Animal_Game.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Interfaces
{
    public interface IanimalsOptions
    {
        abstract void AddAnimal(IAnimal Animal);

        abstract void RemoveAnimal(IAnimal Animal);

        abstract void AnimalEncounter(IAnimal CurrentAnimal, IAnimal AnimalEncounter);




        

    }
}
