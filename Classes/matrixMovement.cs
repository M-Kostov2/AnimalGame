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
            matrixGeneration.BordersGeneration();
            matrixGeneration.obstaclesGeneration();
            matrixGeneration.EnemiesGeneration();
            matrixGeneration.PlayerGeneration(currentPlayer);

            while (iteratorBoolean)
            {   key = Console.ReadKey();
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

                Console.SetCursorPosition(0, 0);

            }



        }





    }





}
