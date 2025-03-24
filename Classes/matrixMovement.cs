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
        {   Console.OutputEncoding = Encoding.UTF8;
            string currentPlayer = "🐦";
            Console.ReadLine();

            ConsoleKeyInfo key = new ConsoleKeyInfo();
            bool iteratorBoolean = true;

            matrixGeneration matrixGeneration = new matrixGeneration();
            string[,] gameField1 = matrixGeneration.Field;
            gameCommands gameCommands = new gameCommands();

            gameField1 = matrixGeneration.BordersGeneration();//ref gameField1
            gameField1 = matrixGeneration.obstaclesGeneration();//ref gameField1
            gameField1 = matrixGeneration.EnemiesGeneration();//ref gameField1
            gameField1 = matrixGeneration.PlayerGeneration(currentPlayer.ToString());//, ref gameField1
            matrixGeneration.MatrixWriter();


            int[] CurrentCoords = matrixGeneration.GetCoordinates();
            int row = CurrentCoords[0];
            int col = CurrentCoords[1];

            while (iteratorBoolean)
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    gameField1[row, col] = "  ";
                    gameField1[row+1,col] = currentPlayer;
                    

                   

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    gameField1[row, col] = "  ";
                    gameField1[row -1, col] = currentPlayer;
                   
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                     gameField1[row, col] = "  ";
                    gameField1[row , col+1] = currentPlayer;
                    
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    gameField1[row, col] = "  ";
                    gameField1[row , col-1] = currentPlayer;
                   
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    gameCommands.EscKey();

                }

                Console.SetCursorPosition(0, 0);
                matrixGeneration.MatrixWriter(gameField1);

            }



        }


        public void matrixGen()
        { 
        
        
        }





    }





}
