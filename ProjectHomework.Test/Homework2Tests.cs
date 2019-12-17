using NUnit.Framework;

namespace ProjectHomework
{
    [TestFixture]
    public class Homework2Tests
    {

        [Test]
        public void NumberReverse_number345_result543()
        {
            HomeWork2 hw2 = new HomeWork2();
            int number = 345;

            int expected = 543;
            int actual = hw2.NumberReverse(number);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Calculator_number169number284operation153_result153()
        {
            HomeWork2 hw2 = new HomeWork2();
            int number1 = 69, number2 = 84;
            string operation = "+";

            double expected = 153;
            double actual = hw2.Calculator(number1, number2, operation);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrecentOfPositiveNumbers_countOfNumber1000_result45_55()
        {
            HomeWork2 hw2 = new HomeWork2();
            int countOfNumber = 1000;

            double expected1 = 55;
            double expected2 = 45;
            double actual = hw2.PrecentOfPositiveNumbers(countOfNumber);
            Assert.LessOrEqual(expected2, actual);
            Assert.GreaterOrEqual(expected1, actual);
        }

        [Test]
        public void FibonacciNumbers_lastFibNumber8_result1х2х3х5х8x13()
        {
            HomeWork2 hw2 = new HomeWork2();
            int lastFibNumber = 6;

            int[] expected = { 1, 2, 3, 5, 8, 13 };
            int[] actual = hw2.FibonacciNumbers(lastFibNumber);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MaxElemInArr_arrOfNumbers1x7xmin10x21x5_max21()
        {
            HomeWork2 hw2 = new HomeWork2();
            int[] arrOfNumbers = { 1, 7, -10, 21, 5 };

            int expected = 21;
            int actual = hw2.MaxElemInArr(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ArrReverse_arrOfNumbers6x3x1x5x11_arrOfNumbers11x5x1x3x6()
        {
            HomeWork2 hw2 = new HomeWork2();
            int[] arrOfNumbers = { 6, 3, 1, 5, 11 };

            int[] expected = { 11, 5, 1, 3, 6 };
            int[] actual = hw2.ArrReverse(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void HalfArrReverse_arrOfNumbers2x8x14x3x6_arrOfNumbers3x6x14x2x8()
        {
            HomeWork2 hw2 = new HomeWork2();
            int[] arrOfNumbers = { 2, 8, 14, 3, 6 };

            int[] expected = { 3, 6, 14, 2, 8 };
            int[] actual = hw2.HalfArrReverse(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NumbersLessAverage_arrOfNumbers6x7x7x3x2x5_result2x3()
        {
            HomeWork2 hw2 = new HomeWork2();
            int[] arrOfNumbers = { 6, 7, 7, 3, 2, 5 };

            int[] expected = { 3, 2 };
            int[] actual = hw2.NumbersLessAverage(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SumBetweenMinMax_arrOfNumbers7x1x2x6xmin4x3_sum9()
        {
            HomeWork2 hw2 = new HomeWork2();
            int[] arrOfNumbers = { 7, 1, 2, 6, -4, 3 };

            int expected = 9;
            int actual = hw2.SumBetweenMinMax(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }
    }
}