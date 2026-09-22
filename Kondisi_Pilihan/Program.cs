using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondisi_Pilihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nama : M Alfil David Rizal Jiban
            // Kelas : X PPLG 2
            // Kondisi dengan satu pilihan
            // Jika nilai >= 75 maka lulus
            // Variabel nilai int

            int nilai = 95;
            if (nilai >= 95)
            {
                // pilihan 1
                Console.WriteLine("MASHAALLAH");
            }
            else if (nilai >= 75)
            {
                // pilihan 2
                Console.WriteLine("SELAMAT ANDA LULUS");
            }
            else
            {
                Console.WriteLine("SUBHANNALLAH");
            }

            }
        }
}
