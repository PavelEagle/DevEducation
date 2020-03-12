using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    [TestFixture]
    class LinkdeList2Test
    {
        [TestCase(14, new int[] { 32, 55, 21 }, new int[] { 14, 32, 55, 21 })]
        [TestCase(69, new int[] { }, new int[] { 69 })]
        public void AddFirstTest(int val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.AddFirst(val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 18, 10, 4 }, new int[] { 1, 2, 3 }, new int[] { 18, 10, 4, 1, 2, 3 })]
        [TestCase(new int[] { 18, 10, 4 }, new int[] { }, new int[] { 18, 10, 4 })]
        public void AddFirstArrTest(int[] val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.AddFirstArr(val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(55, new int[] { 11, 22, 33, 44 }, new int[] { 11, 22, 33, 44, 55})]
        [TestCase(69, new int[] { }, new int[] { 69 })]
        public void AddLastTest(int val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.AddLast(val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 18, 10, 4 }, new int[] { 3, 3, 3 }, new int[] { 3, 3, 3, 18, 10, 4 })]
        [TestCase(new int[] { }, new int[] { 6 }, new int[] { 6 })]
        public void AddLastArrTest(int[] val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.AddLastArr(val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, new int[] { 9, 68, 44 }, new int[] { 9, 68, 44, 3 })]
        [TestCase(0, 5, new int[] { 4, 6, 7, 5 }, new int[] { 4, 5, 6, 7, 5 })]
        [TestCase(1, 5, new int[] { 3, 4, 5 }, new int[] { 3, 4, 5, 5 })]
        public void AddAtTest(int idx, int val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.AddAt(idx, val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 4 })]
        [TestCase(0, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 4, 5, 2, 3, 4 })]
        [TestCase(3, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 4, 5 })]
        [TestCase(10, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void AddAtArrTest(int idx, int[] val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.AddAtArr(idx, val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 11, 22, 33 }, 3)]
        [TestCase(new int[] { 55 }, 1)]
        [TestCase(new int[] { }, 0)]
        public void GetSizeTest(int[] arr, int expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            int actual = dLL.GetSize();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 69 }, 69)]
        [TestCase(new int[] { }, -1)]
        public void GetFirstTest(int[] arr, int expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            int actual = dLL.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 55, 66, 77 }, 77)]
        public void GetLastTest(int[] arr, int expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            int actual = dLL.GetLast();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(1, new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(7, new int[] { 1, 2, 3, 4 }, -1)]
        public void GetTest(int idx, int[] arr, int expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            int actual = dLL.Get(idx);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, new int[] { 1, 2, 3 }, false)]
        [TestCase(6, new int[] { 4, 5, 6, 6 }, true)]
        [TestCase(1, new int[] { }, false)]
        public void ContainsTest(int val, int[] arr, bool expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            bool actual = dLL.Contains(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 5, 4 })]
        [TestCase(3, 5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 5 })]
        [TestCase(0, 5, new int[] { 1, 2, 3, 4 }, new int[] { 5, 2, 3, 4 })]
        [TestCase(10, 5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void SetTest(int idx, int val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.Set(idx, val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
        public void RemoveFirstTest(int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.RemoveFirst();
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveLastTest(int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.RemoveLast();
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 4 })]
        [TestCase(0, new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        [TestCase(3, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        public void RemoveAtTest(int idx, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.RemoveAt(idx);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, new int[] { 1, 2, 3, 4 }, 3)]
        [TestCase(3, new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(2, new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(1, new int[] { 1, 2, 3, 4 }, 0)]
        [TestCase(10, new int[] { 1, 2, 3, 4 }, -1)]
        public void IndexOfTest(int val, int[] arr, int expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            int actual = dLL.IndexOf(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
        [TestCase(new int[] { 7, 8, 9, 10, 11 }, new int[] { 11, 10, 9, 8, 7 })]
        public void ReverseTest(int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.Reverse();
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, new int[] { 1, 2, 3, 4, 3}, new int[] { 1, 2, 4 })]
        [TestCase(7, new int[] { 7, 8, 9, 10, 11 }, new int[] { 8, 9, 10, 11 })]
        [TestCase(22, new int[] { 22, 13, 22, 7, -7 }, new int[] { 13, 7, -7 })]
        [TestCase(11, new int[] { }, new int[] { })]
        public void RemoveAllTest(int val, int[] arr, int[] expected)
        {
            DoublyLinkedList dLL = new DoublyLinkedList(arr);
            dLL.RemoveAll(val);
            int[] actual = dLL.ToArray();
            Assert.AreEqual(expected, actual);

        }
    }
}
