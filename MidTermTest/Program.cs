using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdTermTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            String input;
            double screenWidth;
            double screenHeight;
            double diagonalSize;
            bool Flag = true;

            do
            {
                Console.WriteLine("1)Enter Screen Dimensions");
                Console.WriteLine("\n2)Exit");
                input = Console.ReadLine();
                if (input == "1")
                {
                    try
                    {
                        Console.WriteLine("\nEnter Screen Width: ");
                        screenWidth = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Screen Height: ");
                        screenHeight = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter Diagonal Size: ");
                        diagonalSize = double.Parse(Console.ReadLine());
                        Dictionary<string, double> Dictionary1 = new Dictionary<string, double>();
                        Dictionary1 = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
                        Console.WriteLine("\nPPI: " + Dictionary1["PPI"] + " \n Dot Pitch: " + Dictionary1["dotPitch"] + " \nDiagonal Size (Pixels): " + Dictionary1["diagonalSizeinPixels"]);
                    }
                    catch (Exception e)
                    {
                        Console.Write("\n" + e.ToString() + "\n");
                    }
                }
                else if (input == "2")
                {
                    Flag = false;
                }

            } while (Flag);
        }
    }
}
