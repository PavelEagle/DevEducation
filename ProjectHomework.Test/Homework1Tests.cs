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

        [Test]
        public void CalcCreditPayments_amount1000years2percent10_result200x1100()
        {
            HomeWork1 hw1 = new HomeWork1();
            int amount = 1000, years = 2;
            double percent = 0.1;

            double[] expected = new double[] { 48.01587301587298, 1152.3809523809514 };
            double[] actual = hw1.CalcCreditPayments(amount, years, percent);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CalcHypotenuse_a3b4_c3x4x5()
        {
            HomeWork1 hw1 = new HomeWork1();
            int a = 3, b = 4;

            double[] expected = new double[] { 3, 4, 5 };
            double[] actual = hw1.CalcHypotenuse(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EquationOfLine_x11y11x22y22_1xminus1x0()
        {
            HomeWork1 hw1 = new HomeWork1();
            int x1 = 1, y1 = 1, x2 = 2, y2 = 2;

            int[] expected = new int[] { -1, 1, 0 };
            int[] actual = hw1.EquationOfLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalcQuadraticQquation_x11y11x22y22_1xminus1x0()
        {
            HomeWork1 hw1 = new HomeWork1();
            int a = 1, b = -2,c = -3;

            double[] expected = new double[] { 3, -1 };
            double[] actual = hw1.CalcQuadraticQquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalcExpression_a3b4xc5_result63()
        {
            HomeWork1 hw1 = new HomeWork1();
            int a = 3, b = 4, c = 5;

            int expected = 63;
            int actual = hw1.CalcExpression(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Division_divisor66divident8_result8x2()
        {
            HomeWork1 hw1 = new HomeWork1();
            int divisor = 66, divident = 8;

            int[] expected = {8, 2};
            int[] actual = hw1.Division(divisor, divident);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindCoordinateQuarter_xminus5y10_quarter2()
        {
            HomeWork1 hw1 = new HomeWork1();
            int x = -5, y = 10;

            int expected = 2;
            int actual = hw1.FindCoordinateQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PointInsideOutsideCircle_x7y5radius6_false()
        {
            HomeWork1 hw1 = new HomeWork1();
            int x = 7, y = 5, radius = 6;

            bool expected = false;
            bool actual = hw1.PointInsideOutsideCircle(x, y, radius);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CalcFactorial_factorialEndNumber9_factorial362880()
        {
            HomeWork1 hw1 = new HomeWork1();
            int factorialEndNumber = 9;

            int expected = 362880;
            int actual = hw1.CalcFactorial(factorialEndNumber);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SolutionsOfEquation_min15max20step1_arrOfEquationSolutions()
        {
            HomeWork1 hw1 = new HomeWork1();
            int min = 16, max = 20, step = 1;

            double[] expected = { -42.88, -49.47, -56.52000000000001, -64.03, -72.00000000000001 };
            double[] actual = hw1.SolutionsOfEquation(min, max, step);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultiplyAndSumDigitsOfNumber_number777_sum21multiply343()
        {
            HomeWork1 hw1 = new HomeWork1();
            int number = 777;

            int[] expected = { 21 , 343};
            int[] actual = hw1.MultiplyAndSumDigitsOfNumber(number);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ProveTheEquation_number13_resulttrue()
        {
            HomeWork1 hw1 = new HomeWork1();
            int number = 13;

            bool expected = true;
            bool actual = hw1.ProveTheEquation(number);
            Assert.AreEqual(expected, actual);
        }
    }
}