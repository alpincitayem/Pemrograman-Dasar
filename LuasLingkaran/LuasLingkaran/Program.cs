using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuasLingkaran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat konstanta

            const float phi = 3.14f;

            Console.WriteLine("== PEOGRAM LUAS LINGKARAN ==");
            Console.WriteLine("Input jari jari: ");
            int r = int.Parse(Console.ReadLine());

            var luas = phi * r * r;

            Console.WriteLine($"Luas Lingkaran = {luas}");
        }
    }
}
