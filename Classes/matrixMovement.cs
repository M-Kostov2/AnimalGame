using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class matrixMovement
    {

        public void Movement()
        {
            string currentPlayer = Console.ReadLine();


            ConsoleKeyInfo key = new ConsoleKeyInfo();
            bool iteratorBoolean = true;

            matrixGeneration matrixGeneration = new matrixGeneration();
            string[,] gameField1 = matrixGeneration.Field;
            gameCommands gameCommands = new gameCommands();

            gameField1 = matrixGeneration.BordersGeneration();//ref gameField1
            gameField1 = matrixGeneration.obstaclesGeneration();//ref gameField1
            gameField1 = matrixGeneration.EnemiesGeneration();//ref gameField1
            gameField1 = matrixGeneration.PlayerGeneration(currentPlayer);//, ref gameField1


            int[] CurrentRow = matrixGeneration.GetCoordinates();


            while (iteratorBoolean)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {


                   

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {


                }
                else if (key.Key == ConsoleKey.RightArrow)
                {


                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {


                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    gameCommands.EscKey();

                }

                Console.SetCursorPosition(0, 0);

            }



        }


        public void matrixGen()
        { 
        
        
        }





    }





}
