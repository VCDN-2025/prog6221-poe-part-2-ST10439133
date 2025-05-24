using System;
using System.Collections.Generic;

namespace CyberSecurityChatbotPOE
{
    public class Chat
    {
        private static string userName = "";
        private static string userInterest = "";
        private static List<int> usedPhishingIndexes = new();
        private static Random rand = new();
        private static List<int> usedPasswordIndexes = new();
        private static List<int> usedScamIndexes = new();

        // Dictionary containing keyword-based responses for key cybersecurity topics.
        private static readonly Dictionary<string, string> keywordResponses = new()
        {
            { "password", "Make sure to use strong, unique passwords for each account. Avoid using personal details in your passwords." },
            { "privacy", "Keep your data private by reviewing app permissions and limiting what you share online." },
            { "scam", "Always verify messages from unknown senders. Don’t click links or share information unless you’re sure it’s safe." }
        };

        // List of phishing safety tips. One will be randomly selected to provide variation in chatbot responses.
        private static readonly List<string> phishingTips = new()
        {
            "Be careful with emails that request your personal details. Fraudsters often pretend to be reputable companies.",
            "Always hover your mouse over a link to see where it leads before clicking. Stay away from suspicious or unknown websites.",
            "Look closely at the sender’s email—watch out for tiny spelling errors or odd characters that might indicate a fake address.",
            "Genuine businesses won’t ask for private information like passwords or ID numbers via email."
        };

        private static readonly List<string> passwordTips = new()
        {
            "Use a passphrase you can remember but others can't guess—like 'Blue$Sky!1985'.",
            "Avoid using the same password across multiple sites.",
            "Consider using a reputable password manager to store your credentials safely."
        };

        private static readonly List<string> scamTips = new()
        {
            "Don't trust messages that pressure you into acting fast—scammers love urgency.",
            "If it sounds too good to be true, it probably is—verify before responding.",
            "Never share OTPs or login info, even if the request looks official."
        };

        // Dictionary for detecting basic user sentiment and providing empathetic responses.
        private static readonly Dictionary<string, string> sentimentResponses = new()
        {
            { "worried", "Feeling worried is completely normal. Let's work through it so you can feel safer." },
            { "curious", "It's great that you're curious—learning is the first step to staying safe online. Go ahead and ask!" },
            { "frustrated", "Don't worry, I'm here to guide you. Cybersecurity can be confusing, but you’ve got support!" }
        };

        public static void StartChat()
        {
            Console.WriteLine("=====================================================");
            Console.Write(" What's your name? ");
            userName = Console.ReadLine()?.Trim();
            Console.WriteLine($" Welcome, {userName}! Let's learn about staying safe online.");
            Console.WriteLine("=====================================================");

            bool continueChat = true;

            while (continueChat)
            {
                Console.Write("\n Ask me a cybersecurity question (or type 'exit'): ");
                string input = Console.ReadLine()?.ToLower();

                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(" I didn't really understand that. Can you possibly be more clear?");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine($" Hope to see you again, {userName}! Remember to stay safe online.");
                    Console.WriteLine("=====================================================");
                    break;
                }

                if (input == "how are you")
                {
                    Console.WriteLine($" I am just a ChatBot, I do not have feelings, silly... I can help by answering a cybersecurity question though. Try asking me a question about Phishing, Passwords or Privacy.");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    continue;
                }

                // Sentiment detection
                foreach (var sentiment in sentimentResponses)
                {
                    if (input.Contains(sentiment.Key))
                    {
                        Console.WriteLine(sentiment.Value);
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    }
                }

                // Keyword recognition and memory
                bool matchedKeyword = false;
                foreach (var keyword in keywordResponses)
                {
                    if (input.Contains(keyword.Key))
                    {
                        Console.WriteLine(keyword.Value);
                        if (string.IsNullOrEmpty(userInterest))
                        {
                            userInterest = keyword.Key;
                            Console.WriteLine($" I won't forget that you're interested in {userInterest}.");
                        }
                        matchedKeyword = true;
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                        break;
                    }
                }

                // Random phishing tips
                // Show tips based on topic with non-repetition
                if (input.Contains("phishing") || input.Contains("password") || input.Contains("scam"))
                {
                    string topic = input.Contains("phishing") ? "phishing"
                                 : input.Contains("password") ? "password"
                                 : "scam";

                    List<string> tipsList = topic == "phishing" ? phishingTips
                                        : topic == "password" ? passwordTips
                                        : scamTips;

                    List<int> usedIndexes = topic == "phishing" ? usedPhishingIndexes
                                         : topic == "password" ? usedPasswordIndexes
                                         : usedScamIndexes;

                    if (usedIndexes.Count == tipsList.Count)
                    {
                        usedIndexes.Clear(); // Reset after all tips are used
                        Console.WriteLine($" You've seen all my {topic} tips! Let's start over.");
                    }

                    int tipIndex;
                    do
                    {
                        tipIndex = rand.Next(tipsList.Count);
                    } while (usedIndexes.Contains(tipIndex));

                    usedIndexes.Add(tipIndex);
                    Console.WriteLine($" {topic.First().ToString().ToUpper() + topic.Substring(1)} Tip: {tipsList[tipIndex]}");

                    matchedKeyword = true;
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                }



                // Follow-up personalization
                if (input.Contains("interested") && !string.IsNullOrEmpty(userInterest))
                {
                    Console.WriteLine($" Since you're interested in {userInterest}, here's more information:");
                    Console.WriteLine(keywordResponses[userInterest]);
                    matchedKeyword = true;
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                }

                if (!matchedKeyword)
                {
                    Console.WriteLine(" I'm not sure I understand. Can you try rephrasing?");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                }
            }
        }
    }
}
