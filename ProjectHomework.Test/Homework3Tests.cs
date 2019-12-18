using NUnit.Framework;

namespace ProjectHomework
{
    [TestFixture]
    public class Homework3Tests
    {

        [Test]
        public void DigitInNumber_arrOfNumbers11x23x54x68x93x35x79x55digit5_count4()
        {
            HomeWork3 hw3 = new HomeWork3();
            int[] arrOfNumbers = {11, 23, 54, 68, 93, 35, 79, 55};
            int digit = 5;

            int expected = 4;
            int actual = hw3.DigitInNumber(arrOfNumbers, digit);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RectangleDrawing_rectangleLength5rectangleHeight4outerFrameOinnerContentX_arrOfString()
        {
            HomeWork3 hw3 = new HomeWork3();
            int rectangleLength = 5, rectangleHeight = 4;
            string outerFrame = "O", innerContent = "X";

            double expected = {{O,O,O,O,O},{O,X,X,X,O},{O,X,X,X,O},{O,O,O,O,O}};
            double actual = hw3.RectangleDrawing(rectangleLength, rectangleHeight, outerFrame, innerContent);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountOfDividers_minValue15maxValue20countOfDividers5_countOfNumbers3()
        {
            HomeWork3 hw3 = new HomeWork3();
            int minValue = 15, maxValue = 20, countOfDividers = 5;

            int expected = 3;
            int actual = hw3.CountOfDividers(minValue, maxValue, countOfDividers);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void CountOfDividers_minValue15maxValue20countOfDividers5_countOfNumbers3()
        {
            HomeWork3 hw3 = new HomeWork3();
            int minValue = 15, maxValue = 20, countOfDividers = 5;

            int expected = 3;
            int actual = hw3.CountOfDividers(minValue, maxValue, countOfDividers);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void DiagonalElementsChange_matrix_result()
        {
            HomeWork3 hw3 = new HomeWork3();
            int[,] matrix = {{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5},{1,2,3,4,5}};

            int[,] expected = {{5,2,3,4,1},{1,4,3,2,5},{1,2,3,4,5},{1,4,3,2,5},{5,2,3,4,1}};
            int actual = hw3.DiagonalElementsChange(matrix);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GreaterNumberInCentralCell_matrix_result()
        {
            HomeWork3 hw3 = new HomeWork3();
            int[,] matrix = {{6,2,5,3,1},{7,8,1,-4,0},{1,-2,9,3,-2},{-4,6,5,-2,1},{1,3,2,-5,-8}};

            int[] expected = {8,9,6};
            int[] actual = hw3.GreaterNumberInCentralCell(matrix);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TicTacToeCheck_arr_markersCount3()
        {
            Methods mtd = new Methods();
            int[,] matrix = {{X,+,+,+,+},{+,X,O,O,+},{+,+,X,+,+},{+,+,+,+,+},{+,+,+,+,+}};

            int expected = 3;
            int actual = mtd.TicTacToeCheck(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}
