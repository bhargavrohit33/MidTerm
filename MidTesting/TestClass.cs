using MIdTermTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTesting
{
    [TestFixture]
    public class TestClass
    {
        [Test]

        public void CalculatePPI_Input2000and1500and13dot4_Output186dot57and0dot1361and2500()
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

        public void CalculatePPI_Input10and20and30_Output0dot75and34dot0777and22()
        {
            //Arrange 
            double screenWidth = 10;
            double screenHeight = 20;
            double diagonalSize = 30;

            string expected = "\n\nPPI: " + 0.75 + " \nDot Pitch: " + 34.0777 + " \nDiagonal Size in Pixels: " + 22;

            //Act
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
            string actual = "\n\nPPI: " + myDictionary["PPI"] + " \nDot Pitch: " + myDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + myDictionary["diagonalSizeinPixels"];

            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void CalculatePPI_Input10dot3and30dot50and40dot6_Output0dot79and32dot0338and32()
        {
            //Arrange 
            double screenWidth = 10.3;
            double screenHeight = 30.50;
            double diagonalSize = 40.6;

            string expected = "\n\nPPI: " + 0.79 + " \nDot Pitch: " + 32.0338 + " \nDiagonal Size in Pixels: " + 32;

            //Act
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
            string actual = "\n\nPPI: " + myDictionary["PPI"] + " \nDot Pitch: " + myDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + myDictionary["diagonalSizeinPixels"];

            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void CalculatePPI_Input200and300and400_Output0dot9and28dot1788and361()
        {
            //Arrange 
            double screenWidth = 200;
            double screenHeight = 300;
            double diagonalSize = 400;

            string expected = "\n\nPPI: " + 0.9 + " \nDot Pitch: " + 28.1788 + " \nDiagonal Size in Pixels: " + 361;

            //Act
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
            string actual = "\n\nPPI: " + myDictionary["PPI"] + " \nDot Pitch: " + myDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + myDictionary["diagonalSizeinPixels"];

            //Assert 
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CalculatePPI_Input1000and300and400_Output0dot79and32dot1287and3162()
        {
            //Arrange 
            double screenWidth = 1000;
            double screenHeight = 3000;
            double diagonalSize = 4000;

            string expected = "\n\nPPI: " + 0.79 + " \nDot Pitch: " + 32.1287 + " \nDiagonal Size in Pixels: " + 3162;

            //Act
            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            myDictionary = PixelCalc.Calculate(screenWidth, screenHeight, diagonalSize);
            string actual = "\n\nPPI: " + myDictionary["PPI"] + " \nDot Pitch: " + myDictionary["dotPitch"] + " \nDiagonal Size in Pixels: " + myDictionary["diagonalSizeinPixels"];

            //Assert 
            Assert.AreEqual(expected, actual);
        }

    }
}
