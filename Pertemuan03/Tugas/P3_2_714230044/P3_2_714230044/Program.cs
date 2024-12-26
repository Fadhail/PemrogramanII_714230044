namespace P3_2_714230044
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih Menu (1-3): ");

                // Input Pilihan User
                int pilihan = Convert.ToInt16(Console.ReadLine());
                
                // Luas Persegi Panjang
                if (pilihan == 1) 
                {
                    // Memanggil Class Persefi Panjang
                    PersegiPanjang psg = new PersegiPanjang();
                    Console.Write("Masukan Panjang: ");
                    int panjang = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan Lebar: ");
                    int lebar = Convert.ToInt16(Console.ReadLine());

                    int luas = psg.Luas(panjang, lebar);
                    Console.WriteLine($"Luas Persegi Panjang: {luas}");
                }
                // Keliling Persegi Panjang
                else if (pilihan == 2) 
                {
                    // Memanggil Class Persefi Panjang
                    PersegiPanjang psg = new PersegiPanjang();
                    Console.Write("Masukan Panjang: ");
                    int panjang = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukan Lebar: ");
                    int lebar = Convert.ToInt16(Console.ReadLine());

                    int keliling = psg.Keliling(panjang, lebar);
                    Console.WriteLine($"Keliling Persegi Panjang: {keliling}");
                }
                // Exit
                else if (pilihan == 3) 
                {
                    Console.WriteLine("Program Selesai.");
                    Console.WriteLine("Terima Kasih!");
                    Environment.Exit(0);
                }
                // Inputan Tidak Sesuai
                else
                {
                    Console.WriteLine("Menu tidak tersedia. Silahkan pilih menu yang valid.");
                }

                Console.Write("Apakah Anda ingin kembali ke menu utama? (Y/T): ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}