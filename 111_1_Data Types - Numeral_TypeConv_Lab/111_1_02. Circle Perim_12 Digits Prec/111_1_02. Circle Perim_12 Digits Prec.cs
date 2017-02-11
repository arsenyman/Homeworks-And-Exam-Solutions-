using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_1_02.Circle_Perimeter_12_Digits_Prec
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double p = 2 * Math.PI * r;

            Console.WriteLine($"{p:f12}");
        }
    }
}