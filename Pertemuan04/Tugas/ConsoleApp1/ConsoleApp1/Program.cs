using System;

namespace ChatBotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor
            JawabanChatBot bot = new JawabanChatBot("Simpel ChatBot");

            bot.SapaBot(); 
            
            while (true)
            {
                Console.Write("Kamu: ");
                string userMessage = Console.ReadLine();
                
                if (userMessage.ToLower() == "exit")
                {
                    bot.Respon("bye");
                    break;
                }

                bot.Respon(userMessage);
            }
        }
    }
}