using Animal_Game.Classes;
using System.Text;

namespace Animal_Game
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            matrixGeneration Gen = new matrixGeneration();
            Console.InputEncoding = Encoding.UTF8;

            string[,] nn = new string[60, 100];
            char border = (char)0x25A0;
          //  nn  = Gen.BordersGeneration(ref nn, border);
          //  nn = Gen.obstaclesGeneration(ref nn);

            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write($"{nn[i,j]} ");
                }
                Console.WriteLine();
            }


            matrixMovement matrixMovement = new matrixMovement();
            matrixMovement.Movement();


        }


          
    }


    
}
