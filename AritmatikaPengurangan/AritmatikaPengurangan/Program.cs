using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmatikaPengurangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel, hasil = 0;

            Console.Write("mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("appel = ");
            apel = int.Parse(Console.ReadLine());

            hasil = mangga - apel;

            Console.WriteLine($"Hasil mangga - appel = {hasil}");
        }
    }
}
