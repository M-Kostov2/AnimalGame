using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class TrackProgress : ITrackProgress
    {
        

        public void ReturnProgress(List<Animal> Animals)
        {
            foreach (var Animal in Animals)
            {
                Console.WriteLine($"{Animal.Name} has: {Animal.killCount} kills");
            }
        }

    }
}
