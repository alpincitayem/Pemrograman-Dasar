using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AritmatikaPenjumblahan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, appel, hasil = 0;

            Console.WriteLine("mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("appel = ");
            appel = int.Parse(Console.ReadLine());

            // operasi penjumblahan dengan operator +
            hasil = mangga + appel;

            Console.WriteLine($"Hasil mangga + appel = {hasil}");
        }
    }
}