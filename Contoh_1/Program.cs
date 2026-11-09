using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoh_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM BIODATA SISWA ===");

            Console.Write("Nama            : ");
            string nama = Console.ReadLine();

            Console.Write("Kelas           : ");
            String kelas = Console.ReadLine();

            Console.Write("Umur            : ");
            int umur = int.Parse(Console.ReadLine());

            Console.Write("Nilai Rata rata : ");
            double nilai = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=== DATA YANG ANDA MASUKAN ===");
            Console.WriteLine($"Nama   : {nama}");
            Console.WriteLine($"Kelas  : {kelas}");
            Console.WriteLine($"Umur   : {umur} tahun");
            Console.WriteLine($"Nilai  : {nilai}");
        }
    }
}
