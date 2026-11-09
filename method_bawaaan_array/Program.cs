using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_bawaaan_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 42, 7, 19, 3, 25 };

            Array.Sort(angka);
            Console.WriteLine("Terurut : " + string.Join(", ", angka));

            Array.Reverse(angka);
            Console.WriteLine("Dibalik : " + string.Join(", ", angka));

            Console.WriteLine("Indeks 25 : " + Array.IndexOf(angka, 25));
            Console.WriteLine("Jumblah   : " + angka.Sum());
            Console.WriteLine("Terbesar  : " + angka.Max());
        }
    }
}
