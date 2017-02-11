using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_1_03.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal product = 1;

            for (int i = 0; i < n; i++)
            {
                product = product * decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(product);
        }
    }
}