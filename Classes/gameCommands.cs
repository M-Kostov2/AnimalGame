using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class gameCommands
    {
       matrixGeneration matrix = new();

        public string[,] EscKey(ref string[,] gameField1,ref List<Animal> Animals,int tempRow,int tempCol,ref  string currentPlayer)
        {
            int row = tempRow;
            int col = tempCol;

            Console.Clear();
            Console.SetCursorPosition(0, 0);

            
            AnimalsOptions animals = new();
            TrackProgress kills = new();

             string[,] tempgameField1 = gameField1;


            Console.WriteLine("Press the button for command you want to proceed with-");
            Console.WriteLine("-Esc->Esc\n" +
               "-Change Animal->B\n" +
               "-End game->BackSpace");

            ConsoleKeyInfo Command;
            Command = Console.ReadKey();
            if (Command.Key == ConsoleKey.Escape)//Esc == resume
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                



            }
            else if (Command.Key == ConsoleKey.B)//Change Animal
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                string playerIcon = matrix.Animalchange();
                currentPlayer = playerIcon;
                tempgameField1 = matrix.PlayerGeneration(row, col, playerIcon,ref gameField1);
                
            }
            else if (Command.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                kills.ReturnProgress(Animals);
                Environment.Exit(0);

            }


            return tempgameField1;

        }


    }
}
