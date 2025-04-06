using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class CategorySet 
    {




        public List<Animal> CategorySetter(List<Animal> Animals)
        {           
            List<Animal> animals = Animals;

            for (int i = 0; i < 14; i++)
            {
                int category = 0;
                int kilograms = animals[i].Kilograms;
                int attack = animals[i].Attack;
                int Hp = animals[i].Hp;


                if (kilograms >= 1000 && attack > 10)
                {
                    category = 5;
                }
                else if (kilograms >= 1000 && attack <= 10)
                {
                    category = 4;
                }
                else if (kilograms < 1000 && attack >= 10)
                {
                    category = 4;
                }
                else if (kilograms < 100 && attack < 10 && attack > 4)
                {
                    category = 3;

                }
                else if (kilograms > 100 && attack < 4)
                {
                    category = 2;
                }
                else if (kilograms <= 50 && attack > 4)
                {
                    category = 1;

                }

                animals[i].Category = category; 

            }






            return animals;

        }
    }
}
