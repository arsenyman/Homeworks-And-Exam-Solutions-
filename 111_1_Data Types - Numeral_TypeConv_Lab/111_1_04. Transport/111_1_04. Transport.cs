using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_1_04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // number of people


            int capacity = 4 + 8 + 12; // capacity of  3 vehicles

            int courses = (int)Math.Ceiling((double)n / capacity);


            Console.WriteLine(courses);
        }
    }
}