using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class Animal : IAnimal
    {
      

        public Animal(string name, int id, string icon, int hp, int attack, string habitat, int kilograms)
        {
            Name = name;
            ID = id;
            Icon = icon;
            Hp = hp;
            Attack = attack;
            Habitat = habitat;
            Kilograms = kilograms;
            Category = CategorySetter(kilograms,attack,hp);
            killCount = 0;
        }

        public string Name { get; private set; }
        public int ID { get; private set; }
        public string Icon { get; private set; }
        public int Hp { get; private set; }
        public int Attack { get; private set; }
        public int Category { get; private set; }
        public string Habitat { get; private set; }
        public int Kilograms { get; private set; }
        public int killCount { get;  set; }

        private int CategorySetter(int kilograms , int attack,int Hp)
        {
            int category = 0;

            if (kilograms >= 1000 && attack > 10)
            {
                category = 5;
            }
            else if (kilograms >= 1000 && attack <= 10)
            {
                category = 4;
            }
            else if (kilograms < 1000 && attack >= 10)
            {
                category = 4;
            }
            else if (kilograms < 100 && attack < 10 && attack > 4)
            {
                category = 3;

            }
            else if (kilograms > 100 && attack < 4)
            {
                category = 2;
            }
            else if (kilograms <= 50 && attack > 4)
            { 
            category = 1;
            
            }


                return category;
        }

    }
}

//🐂 ox              kilograms-1000       ,attack-5    ,hp-30
//🐅 tiger           kilograms-300     ,attack-10     ,hp-100
//🐒 monkey          kilograms-50       ,attack-3     ,hp-20
//🐘 elephant        kilograms-5000      ,attack-15   ,hp-150
//🐇 rabbit          kilograms-4       ,attack-1      ,hp-10
//🦍 gorilla         kilograms-300       ,attack-8    ,hp-80
//🦏 rhinoceros      kilograms-3000      ,attack-13   ,hp-120
//🦛 hippo           kilograms-4000     ,attack-11    ,hp-110
//🦒 giraffe         kilograms-1100       ,attack-6   ,hp-70
//🦌 deer            kilograms-200       ,attack-2    ,hp-40
//🐧 penguin         kilograms-30      ,attack-0      ,hp-10
//🐊 crocodile       kilograms-500      ,attack-10    ,hp-80
//🐆 leopard         kilograms-70      ,attack-8      ,hp-70
//🐻 bear            kilograms-500     ,attack-12     ,hp-100
