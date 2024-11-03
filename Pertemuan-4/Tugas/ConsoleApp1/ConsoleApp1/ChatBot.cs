using System;

namespace ChatBotApp
{
    // Abstraction
    public abstract class ChatBot
    {
        private string Nama; // Encapsulation

        // Constructor
        protected ChatBot(string name)
        {
            Nama = name;
        }

        // Encapsulation
        public string Name
        {
            get { return Nama; }
        }
        
        public abstract void SapaBot();
        public abstract void Respon(string message);
    }
}