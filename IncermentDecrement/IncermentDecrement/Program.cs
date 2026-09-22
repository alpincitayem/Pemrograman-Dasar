using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncermentDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mangga = 3;
            int apel = 4;

            Console.WriteLine($"mangga = {mangga}");
            Console.WriteLine($"apel = {apel}");

            // incerment
            mangga++;
            ++apel;

            Console.WriteLine($"mangga+1 = {mangga}");
            Console.WriteLine($"apel+1 = {apel}");

            // decrement
            mangga--;
            --apel;

            Console.WriteLine("mangga-1 = {mangga}");
            Console.WriteLine($"apel-1 = {apel}");

        }
    }
}
