using Animal_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Game.Classes
{
    public class animalsInformation
    {
        // string name, int id, string icon, int hp, int attack, string habitat, int kilograms
        Animal Tiger      = new Animal("Tiger", 1, "🐅", 100, 10, "Forest", 300);
        Animal Ox         = new Animal("Ox", 2, "🐂 ", 100, 10, "Forest", 1000);
        Animal Monkey     = new Animal("Monkey", 3,   "🐒", 100, 10, "Forest", 300);
        Animal Elephant   = new Animal("Elephant", 4, "🐘", 100, 10, "Savanha", 300);
        Animal Rabbit     = new Animal("Rabbit", 5, "🐇", 100, 10, "Forest", 300);
        Animal Gorilla    = new Animal("Gorilla", 6, "🦍", 100, 10, "Jungle", 300);
        Animal Rhinoceros = new Animal("Rhinoceros", 7, "🦏", 100, 10, "Savanha", 300);
        Animal Hippo      = new Animal("Hippo", 8, "🦛", 100, 10, "Savanha", 300);
        Animal Giraffe    = new Animal("Giraffe", 9, "🦒", 100, 10, "Savanha", 300);
        Animal Deer       = new Animal("Deer", 10, "🦌", 100, 10, "Forest", 300);
        Animal Penguin    = new Animal("Penguin", 11, "🐧", 100, 10, "South Pole", 300);
        Animal Crocodile  = new Animal("Crocodilе", 12, "🐊", 100, 10, "Savanha", 300);
        Animal Leopard    = new Animal("Leopard", 13, "🐆", 100, 10, "Forest", 300);
        Animal Bear       = new Animal("Bear", 14, "🐻", 100, 10, "Forest", 300);






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