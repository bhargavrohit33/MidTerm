﻿using MIdTermTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermTesting
{
    [TestFixture]
    public class TestClass
    {
        [Test]


        public void CalculatePPI_Input2000and1500and13dot4_Output220dot53and0dot1152and3396()
        {
            //Arrange 
            double screenWidth = 2000;
            double screenHeight = 1500;
            double diagonalSize = 13.4;

            string expected = "\n\nPPI: " + 186.57 + " \nDot Pitch: " + 0.1361 + " \nDiagonal Size in Pixels: " + 2500;

            //Act
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
            string actual = "\n\nPPI: " + myDictionary["PPI"] + " \nDot Pitch: " + myDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + myDictionary["diagonalSizeinPixels"];

            //Assert 
            Assert.AreEqual(expected, actual);
        }
         [Test]


        public void CalculatePPI_Input2000and1500and13dot4_Output220dot53and0dot1152and3396()
        {
            //Arrange 
            double screenWidth = 2000;
            double screenHeight = 1500;
            double diagonalSize = 13.4;

            string expected = "\n\nPPI: " + 186.57 + " \nDot Pitch: " + 0.1361 + " \nDiagonal Size in Pixels: " + 2500;

            //Act
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
            string actual = "\n\nPPI: " + myDictionary["PPI"] + " \nDot Pitch: " + myDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + myDictionary["diagonalSizeinPixels"];

            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}