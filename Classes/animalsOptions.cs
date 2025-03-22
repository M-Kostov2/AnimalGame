using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class animalsOptions //: IanimalsOptions
    {
        private readonly List<IAnimal> Animals;

        public void AddAnimal(IAnimal Animal)
        {
            Animals.Add(Animal);
        }


    }
}
