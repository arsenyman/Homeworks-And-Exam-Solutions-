using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_2_01.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // A number is special when its sum of digits is 5, 7 or 11

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int currentDigit = num;

                while (currentDigit > 0)
                {
                    sumOfDigits = sumOfDigits + currentDigit % 10;
                    currentDigit = currentDigit / 10;
                }

                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine("{0} -> {1}", num, special);
            }

        }
    }
}
