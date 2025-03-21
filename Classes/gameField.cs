using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class gameField
    {
        private string[,] playField = new string[60,100];
        char border = (char)0x25A0;

        private matrixGeneration Gen = new matrixGeneration();

        private gameField()
        {
           playField =  Gen.BordersGeneration(ref playField,border);
            
        }

    }
}
