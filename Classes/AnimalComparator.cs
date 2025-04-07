using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal_Game.Classes;

namespace Animal_Game.Classes
{
    public class AnimalComparator
    {
        public bool Comparator(ref string[,] gameField1,ref List<Animal> Animals, string PlayerIcon, string EnemyIcon)
        {
            bool Proceed = false;
            string[,] gameField = gameField1;
            List<Animal> AnimalsTemp = new List<Animal>(2);
            AnimalsTemp[0] = Animals.First(x => x.Icon == PlayerIcon);
            AnimalsTemp[1] = Animals.First(x => x.Icon == EnemyIcon);

            if (Animals[0].Habitat != Animals[1].Habitat)
            {
                Console.WriteLine("Animals can't interacr due to different Habitats");
                return false;

            }
            else if (Animals[0].Habitat == Animals[1].Habitat)
            {

                if (Animals[0].Category == Animals[1].Category)
                {
                    if (Animals[0].Attack >= Animals[1].Attack && Animals[0].Hp >= Animals[1].Hp)
                    {
                        Animals.First(x => x.Icon == PlayerIcon).killCount++;
                        return true;

                    }
                    else if (Animals[0].Attack <= Animals[1].Attack && Animals[0].Hp <= Animals[1].Hp)
                    {
                        Animals.First(x => x.Icon == EnemyIcon).killCount++;                        
                        return false;
                        
                    }

                }
                else if (Animals[0].Category > Animals[1].Category)
                {
                    Animals.First(x => x.Icon == PlayerIcon).killCount++;
                    return true;
                }
                else if (Animals[0].Category < Animals[1].Category && Animals[0].Attack < Animals[1].Attack)
                {
                    Animals.First(x => x.Icon == EnemyIcon).killCount++;
                    return false;


                }



            }


            return Proceed;
        }


    }
}
