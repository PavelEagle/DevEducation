using NUnit.Framework;

namespace ProjectHomework
{
    [TestFixture]
    public class Homework2Tests
    {

        [TestCase(345,543)]
        [TestCase(9534, 4359)]
        [TestCase(945684, 486549)]

        public void NumberReverseTest(int number, int expected)
        {
            HomeWork2 hw2 = new HomeWork2();

            int actual = hw2.NumberReverse(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(66,24,"+", 90)]
        [TestCase(12, 14, "*", 168)]
        [TestCase(96, 30, "/", 3.2)]
        public void CalculatorTest(int number1, int number2, string operation, double expected)
        {
            HomeWork2 hw2 = new HomeWork2();

            double actual = hw2.Calculator(number1, number2, operation);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, new int[] { 1, 2, 3, 5, 8, 13 })]
        [TestCase(4, new int[] { 1, 2, 3, 5 })]
        [TestCase(15, new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 })]
        public void FibonacciNumbersTest(int lastFibNumber, int[] expected)
        {
            HomeWork2 hw2 = new HomeWork2();

            int[] actual = hw2.FibonacciNumbers(lastFibNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 15, 24, -10, 30, -5, -6 }, 30)]
        [TestCase(new int[] { 66, -10, 84, 11, -65, 99 }, 99)]
        [TestCase(new int[] { 77, 54, -36, 19, 10, -78 }, 77)]
        public void MaxElemInArrTest(int [] arrOfNumbers, int expected)
        {
            HomeWork2 hw2 = new HomeWork2();

            int actual = hw2.MaxElemInArr(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 6, 3, 1, 5, 11 }, new int[] { 11, 5, 1, 3, 6 })]
        [TestCase(new int[] { 21, -4, 15, 10, -2 }, new int[] { -2, 10, 15, -4, 21 })]
        [TestCase(new int[] { 33, -49, 71, -42, 39 }, new int[] { 39, -42, 71, -49, 33 })]
        public void ArrReverseTest(int[] arrOfNumbers, int[] expected)
        {
            HomeWork2 hw2 = new HomeWork2();

            int[] actual = hw2.ArrReverse(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 8, 14, 3, 6 }, new int[] { 3, 6, 14, 2, 8 })]
        [TestCase(new int[] { 16, 9, 1, -4, -2, 5 }, new int[] { -4, -2, 5, 16, 9, 1 })]
        [TestCase(new int[] { 54, 14, -22, 18, 78, 93, 44 }, new int[] { 78, 93, 44, 18, 54, 14, -22 })]
        public void HalfArrReverseTest(int[] arrOfNumbers, int[] expected)
        {
            HomeWork2 hw2 = new HomeWork2();
 
            int[] actual = hw2.HalfArrReverse(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 6, 7, 7, 3, 2, 5 }, new int[] { 3, 2 })]
        [TestCase(new int[] { 11, 18, 4, 9, 12, 6 }, new int[] { 4, 9, 6 })]
        [TestCase(new int[] { 6, 7, 7, 3, 2, 5 }, new int[] { 3, 2 })]
        public void NumbersLessAverageTest(int[] arrOfNumbers, int[] expected)
        {
            HomeWork2 hw2 = new HomeWork2();

            int[] actual = hw2.NumbersLessAverage(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 7, 1, 2, 6, -4, 3 }, 9)]
        [TestCase(new int[] { 11, -4, 18, 25, -10, 16 }, 0)]
        [TestCase(new int[] { -14, 16, 3, 0, 21, 9 }, 19)]
        public void SumBetweenMinMaxTest(int[] arrOfNumbers, int expected)
        {
            HomeWork2 hw2 = new HomeWork2();
 
            int actual = hw2.SumBetweenMinMax(arrOfNumbers);
            Assert.AreEqual(expected, actual);
        }
    }
}