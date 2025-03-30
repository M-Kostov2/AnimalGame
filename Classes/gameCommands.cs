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
        public void EscKey(int tempRow,int tempCol)
        {
            int row = tempRow;
            int col = tempCol;

            Console.Clear();
            Console.SetCursorPosition(0, 0);

            matrixGeneration matrix = new();
            animalsOptions animals = new();
            TrackProgress kills = new();



            int currentCharachter;
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
                matrix.MatrixWriter();



            }
            else if (Command.Key == ConsoleKey.B)//Change Animal
            {

                Console.Clear();
                Console.SetCursorPosition(0, 0);
                animals.ChooseAnimal();
                currentCharachter = int.Parse(Console.ReadLine());
                string newCharachter = animals.GetCurrentPlayer(currentCharachter);
                string[,] Temp = matrix.PlayerGeneration(tempRow, tempCol, newCharachter);
                matrix.MatrixWriter(Temp);

            }
            else if (Command.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                kills.ReturnProgress();
                return;

            }




        }


    }
}
