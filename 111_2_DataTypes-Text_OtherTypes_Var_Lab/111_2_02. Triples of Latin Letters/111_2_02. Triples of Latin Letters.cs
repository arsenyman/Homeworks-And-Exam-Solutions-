﻿using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_2_02.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i1 = 0; i1 < n; i1++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    for (int i3 = 0; i3 < n; i3++)
                    {
                        char firstLetter = (char)('a' + i1);
                        char secondLetter = (char)('a' + i2);
                        char ThirdLetter = (char)('a' + i3);

                        Console.WriteLine("{0}{1}{2}", firstLetter, secondLetter, ThirdLetter);

                    }
                }
            }
        }
    }
}
