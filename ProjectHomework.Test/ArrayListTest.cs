using NUnit.Framework;

namespace ProjectHomework
{
    [TestFixture]
    public class ArrayListTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(20, new int[] { 1, 2, 3, 4, 5, 20, 0 })]
        public void AddTest(int val, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.Add(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(99, 2, new int[] { 1, 2, 99, 3, 4, 5, 0 })]
        public void AddTest(int indx, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.Add(val, indx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {6, 7, 8}, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0, 0 })]
        public void AddAllTest(int[] vals, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.AddAll(vals);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(77, 3, new int[] { 1, 2, 3, 77, 5 })]
        public void SetTest(int indx, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.Set(val, indx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4)]
        public void GetTest(int indx, int expected)
        {
            ArrayList arrList = new ArrayList();

            int actual = arrList.Get(indx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 77, 5 }, 5)]
        public void SizeTest(int[] array, int expected)
        {
            ArrayList arrList = new ArrayList();

            int actual = arrList.Size(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, true)]
        [TestCase(9, false)]
        public void ContainsTest(int val, bool expected)
        {
            ArrayList arrList = new ArrayList();

            bool actual = arrList.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 3)]
        [TestCase(8, -1)]
        public void IndexOfTest(int val, int expected)
        {
            ArrayList arrList = new ArrayList();

            int actual = arrList.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1 })]
        public void SearchTest(int val, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.Search(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 2, 3, 5, 0 })]
        public void RemoveIndxTest(int indx, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.RemoveIndx(indx);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(4, new int[] { 1, 2, 3, 5, 0 })]
        public void RemoveValTest(int val, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.RemoveVal(val);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, new int[] { 1, 3, 4, 5, 0 })]
        public void RemoveAllTest(int val, int[] expected)
        {
            ArrayList arrList = new ArrayList();

            int[] actual = arrList.RemoveAll(val);
            Assert.AreEqual(expected, actual);
        }

    }
}