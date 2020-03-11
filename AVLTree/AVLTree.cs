using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace AVLTree
{
    public class AVLTree<T> : IEnumerable<T> where T : IComparable
    {
        public AVLTreeNode<T> Head
        {
            get;
            internal set;
        }

        public int Count
        {
            get;
            private set;
        }

        public void Add(T value)
        {

            // Создание корня дерева
            if (Head == null)
            {
                Head = new AVLTreeNode<T>(value, null, this);
            }

            // Найти место для добавления нового изла и добавить его
            else
            {
                AddTo(Head, value);
            }

            Count++;
        }

        private void AddTo(AVLTreeNode<T> node, T value)
        {
            // Добавление нового значения в дерево. Значение добавляемого узла меньше, чем значение текущего узла
            if (value.CompareTo(node.Value) < 0)
            {
                //Создание левого узла, если его нет

                if (node.Left == null)
                {
                    node.Left = new AVLTreeNode<T>(value, node, this);
                }

                else
                {
                    // Переходим к следующему левому узлу
                    AddTo(node.Left, value);
                }
            }

            // Добавление нового значения в дерево. Значение добавляемого узла больше или равно текущему значению узла
            else
            {
                // Создание правго узла, если его нет
                if (node.Right == null)
                {
                    node.Right = new AVLTreeNode<T>(value, node, this);
                }
                else
                {
                    // Переходим к следующему правому узлу
                    AddTo(node.Right, value);
                }
            }
        }

        public IEnumerator<T> InOrderTraversal()
        {
            if (Head != null)
            {
                Stack<AVLTreeNode<T>> stack = new Stack<AVLTreeNode<T>>();
                AVLTreeNode<T> current = Head;

                bool goLeftNext = true;

                stack.Push(current);

                while (stack.Count > 0 )
                {
                    if (goLeftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }

                    yield return current.Value;

                    if (current.Right != null)
                    {
                        current = current.Right;

                        // Перемещается вправо, после чего опять идем влево

                        goLeftNext = true;
                    }
                    else
                    {
                        // Если перейти вправо нельзя - извлекаем родительский узел
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
