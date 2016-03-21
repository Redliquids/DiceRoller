using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Roller.Models;

namespace Roller.Models
{
    class Functions
    {

        Random RandomNr = new Random();

        public int RollFunction(int MaxNr)
        {

            int Result = RandomNr.Next(1, MaxNr);
            Console.WriteLine("You Roll: " + Result);

            Console.WriteLine();
            Console.WriteLine("Press any key to return to the Menu");
            Console.ReadKey();
            Console.Clear();

            return Result;

        }
        public void Exit()
        {
        }


    }
}
