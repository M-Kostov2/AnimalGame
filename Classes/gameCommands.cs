using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class gameCommands
    {
        public void EscKey()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            string Command;
            matrixGeneration matrix = new();
            
            Console.WriteLine("Type the command you want to proceed with-");
            Console.WriteLine("-Esc" +
                "-Change Animal" +
                "-End game");

            Command = Console.ReadLine();
            if (Command == "Esc")
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                matrix.MatrixWriter();



            }
            else if (Command =="Change Animal")
            {

                Console.Clear();
                Console.SetCursorPosition(0, 0);
                matrix.MatrixWriter();

            }




        }


    }
}
