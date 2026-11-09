using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KALKULATOR PENJUMBLAHAN ===");

            Console.Write("Masukkan angka pertama : ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Masukan angka kedua    : ");
            int angka2 = int.Parse(Console.ReadLine());

            int hasil = angka1 + angka2;

            Console.WriteLine($"Hasil: {angka1} + {angka2} = {hasil}");
        }
    }
}
