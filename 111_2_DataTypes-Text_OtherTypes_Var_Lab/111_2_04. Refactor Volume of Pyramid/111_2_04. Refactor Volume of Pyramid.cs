using System; // arseny
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111_2_04.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original sample code:

            //double dul, sh, V = 0;

            //Console.Write("Length: ");

            //dul = double.Parse(Console.ReadLine());
            //Console.Write("Width: ");

            //sh = double.Parse(Console.ReadLine());
            //Console.Write("Heigth ");

            //V = double.Parse(Console.ReadLine());
            //V = (dul + sh + V) / 3;

            //Console.WriteLine("Pyramid Volume: {0:F2}", V);


            // Restructured code:
            double length = 0;
            double width = 0;
            double heigth = 0;

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heigth = double.Parse(Console.ReadLine());

            double baseArea = length * width;

            double volume = heigth * baseArea / 3; // Formula for the volume of a pyramid; and alternative record: volume = (length * width * heigth) / 3
                    

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
