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

        public List<IAnimal> AddAnimal(IAnimal Animal)
        {
            Animals.Add(Animal);
            return  Animals;

        }
        public void ChooseAnimal()
        {   int count = 1;
            for (int i = 0; i < Animals.Capacity; i++)
            {

                Console.WriteLine($"{count}-{Animals[i].Name}-{Animals[i].Icon}");
                count++;
            }

        }

        public string GetCurrentPlayer(int idNum)
        {
           string currentPlayer="";
            currentPlayer = Animals.FirstOrDefault(x=>x.ID == idNum).Icon.ToString();
            
            return currentPlayer; 
        }


    }
}
