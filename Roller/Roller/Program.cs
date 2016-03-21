using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roller.Models;

namespace Roller
{
    class Program
    {
            static void Main(string[] args)
        {

            Menu menu_instance = new Menu();

            Console.WriteLine("Program Initiated.");

            menu_instance.Entered_Menu();

        }



    }
}