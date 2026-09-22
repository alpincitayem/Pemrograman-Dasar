using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaPembagian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, orang, hasil = 0;

            Console.WriteLine("jumblah mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.WriteLine("jumblah orang = ");
            orang = int.Parse(Console.ReadLine());

            hasil = mangga % orang;

            Console.WriteLine($"Hasil mangga % orang = {hasil}");
        }
    }
}
