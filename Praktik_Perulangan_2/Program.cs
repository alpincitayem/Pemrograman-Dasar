using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_Perulangan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untukmenyimpan hasil penjumblahan
            int total = 0;

            Console.WriteLine("Menghitung jumblah angka dari 1 sampai 5:");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
             // Tambahkan nilai i saat ini ke variabl total
             total = total + i; // Bisa juga ditulis sebagai: total+= i;

             // Tampilkan proses penjumblahan di setiap langkah
             Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);
            }

            // Tampilkan hasil akhir setelan perulangan selesai
            Console.WriteLine("\nHasil akhir penjumblahan adalah: " + total);
        }
    }
}
