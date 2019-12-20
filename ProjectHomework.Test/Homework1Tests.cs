using NUnit.Framework;

namespace ProjectHomework
{
    [TestFixture]
    public class Homework1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1000, 2, 0.1, new double[] { 48.02, 1152.38 })]
        [TestCase(4000, 3, 0.06, new double[] { 124.7, 4489.32 })]
        [TestCase(5000, 5, 0.15, new double[] { 124.3, 7457.89 })]
        public void CalcCreditPaymentsTest(int amount, int years, double percent, double[] expected)
        {
            HomeWork1 hw1 = new HomeWork1();

           double[] actual = hw1.CalcCreditPayments(amount, years, percent);
           Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 5)]
        [TestCase(8, 10, 12.81)]
        [TestCase(54, 76, 93.23)]
        public void CalcHypotenuseTest(int a, int b, double expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            double actual = hw1.CalcHypotenuse(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 2, 2, new int[] {-1, 1, 0})]
        [TestCase(4, 5, 6, 8, new int[] { -3, 2, 2 })]
        [TestCase(-4, -2, 1, 7, new int[] { -9, 5, -26 })]
        public void EquationOfLineTest(int x1, int y1, int x2, int y2, int[] expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            int[] actual = hw1.EquationOfLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -2, -3, new double[] { 3, -1})]
        [TestCase(6, 5, 2, new double[] { 0, 0 })]
        [TestCase(1, 8, -3, new double[] { 0.36, -8.36 })]
        public void CalcQuadraticQquationTest(int a, int b, int c, double[] expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            double[] actual = hw1.CalcQuadraticQquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 5, 63)]
        [TestCase(7, 5, 2, 73)]
        [TestCase(-4, 8, 6, 13)]
        public void CalcExpressionTest(int a, int b, int c, int expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            int actual = hw1.CalcExpression(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(66, 8, new int[] { 8, 2})]
        [TestCase(78, 4, new int[] { 19, 2 })]
        [TestCase(194, 11, new int[] { 17, 7 })]
        public void DivisionTest(int divisor, int divident, int[] expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            int[] actual = hw1.Division(divisor, divident);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-5, 10, 2)]
        [TestCase(-94, -10, 3)]
        [TestCase(54, 11, 1)]
        public void FindCoordinateQuarterTest(int x, int y, int expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            int actual = hw1.FindCoordinateQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 5, 6, false)]
        [TestCase(2, 2, 5, true)]
        [TestCase(10, 10, 15, true)]
        public void PointInsideOutsideCircleTest(int x, int y, int radius, bool expected)
        {
            HomeWork1 hw1 = new HomeWork1();
 
            bool actual = hw1.PointInsideOutsideCircle(x, y, radius);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(9, 362880)]
        [TestCase(5, 120)]
        [TestCase(7, 5040)]
        public void CalcFactorialTest(int factorialEndNumber, int expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            int actual = hw1.CalcFactorial(factorialEndNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(16, 20, 1, new double[] { -42.88 ,- 49.47, - 56.52, - 64.03, - 72 })]
        [TestCase(34, 40, 1, new double[] { -231.88, - 246.75, - 262.08, - 277.87, - 294.12, - 310.83, - 328 })]
        [TestCase(5, 15, 2, new double[] { -0.75, - 4.27, - 9.63, - 16.83, - 25.87, - 36.75 })]
        public void SolutionsOfEquationTest(int min, int max , int step, double[] expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            double[] actual = hw1.SolutionsOfEquation(min, max, step);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1023, new int[] { 6 , 0})]
        [TestCase(777, new int[] { 21, 343 })]
        [TestCase(923, new int[] { 14, 54 })]
        public void MultiplyAndSumDigitsOfNumberTest(int number, int[] expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            int[] actual = hw1.MultiplyAndSumDigitsOfNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(13,true)]
        [TestCase(666, true)]
        [TestCase(573, true)]
        public void ProveTheEquationTest(int number, bool expected)
        {
            HomeWork1 hw1 = new HomeWork1();

            bool actual = hw1.ProveTheEquation(number);
            Assert.AreEqual(expected, actual);
        }
    }
}