using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class gameField
    {
         public string[,] playField {  get; private set; }
         public char border = (char)0x25A0;

        public gameField()
        {
          playField = new string[40, 60]; //лаптоп-60,79 //тест компютър 40,60
        }

    }
}
