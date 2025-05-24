using System;
using System.Threading;
using NAudio.Wave;

namespace CyberSecurityChatbotPOE
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //call voice greeting method
            VoiceGreeting.PlayGreeting();
            //call AsciiArt method
            AsciiArt.DisplayLogo();
            //call ChatInterface method
            Chat.StartChat();

            

        }
        

    }
}

/*
References: 
1. CYBERSECURITY QUIZ BOT PROJECT
Project: Cybersecurity Awareness Quiz Bot for South African Teenagers,
Pieterse, H. (2021). The Cyber Threat Landscape in South Africa: A 10-Year Review.
The African Journal of Information and Communication, 28(28).
Available at: https://www.scielo.org.za/scielo.php?pid=S2077-72132021000200003&script=sci_arttext
Developed by: Camryn Naidoo
Date: 15/04/2025
*/


// References :
// 2.  OWASP Foundation, 2024. *OWASP Top 10 Security Practices*. 
// Available at: <https://owasp.org/www-project-top-ten/> 
// Date: 21/05/202.
//
// 3.  Microsoft, n.d. *Create intelligent conversational bots*.
// Available at: <https://learn.microsoft.com/en-us/azure/bot-service/bot-builder-concept-intelligence> 
// Date: 21/05/202.





