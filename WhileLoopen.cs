using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypt
{
    public class WhileLoopen
    {
        //min statiska klass med swicht och while samt konstruktor 
        public static bool WhileLoppen(Message encoder, MessageDecoder decoder, bool running)
            
        {
            
            while (running) // keep showing menu until Exit
            {
                
                InputHelper.ShowMenu();
                int choice = InputHelper.ReadChoice();
                
                switch (choice)
                {
                    case 1: // Encode
                        string textToEncode = InputHelper.ReadText("Enter text to encode provide only CAPS: ");
                        string encoded = encoder.Encode(textToEncode);
                        Console.WriteLine("Encoded: " + encoded + "");
                        break;

                    case 2: // Decode
                        string textToDecode = InputHelper.ReadText("Enter text to decode: ");
                        string decoded = decoder.Decode(textToDecode);
                        Console.WriteLine("Decoded: " + decoded + "");
                        break;

                    case 3: // Exit
                        Console.WriteLine("Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Please choose 1, 2 or 3.");
                        break;
                }
            }

            return running;
        }
    }
}
