using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypt
{
    public static class InputHelper
    {
            public static void ShowMenu()
            {
                Console.WriteLine("===SPY MENU ===");
                Console.WriteLine("1) Encode message");
                Console.WriteLine("2) Decode message");
                Console.WriteLine("3) Exit");
                Console.Write("Choose from 1-3: ");
            }

            public static int ReadChoice()
            {
                int.TryParse(Console.ReadLine(), out int choice);
                return choice;
            }

            public static string ReadText(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }
        
    }       
}


