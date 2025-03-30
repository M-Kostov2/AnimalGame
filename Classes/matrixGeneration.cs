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
       
        private char border { get; }

  
        public matrixGeneration()
        {
            fieldDemensions = new gameField();
            Field = fieldDemensions.playField;
            border = fieldDemensions.border;
           // IAnimal Animal = new Animal();
        }

           public int currentrow = 0;
           public  int currentcol = 0;

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
            string playerCharacter = "🌲";
            for (int i = 0; i < 20; i++)
            {
                int row = randNumber.Next(0, 40); //   60- данни за лаптопа  // данни за настолния компютър-     // тестови данни за компютъра -40
                int col = randNumber.Next(0, 60); //   79-данни за лаптопа   // данни за настолния компютър-     // тестови данни за компютъра -60

                if (Field[row, col] == "  ")
                {
                    Field[row, col] = playerCharacter;
                }


            }
            playerCharacter = "🌴";

            for (int i = 0; i < 20; i++)
            {
                int row = randNumber.Next(0, 40); //   60- данни за лаптопа  // данни за настолния компютър-     // тестови данни за компютъра -40
                int col = randNumber.Next(0, 60); //   79-данни за лаптопа   // данни за настолния компютър-     // тестови данни за компютъра -60

                if (Field[row, col] == "  ")
                {
                    Field[row, col] = playerCharacter;
                }


            }
            
             playerCharacter = "🌵";

            for (int i = 0; i < 20; i++)
            {
                int row = randNumber.Next(0, 40); //   60- данни за лаптопа  // данни за настолния компютър-     // тестови данни за компютъра -40
                int col = randNumber.Next(0, 60); //   79-данни за лаптопа   // данни за настолния компютър-     // тестови данни за компютъра -60

                if (Field[row, col] == "  ")
                {
                    Field[row, col] = playerCharacter;
                }


            }




            return Field;
        }

        public string[,] EnemiesGeneration()
        {
            List<IAnimal> Animals = new List<IAnimal>();

            Random randNumber = new Random();




            for (int i = 0; i < Animals.Count; i++)
            {
                int row = randNumber.Next(0, 40);//60          //40 test  //60 laptop
                int col = randNumber.Next(0, 60);//100        //60 test  //79 laptop

                string currentAnimal = Animals[i].Name;


                if (Field[row, col] == " ")
                {
                    Field[row, col] = currentAnimal[0].ToString().ToUpper();
                }


            }

            return Field;
        }

        public string[,] PlayerGeneration(string currentPlayer)//,ref string[,] gameField
        {
            Random randNumber = new Random();

            bool validPosition = false;
           

            while (!validPosition)
            {
                int row = randNumber.Next(0, 40);//60          //40 test  //60 laptop
                int col = randNumber.Next(0, 60);//100        //60 test  //79 laptop
                
                                                  // има шанс да гръмне тук
               // string currentAnimal = Animals.FirstOrDefault(x => x.Name == currentPlayer).ToString();


                if (Field[row, col] == "  ")
                {
                    Field[row, col] = currentPlayer;//Animals.FirstOrDefault(x => x.Name == currentPlayer).icon.ToString();
                    validPosition = true;
                    currentrow = row;
                    currentcol = col;

                    
                }


            }

            return Field;
            
        }
        public string[,] PlayerGeneration(int tempRow,int tempCol, string currentPlayer)//,ref string[,] gameField
        {
           
            int row = tempRow;
            int col = tempCol;
            Field[row, col] = currentPlayer;

            return Field;

        }

        public void MatrixWriter()//ref string[,] gameField
        {

            for (int i = 0; i < Field.GetLength(0); i++)
            {
                for (int j = 0; j < Field.GetLength(1); j++)
                {
                    Console.Write($"{Field[i, j]} ");
                }
                Console.WriteLine();
            }



        }

        public void MatrixWriter(string[,] gameField)//ref string[,] gameField
        {

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write($"{gameField[i, j]} ");
                }
                Console.WriteLine();
            }



        }

        public int[] GetCoordinates()
        {
            int[] coordinates = new int[2];
            coordinates[0] = currentrow;
            coordinates[1] = currentcol;
        
            return coordinates;
        }

       


    }
}
