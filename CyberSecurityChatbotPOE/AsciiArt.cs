using System;

namespace CyberSecurityChatbotPOE
{
    public class AsciiArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //AsciiArt message inserted "ONLINE SAFETY ROCKS!"
            Console.WriteLine(@"

 ____  _      _     _  _      _____   ____  ____  _____ _____ _____ ___  _   ____  ____  ____  _  __ ____  _ 
/  _ \/ \  /|/ \   / \/ \  /|/  __/  / ___\/  _ \/    //  __//__ __\\  \//  /  __\/  _ \/   _\/ |/ // ___\/ \
| / \|| |\ ||| |   | || |\ |||  \    |    \| / \||  __\|  \    / \   \  /   |  \/|| / \||  /  |   / |    \| |
| \_/|| | \||| |_/\| || | \|||  /_   \___ || |-||| |   |  /_   | |   / /    |    /| \_/||  \_ |   \ \___ |\_/
\____/\_/  \|\____/\_/\_/  \|\____\  \____/\_/ \|\_/   \____\  \_/  /_/     \_/\_\\____/\____/\_|\_\\____/(_)

    Cybersecurity Awareness Chatbot
");
            Console.ResetColor();
        }
    }
}
