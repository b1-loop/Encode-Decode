using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypt
{
    public class Secret
    {
        public static void SecretMessage()
        {
            Console.WriteLine("Secret Message from Bozhidar to everybody");
            Message encoder = new Message(); //objekt av encoder 
            MessageDecoder decoder = new MessageDecoder(); //objekt av decoder

            bool running = true;// så länge man inte väljer exit så körs programet då exit är false

            running = WhileLoopen.WhileLoppen(encoder, decoder, running); //ROPAR UT WhileLoopen klass och kör den
        }
    }
}
