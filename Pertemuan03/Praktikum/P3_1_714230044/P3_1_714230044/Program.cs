namespace P3_1_714230044
{
    class  Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("MENENTUKAN INDEKS PRESTASI MAHASISWA\n--------------------------");
                Console.Write("\nMasukan Nama Mahasiswa : ");

                String nama = Console.ReadLine();
                
                Console.Write("Masukan Nilai : ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };
                if (nilai >= 85)
                {
                    Console.WriteLine($"Indeks nilai {nama} adalah {grade[0]}");
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine($"Indeks nilai {nama} adalah {grade[1]}");
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine($"Indeks nilai {nama} adalah {grade[2]}");
                }
                else
                {
                    Console.WriteLine($"Indeks nilai {nama} adalah {grade[3]}");
                }
                
                Console.Write("\nMasukan Indeks yang ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Indeks prestasi {nama} adalah");

                Prestasi(indeks);
                
                Console.Write("\nIngin mengulang kembali (Y/T)");
            } while (Console.ReadLine() == "Y");
        }

        private static void Prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Invalid indeks prestasi");
                    break;
            }
        }
    }
}