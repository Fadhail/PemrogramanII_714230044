using System;

namespace ChatBotApp
{
    // Inheritance
    public class JawabanChatBot : BasicChatBot
    {
        public JawabanChatBot(string name) : base(name)
        {
        }

        // Polymorphism
        public override void Respon(string message)
        {
            string lowerMessage = message.ToLower();

            if (lowerMessage.Contains("bantuan"))
            {
                Console.WriteLine("Berikut pertanyaan seputar OOP yang bisa lo tanya:");
                Console.WriteLine("Ketik \"apa itu abstraction\"");
                Console.WriteLine("Ketik \"apa itu inheritance\"");
                Console.WriteLine("Ketik \"apa itu polymorphism\"");
                Console.WriteLine("Ketik \"apa itu encapsulation\"");
                Console.WriteLine("Ketik \"apa itu constructor\"");
            }
            else if (lowerMessage.Contains("hai"))
            {
                Console.WriteLine("Halo, bro! Mau nanya apa nih seputar OOP?");
            }
            else if (lowerMessage.Contains("apa kabar"))
            {
                Console.WriteLine("Gue baik, makasih udah nanya! Lo gimana?");
            }else if (lowerMessage.Contains("baik"))
            {
                Console.WriteLine("Mantap!, lo mau nanya apa sekarang seputar OOP?");
            }
            else if (lowerMessage.Contains("apa itu abstraction"))
            {
                Console.WriteLine("Abstraksi itu kayak nyembunyiin hal-hal rumit dan cuma nampilin yang penting aja. Biar nggak pusing gitu!");
            }
            else if (lowerMessage.Contains("apa itu inheritance"))
            {
                Console.WriteLine("Inheritance itu mekanisme di mana kelas baru bisa mewarisi sifat dan perilaku dari kelas yang udah ada. Jadi bisa pake kode yang sama!");
            }
            else if (lowerMessage.Contains("apa itu polymorphism"))
            {
                Console.WriteLine("Polimorfisme bikin objek bisa diperlakukan kayak kelas induknya. Jadi satu aksi bisa beda cara kerjanya tergantung konteksnya.");
            }
            else if (lowerMessage.Contains("apa itu encapsulation"))
            {
                Console.WriteLine("Enkapsulasi itu ngumpulin data sama metode yang berfungsi di data itu ke dalam satu kelas, supaya aksesnya dibatasi.");
            }
            else if (lowerMessage.Contains("apa itu constructor"))
            {
                Console.WriteLine("Konstruktor itu metode khusus yang dipanggil pas lo bikin objek dari kelas. Dipake buat ngisi nilai properti objek.");
            }
            else if (lowerMessage.Contains("bye"))
            {
                Console.WriteLine("Oke, sampai jumpa! Semoga harimu menyenangkan!");
            }
            else
            {
                base.Respon(message);
            }
        }
    }
}
