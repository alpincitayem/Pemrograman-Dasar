using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPembandingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga, apel = 0;

            Console.Write("jumblah mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("jumblah apel = ");
            apel = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil pertandingan: ");
            Console.WriteLine($"mangga > apel : {mangga > apel}");
            Console.WriteLine($"mangga >= apel : {mangga >= apel}");
            Console.WriteLine($"mangga < apel : {mangga < apel}");
            Console.WriteLine($"mangga<= apel : {mangga <= apel}");
            Console.WriteLine($"mangga == apel : {mangga == apel}");
            Console.WriteLine($"mangga != apel : {mangga != apel}");

        }
    }
}
