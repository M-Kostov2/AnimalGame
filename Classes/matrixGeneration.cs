using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class matrixGeneration
    {

        public string[,] BordersGeneration(ref string[,] Field, char border)
        {


            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {

                    if (i == 0)//горна страна
                    {
                        Field[i, j] = border.ToString();
                    }
                    else if (j == Field.GetLength(1) - 1 && i != 0)//дясна страна
                    {
                        Field[i, j] = border.ToString();
                    }
                    else if (j == 0 && i != 0)//лява страна
                    {
                        Field[i, j] = border.ToString();
                    }
                    else if (i == Field.GetLength(0) - 1)//долна страна
                    {
                        Field[i, j] = border.ToString();
                    }
                    else
                    {
                        Field[i, j] = " ";
                    }


                }
            }


            return Field;
        }

        public string[,] obstaclesGeneration(ref string[,] Field)
        {
            Random randNumber = new Random();
            string border = ((char)0x25A0).ToString();
          
            for (int i = 0; i < 40; i++)
            {
                int row = randNumber.Next(0,60);//60
                int col = randNumber.Next(0,100);//100

                if (Field[row,col] == " " )
                {
                    Field[row, col] = "*";
                }


            }





            return Field;
        }

        public void EnemiesGeneration(List<IAnimal> Animals,ref string[,] Field)
        {
            Random randNumber = new Random();

            

            for (int i = 0; i < Animals.Count; i++)
            {
                int row = randNumber.Next(0, 60);//60
                int col = randNumber.Next(0, 100);//100

                string currentAnimal = Animals[i].Name;
                

                if (Field[row, col] == " ")
                {
                    Field[row, col] = currentAnimal[0].ToString().ToUpper();
                }


            }


        }
       
    }
}
