using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIdTermTest
{
    public static class PixelCalc
    {
        public static Dictionary<String, Double> Calculate(Double screenWidth, Double screenHeight, double diagonalSize)
        {
            double ppi = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2)) / diagonalSize;
            double diagonalSizeInPixels = Math.Sqrt(Math.Pow(screenWidth, 2) + Math.Pow(screenHeight, 2));
            double dotPitch = diagonalSize / diagonalSizeInPixels;
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary.Add("PPI", Math.Round(ppi, 2));
            myDictionary.Add("diagonalSizeinPixels", Math.Round(diagonalSizeInPixels, 0));
            myDictionary.Add("dotPitch", Math.Round(dotPitch * 25.4, 4));
            return myDictionary;
        }
    }
}
