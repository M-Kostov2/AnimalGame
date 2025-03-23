using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class matrixGeneration : gameField
    {
        public string[,] Field { get; set; }
        private gameField fieldDemensions { get; }
        private IAnimal Animal;
        private char border { get; }

        private List<IAnimal> Animals;

        public matrixGeneration()
        {
            Field = fieldDemensions.playField;
            border = fieldDemensions.border;
            IAnimal Animal = new Animal();
        }



        public string[,] BordersGeneration()
        {


            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {

                    if (i == 0)//горна страна
                    {
                        Field[i, j] = border.ToString() + " ";
                    }
                    else if (j == Field.GetLength(1) - 1 && i != 0)//дясна страна
                    {
                        Field[i, j] = border.ToString() + " ";
                    }
                    else if (j == 0 && i != 0)//лява страна
                    {
                        Field[i, j] = border.ToString() + " ";
                    }
                    else if (i == Field.GetLength(0) - 1)//долна страна 
                    {
                        Field[i, j] = border.ToString() + " ";
                    }
                    else
                    {
                        Field[i, j] = "  ";
                    }


                }
            }


            return Field;
        }

        public string[,] obstaclesGeneration()
        {
            Random randNumber = new Random();
            string border = ((char)0x25A0).ToString();
            string playerCharacter = "🦑";
            for (int i = 0; i < 40; i++)
            {
                int row = randNumber.Next(0, 40);//60
                int col = randNumber.Next(0, 60);//100

                if (Field[row, col] == "  ")
                {
                    Field[row, col] = playerCharacter;
                }


            }





            return Field;
        }

        public void EnemiesGeneration()
        {
            List<IAnimal> Animals = new List<IAnimal>();

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

        public void PlayerGeneration(string currentPlayer)
        {
            Random randNumber = new Random();

            bool validPosition = false;


            while (validPosition)
            {
                int row = randNumber.Next(0, 60);//60
                int col = randNumber.Next(0, 100);//100

                                                  // има шанс да гръмне тук
               // string currentAnimal = Animals.FirstOrDefault(x => x.Name == currentPlayer).ToString();


                if (Field[row, col] == " ")
                {
                    Field[row, col] = Animals.FirstOrDefault(x => x.Name == currentPlayer).icon.ToString();
                    validPosition = true;
                }


            }
        }






        public void MatrixWriter()
        {

            for (int i = 0; i < Field1.GetLength(0); i++)
            {
                for (int j = 0; j < Field1.GetLength(1); j++)
                {
                    Console.Write($"{Field1[i, j]} ");
                }
                Console.WriteLine();
            }



        }



    }
}
