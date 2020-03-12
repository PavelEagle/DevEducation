using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    [TestFixture]
    class LinkdeListTest
    {
        [TestCase(14, new int[] { 32, 55, 21 }, new int[] {  32, 55, 21 , 14})]
        [TestCase(69, new int[] { }, new int[] { 69 })]
        public void Add(int val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.Add(new LinkedList.Node(val));
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 32, 11, 10, 6 }, new int[] { 6, 10, 11, 32 })]
        [TestCase(new int[] { 55, 24, 10, 5, -1 }, new int[] { -1, 5, 10, 24, 55 })]
        public void ReverseTest(int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.Reverse();
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 15, 17, -4 }, 3)]
        [TestCase(new int[] { 99 }, 1)]
        [TestCase(new int[] { }, 0)]
        public void ListSizeTest(int[] arr, int expected)
        {
            LinkedList ll = new LinkedList(arr);
            int actual = ll.ListSize();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 6, new int[] { 20, 16, 1 }, new int[] { 20, 16, 6, 1 })]
        [TestCase(0, 9, new int[] { 19, 10, 11, 5 }, new int[] { 19, 9, 10, 11, 5 })]
        [TestCase(1, 5, new int[] { 1, 2, 3 }, new int[] { 1, 5, 2, 3 })]
        public void AddAtTest(int idx, int val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.AddAtIndex(new LinkedList.Node(val), idx);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, new int[] { 5, 8, 2, 4 }, new int[] { 5, 8, 5, 4 })]
        [TestCase(3, 5, new int[] { 5, 8, 2, 4 }, new int[] { 5, 8, 2, 5 })]
        [TestCase(0, 5, new int[] { 5, 8, 2, 4 }, new int[] { 5, 8, 2, 4 })]
        [TestCase(10, 5, new int[] { 5, 8, 2, 4 }, new int[] { 5, 8, 2, 5 })]
        public void ChangeElementAtIndexTest(int idx, int val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.ChangeElementAtIndex(new LinkedList.Node(val), idx);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 5, 8, 2, 4 }, 2)]
        [TestCase(1, new int[] { 5, 8, 2, 4 }, 8)]
        [TestCase(10, new int[] { 5, 8, 2, 4 }, -1)]
        public void GetTest(int idx, int[] arr, int expected)
        {
            LinkedList ll = new LinkedList(arr);
            int actual = ll.Get(idx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] { 1, 2, 3 }, false)]
        [TestCase(11, new int[] { 6, 11, 11, -6 }, true)]
        [TestCase(4, new int[] { }, false)]
        public void ContainsTest(int val, int[] arr, bool expected)
        {
            LinkedList ll = new LinkedList(arr);
            bool actual = ll.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 1, 2, 3, 4 })]
        public void AddAllTest(int[] val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(val);
            ll.AddAll(arr);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 1, 2, 3, 4 })]
        [TestCase(1, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 1, 2, 3, 4, 5 })]
        [TestCase(10, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 4, 5, 1, 2, 3, 4 })]
        public void AddAllAtIndexTest(int indx, int[] val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(val);
            ll.AddAllAtIndex(indx, arr);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }


        [TestCase(4, new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(3, new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(2, new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(1, new int[] { 1, 2, 3, 4 }, 0)]
        [TestCase(10, new int[] { 1, 2, 3, 4 }, -1)]
        public void IndexOfTest(int val, int[] arr, int expected)
        {
            LinkedList ll = new LinkedList(arr);
            int actual = ll.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 2, 4 }, new int[] { 1, 2 })]
        [TestCase(7, new int[] { 1, 2, 3, 4 }, new int[] { })]

        public void SearchTest(int val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            int[] actual = ll.Search(val);
            Assert.AreEqual(expected, actual);
        }



        [TestCase(3, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 4 })]
        [TestCase(6, new int[] { 1, 2, 3, 4, 7 }, new int[] { 1, 2, 3, 4, 7 })]
        public void RemoveValTest(int val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.RemoveVal(val);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 4 })]
        [TestCase(1, new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 4 })]
        [TestCase(3, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        public void RemoveIndxTest(int idx, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.RemoveIndx(idx);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 8, 5, 11, 5 }, new int[] { 8, 11 })]
        [TestCase(9, new int[] { -1, 5, 9, 11, 15 }, new int[] { -1, 5, 11, 15})]
        [TestCase(11, new int[] { 11, 19, 11, 20, 11 }, new int[] { 19, 20 })]
        [TestCase(11, new int[] { }, new int[] { })]
        public void RemoveAllTest(int val, int[] arr, int[] expected)
        {
            LinkedList ll = new LinkedList(arr);
            ll.RemoveAll(val);
            int[] actual = ll.ToArray();
            Assert.AreEqual(expected, actual);

        }
    }
}
