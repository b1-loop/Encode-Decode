using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypt
{
    public class MessageDecoder
    {
        public string Decode(string message)
        {
            string result = "";

            foreach (char c in message)
            {
                switch (c)
                {
                    case '@': result += "A"; break;
                    case '3': result += "E"; break;
                    case '!': result += "I"; break;
                    case '0': result += "O"; break;
                    case '$': result += "S"; break;
                    default: result += c; break;
                }
            }

            return result;
        }
    }
}

