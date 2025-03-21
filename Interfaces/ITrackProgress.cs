using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Interfaces
{
    public interface ITrackProgress
    {

        
        abstract void AddAnimalProgress(IAnimal Animal);
      

        abstract void ReturnProgress();
       
    }
}
