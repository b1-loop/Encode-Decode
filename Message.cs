using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypt
{
    public class Message
    {
     public string Encode (string message) 
     {
            string result = "";
            foreach(char c in message) // go through every character
            {
                switch (char.ToUpper(c)) // check the letter
                {
                    case 'A': result += "@"; break;
                    case 'E': result += "3"; break;
                    case 'I': result += "!"; break;
                    case 'O': result += "0"; break;
                    case 'S': result += "$"; break;
                    default: result += c; break; // if not special, keep it
                }
            }

            return result;
        }

    }
}
