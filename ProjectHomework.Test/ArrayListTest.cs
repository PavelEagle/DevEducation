﻿using NUnit.Framework;

namespace ProjectHomework
{
    [TestFixture]
    public class ArrayListTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 20, new int[] { 1, 2, 3, 4, 5, 20 })]
        public void AddTest(int [] array, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.Add(val);

            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 99, new int[] { 1, 2, 99, 3, 4, 5 })]
        public void AddTest(int[] array, int indx, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.Add(indx, val);

            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1, 2, 3, 4, 5 }, new int[] {6, 7, 8}, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void AddAllTest(int[] array, int[] vals, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.AddAll(vals);

            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 6, 7, 8 }, new int[] { 1, 2, 6, 7, 8, 3, 4, 5})]
        public void AddAllTest(int [] array, int indx, int[] vals, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.AddAll(indx,vals);
            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 77, new int[] { 1, 2, 3, 77, 5 })]
        public void SetTest(int[] array, int indx, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.Set(indx, val);
            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 4)]
        public void GetTest(int[] array, int indx, int expected)
        {
            ArrayList arrList = new ArrayList(array);

            int actual = arrList.Get(indx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 77, 5 }, 5)]
        public void SizeTest(int[] array, int expected)
        {
            ArrayList arrList = new ArrayList(array);

            int actual = arrList.Size(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 9, false)]
        public void ContainsTest(int[] array, int val, bool expected)
        {
            ArrayList arrList = new ArrayList(array);

            bool actual = arrList.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 8, -1)]
        public void IndexOfTest(int[] array, int val, int expected)
        {
            ArrayList arrList = new ArrayList(array);

            int actual = arrList.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1 })]
        public void SearchTest(int[]array, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);

            int[] actual = arrList.Search(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 3, 5 })]
        public void RemoveIndxTest(int[] array, int indx, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.RemoveIndx(indx);

            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 2, 3, 5 })]
        public void RemoveValTest(int[] array, int val, int[] expected)
        {
            ArrayList arrList = new ArrayList(array);
            arrList.RemoveVal(val);

            int[] actual = arrList.ToArray();
            Assert.AreEqual(expected, actual);
        }

    }
}