using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sarah = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"            
            };

            var amrit = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Amrit"
            };

            var gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);


            Console.ReadLine();
        }
    }
}
