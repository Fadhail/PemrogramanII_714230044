using System;

namespace ChatBotApp
{
    // Inheritance
    public class BasicChatBot : ChatBot
    {
        public BasicChatBot(string name) : base(name)
        {
        }

        // Polymorphism
        public override void SapaBot()
        {
            Console.WriteLine($"Halo! Gue {Name}, bot obrolan seputar OOP. Ada yang bisa gue bantu hari ini, ga?");
        }

        // Polymorphism
        public override void Respon(string message)
        {
            Console.WriteLine($"Sorry, gue gak ngerti '{message}'. Ketik 'bantuan' buat liat daftar pertanyaannya.");
        }
    }
}