using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perulangan7
{
    internal class Program
    {
     static void Main(string[] args)
     {
      int angka;

      // blok 'do' dieksekusi minimal satu kali
      do
      {
       Console.WriteLine("masukan angka genap: ");
       // mencoba membaca input dari pengguna
       if (!int.TryParse(Console.ReadLine(), out angka))
       {
         Console.WriteLine("input tidak valid. silakan masukkan angka.");
         // jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut
         angka = 1;
         continue; // lanjutkan ke literai berikutnya
       }
         // memeriksa angka apakah tersebut ganjil
         if (angka % 2 != 0)
            {
              Console.WriteLine($"angka {angka} adalah ganjil. coba lagi.");
            }
         // kondisi diperiksa di akhir. loop berlanjut selama angka ganjil.
            } while (angka % 2 != 0);
              Console.WriteLine($"selamat! anda memasukkan angka genap: {angka}");
            }

    }
}
