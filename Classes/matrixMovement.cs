using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class matrixMovement
    {
        matrixGeneration matrixGeneration = new matrixGeneration();

        public async Task Movement()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string currentPlayer = "🐦";


            ConsoleKeyInfo key = new ConsoleKeyInfo();
            bool iteratorBoolean = true;
            Console.SetCursorPosition(0, 0);

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
            string border = matrixGeneration.border + " ".ToString();
            bool freeToProceed1 = true;
            while (iteratorBoolean)
            {


                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow && gameField1[row - 1, col] != border && FreeToProceed(key.Key, row, col) == freeToProceed1)
                {

                    gameField1[row, col] = "  ";
                    gameField1[--row, col] = currentPlayer;



                }
                else if (key.Key == ConsoleKey.DownArrow && gameField1[row + 1, col] != border && FreeToProceed(key.Key, row, col) == freeToProceed1)
                {

                    gameField1[row, col] = "  ";
                    gameField1[++row, col] = currentPlayer;

                }
                else if (key.Key == ConsoleKey.RightArrow && gameField1[row, col + 1] != border && FreeToProceed(key.Key, row, col) == freeToProceed1)
                { 
                    gameField1[row, col] = "  ";
                    gameField1[row, ++col] = currentPlayer;

                }
                else if (key.Key == ConsoleKey.LeftArrow && gameField1[row, col - 1] != border && FreeToProceed(key.Key, row, col) == freeToProceed1)
                {

                    gameField1[row, col] = "  ";
                    gameField1[row, --col] = currentPlayer;

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    gameCommands.EscKey(row, col);

                }

                Console.SetCursorPosition(0, 0);
                matrixGeneration.MatrixWriter(gameField1);

            }



        }


        public bool FreeToProceed(ConsoleKey key, int row, int col)
        {

            string[,] gameField1 = matrixGeneration.Field;

            string tree1 = "🌲";
            string tree2 = "🌴";
            string cactus = "🌵";

            bool freeToProceed = false;
            if (key == ConsoleKey.UpArrow && gameField1[row - 1, col] != tree1 && gameField1[row - 1, col] != tree2 && gameField1[row - 1, col] != cactus)
            {
                freeToProceed = true;

            }
            else if (key == ConsoleKey.DownArrow && gameField1[row + 1, col] != tree1 && gameField1[row + 1, col] != tree2 && gameField1[row + 1, col] != cactus)
            {
                freeToProceed = true;

            }
            else if (key == ConsoleKey.RightArrow && gameField1[row, col + 1] != tree1 && gameField1[row, col + 1] != tree2 && gameField1[row , col+1] != cactus)
            {
                freeToProceed = true;
            }
            else if (key == ConsoleKey.LeftArrow && gameField1[row, col - 1] != tree1 && gameField1[row, col - 1] != tree2 && gameField1[row , col-1] != cactus)
            {
                freeToProceed = true;
            }
            else
            {
                freeToProceed = false;
            }

            return freeToProceed;

        }





    }





}
