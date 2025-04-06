using Animal_Game.Animals;
using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class AnimalsOptions //: IanimalsOptions
    {
        public readonly List<Animal> Animals;

        public AnimalsOptions()
        {
                Animals = AddAnimal();
        }


        private List<Animal> AddAnimal()
        {
            List<Animal> Animals = new List<Animal>();
           Animal Tiger = new Tiger("Tiger", 1, "🐅", 100, 10, "Forest", 300);//1                                Tiger     
           Animal Ox = new Ox("Ox", 2, "🐂", 30, 5, "Forest", 1000);//2                                         Ox        
           Animal Monkey = new Monkey("Monkey", 3, "🐒", 20, 3, "Forest", 50);//3                                Monkey    
           Animal Elephant = new Elephant("Elephant", 4, "🐘", 150, 1, "Savanha", 5000);//4                      Elephant  
           Animal Rabbit = new Rabbit("Rabbit", 5, "🐇", 10, 1, "Forest", 4);//5                                 Rabbit    
           Animal Gorilla = new Gorilla("Gorilla", 6, "🦍", 80, 8, "Forest", 300);//6                            Gorilla   
           Animal Rhinoceros = new Rhinoceros("Rhinoceros", 7, "🦏", 120, 13, "Savanha", 3000);//7               Rhinoceros
           Animal Hippo = new Hippo("Hippo", 8, "🦛", 110, 11, "Savanha", 4000);//8                              Hippo     
           Animal Giraffe = new Giraffe("Giraffe", 9, "🦒",70, 6,"Savanha", 1100);//9                            Giraffe   
           Animal Deer = new Deer("Deer", 10, "🦌", 40, 2, "Forest", 200);//10                                   Deer      
           Animal Penguin = new Penguin("Penguin", 11, "🐧", 10, 0, "South Pole", 30);//11                       Penguin   
           Animal Crocodile = new Crocodile("Crocodilе", 12, "🐊", 80, 10, "Savanha", 500);//12                  Crocodile 
           Animal Leopard = new Leopard("Leopard", 13, "🐆", 70, 8, "Forest", 70);//13                           Leopard   
           Animal Bear = new Bear("Bear", 14, "🐻", 100, 12, "Forest", 500);//14                                 Bear      


            Animals.Add(Tiger);
            Animals.Add(Ox);
            Animals.Add(Monkey);
            Animals.Add(Elephant);
            Animals.Add(Rabbit);
            Animals.Add(Gorilla);
            Animals.Add(Rhinoceros);
            Animals.Add(Hippo);
            Animals.Add(Giraffe);
            Animals.Add(Deer);
            Animals.Add(Penguin);
            Animals.Add(Crocodile);
            Animals.Add(Leopard);
            Animals.Add(Bear);



            return  Animals;


        }
        public int ChooseAnimal()
        {   int count = 1;
            int currentCharachter = 0;
            
            for (int i = 0; i < Animals.Count; i++)
            {

                Console.WriteLine($"{count}-{Animals[i].Name}-{Animals[i].Icon}");
                count++;            
            }
              
           //  Console.SetCursorPosition(0,Animals.Count+1);
             currentCharachter = int.Parse(Console.ReadLine());
           


            return currentCharachter;
        }

        public int ChangeAnimaPlayer()
        {
            int count = 1;
            int currentCharachter = 0;
            Console.WriteLine();
            for (int i = 0; i < Animals.Count; i++)
            {

                Console.WriteLine($"{count}-{Animals[i].Name}-{Animals[i].Icon}");
                count++;
            }
            

          //  Console.SetCursorPosition(0,Animals.Count+1);
            currentCharachter = int.Parse(Console.ReadLine());



            return currentCharachter;


        }


        public string GetCurrentPlayer(int idNum)
        {
           string currentPlayer="";
            currentPlayer = Animals.FirstOrDefault(x=>x.ID == idNum).Icon.ToString();
            
            return currentPlayer; 
        }

        


    }
}
