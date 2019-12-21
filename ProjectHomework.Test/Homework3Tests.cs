using NUnit.Framework;
using System.Collections.Generic;

namespace ProjectHomework
{
    [TestFixture]
    public class Homework3Tests
    {

        [TestCase(new int[] { 11, 23, 54, 68, 93, 35, 79, 55 }, 5, 4)]
        [TestCase(new int[] { 65, 22, 89, 13, 83, 74, 27, 90 }, 4, 1)]
        [TestCase(new int[] { 35, 96, 50, 13, 29, 38, 91, 44 }, 9, 3)]
        public void DigitInNumberTest(int[] arrOfNumbers, int digit, int expected)
        {
            HomeWork3 hw3 = new HomeWork3();

            int actual = hw3.DigitInNumber(arrOfNumbers, digit);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<TestCaseData> RectangleDrawingTestList()
        {
            yield return new TestCaseData(5, 4, "O", "X",
                new string[,] { { "O", "O", "O", "O", "O" }, { "O", "X", "X", "X", "O" },
                             { "O", "X", "X", "X", "O" }, { "O", "O", "O", "O", "O" } });
            yield return new TestCaseData(4, 4, "*", "+",
                new string[,] { { "*", "*", "*", "*" }, { "*", "+", "+", "*" },
                             { "*", "+", "+", "*" }, { "*", "*", "*", "*" } });
            yield return new TestCaseData(3, 3, "K", "E",
                new string[,] { { "K", "K", "K" }, { "K", "E", "K"},
                             { "K", "K", "K" },  });
        }

        [TestCaseSource("RectangleDrawingTestList")]
        public void RectangleDrawingTest(int rectangleLength, int rectangleHeight, string outerFrame,
            string innerContent, string[,] expected)
        {
            HomeWork3 hw3 = new HomeWork3();

            string[,] actual = hw3.RectangleDrawing(rectangleLength, rectangleHeight, outerFrame, innerContent);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 20, 5, 3)]
        [TestCase(22, 40, 5, 6)]
        [TestCase(7, 77, 9, 4)]
        public void CountOfDividersTest(int minValue, int maxValue, int countOfDividers, int expected)
        {
            HomeWork3 hw3 = new HomeWork3();

            int actual = hw3.CountOfDividers(minValue, maxValue, countOfDividers);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<TestCaseData> DiagonalElementsChangeTestList()
        {
            yield return new TestCaseData(new int[,] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 },
                                   { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } },
                        new int[,] { { 5, 2, 3, 4, 1 }, { 1, 4, 3, 2, 5 }, { 1, 2, 3, 4, 5 },
                                   { 1, 4, 3, 2, 5 }, { 5, 2, 3, 4, 1 } });
            yield return new TestCaseData(new int[,] { { 6, 7, 8, 9 }, { 6, 7, 8, 9 },
                                   { 6, 7, 8, 9 }, { 6, 7, 8, 9 } },
                        new int[,] { { 9, 7, 8, 6 }, { 6, 8, 7, 9 }, { 6, 8, 7, 9 },
                                   { 9, 7, 8, 6 } });
            yield return new TestCaseData(new int[,] { { 1, 11, 111 }, { 1, 11, 111 }, { 1, 11, 111 } },
                                        new int[,] { { 111, 11, 1 }, { 1, 11, 111 }, { 111, 11, 1 } });
        }

        [TestCaseSource("DiagonalElementsChangeTestList")]
        public void DiagonalElementsChangeTest(int[,] matrix, int[,] expected)
        {
            HomeWork3 hw3 = new HomeWork3();

            int[,] actual = hw3.DiagonalElementsChange(matrix);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<TestCaseData> GreaterNumberInCentralCellTestList()
        {
            yield return new TestCaseData(new int[,] { { 6, 2, 5, 3, 1 }, { 7, 8, 1, -4, 0 },
                        { 1, -2, 9, 3, -2 }, { -4, 6, 5, -2, 1 }, { 1, 3, 2, -5, -8 } },
                        new int[] { 8, 9, 6 });
        }

        [TestCaseSource("GreaterNumberInCentralCellTestList")]
        public void GreaterNumberInCentralCellTest(int[,] matrix, int[] expected)
        {
            HomeWork3 hw3 = new HomeWork3();

            int[] actual = hw3.GreaterNumberInCentralCell(matrix);
            Assert.AreEqual(expected, actual);
        }

        public static IEnumerable<TestCaseData> TicTacToeCheckTestList()
        {
            yield return new TestCaseData(new string[,] {{"X","+", "+", "+", "+" },{ "+", "X", "O","O", "+" },
                { "+", "+", "X", "+", "+" }, { "+", "+", "+", "+", "+" }, { "+", "+", "+", "+", "+" } },
                0, 0, "X", 3);
            yield return new TestCaseData(new string[,] {{"X","X", "O", "X" },{ "+", "+","O", "+" },
                { "+", "+", "O", "+"}, { "+", "+", "+", "+"} },
                 2, 2, "O", 3);
            yield return new TestCaseData(new string[,] {{"+","+", "+", "+", "+" },{ "+", "+", "+","+", "+" },
                { "+", "+", "X", "+", "+" }, { "+", "O", "O", "X", "+" }, { "+", "+", "+", "+", "X" } },
                 3, 3, "X", 3);
        }

        [TestCaseSource("TicTacToeCheckTestList")]
        public void TicTacToeCheckTest(string[,] matrix, int row, int column, string currentMarker, int expected)
        {
            Methods mtd = new Methods();

            int actual = mtd.TicTacToeCheck(matrix, currentMarker, row, column);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(15, "XV")]
        [TestCase(33, "XXXIII")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(111, "CXI")]
        [TestCase(3876, "MMMDCCCLXXVI")]
        public void GetRomanNumberTest(int arabicNumber, string romanNumber)
        {
            HomeWork3 hw3 = new HomeWork3();
            string actual = hw3.GetRomanNumber(arabicNumber);
            Assert.AreEqual(romanNumber, actual);
        }
    }
}
