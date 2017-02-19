using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_2_05.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original sample code

            //int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0; int takova = 0; bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++)
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine($"{takova} -> {toe}");
            //    obshto = 0;
            //    ch = takova;
            //}


            // Restructured code:
            int n = int.Parse(Console.ReadLine()); //  A number is special when its sum of digits is 5, 7 or 11
            
               

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
