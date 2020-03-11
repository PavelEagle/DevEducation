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

        #region Add
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
        #endregion

        #region Contains
        public bool Contains (T value)
        {
            return Find(value) != null;
        }

        private AVLTreeNode<T> Find (T value)
        {
            AVLTreeNode<T> current = Head; // помещаем текущий узел в корень дерева

            while (current != null)
            {
                int result = current.CompareTo(value); // сравниваем значения текущего элемента с искомым значением

                if (result > 0)
                {
                    // Если значение меньше текущего - переход влево
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // Если значение больше текущего - переход вправо
                    current = current.Right;
                }
                else
                {
                    // Элемент найден
                    break;
                }
            }
            return current;
        }

        #endregion

        #region Remove
        
        public bool Remove(T value)
        {
            AVLTreeNode<T> current;
            current = Find(value); // ищем удаляемый узел

            if (current == null)
            {
                return false;
            }

            AVLTreeNode<T> treeToBalance = current.Parent; // проверка баланса дерева
            Count--;

            // если удаляемый узел не имеет правого потомка

            if (current.Right == null)
            {
                Head = current.Left; // корень - левый потомок

                if (Head != null)
                {
                    Head.Parent = null; // для нового корня удаляем ссылку на родителя
                }
                else // удаляемый узел не вляется корнем
                {
                    int result = current.Parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        // если значение родительского узла больше удаляемого, 
                        //делаем левого потомка текущего элемента левым потомком родителя
                        current.Parent.Left = current.Left;
                    }
                    else if (result < 0)
                    {
                        // если значение родительского узла меньше удаляемого, 
                        //делаем левого потомка текущего элемента правым потомком родителя
                        current.Parent.Right = current.Left;
                    }
                }
            }

            // если правый потомок удаляемого узла имеет правого потомка, но не имеет левого

            else if (current.Right.Left == null) // если у правого потомка нет левого потомка
            {
                current.Right.Left = current.Left;

                if (current.Parent != null) // текущий элемент является корнем
                {
                    Head.Parent = current.Right;

                    if (Head != null)
                    {
                        Head.Parent = null;
                    }
                }
                else // удаляемый узел не вляется корнем
                {
                    int result = current.Parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        // если значение родительского узла больше удаляемого, 
                        //делаем правого потомка текущего элемента левым потомком родителя
                        current.Parent.Left = current.Right;
                    }
                    else if (result < 0)
                    {
                        // если значение родительского узла меньше удаляемого, 
                        //делаем правого потомка текущего элемента правым потомком родителя
                        current.Parent.Right = current.Right;
                    }
                } 
            }

            // Если правый потомок удаляемого узла имеет левого потомка, 
            // то требуется поместить на место удаляемого узла крайнего левого потомка его правого потомка
            else
            {
                // нахождение крайнего левого узла для правого потомка текущего элемента
                AVLTreeNode<T> leftmost = current.Right.Left;

                while (leftmost.Left != null)
                {
                    leftmost = leftmost.Left;
                }

                // родительское левое поддерево становится родительским крайним правым поддеревом 
                leftmost.Parent.Left = leftmost.Right;

                // присвоить крайний левый и крайний правый потомок удаляемого узла, его правому и левому потомку соответствено

                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (current.Parent != null) // текущий элемент является корнем
                {
                    Head = leftmost;

                    if (Head != null)
                    {
                        Head.Parent = null;
                    }
                }
                else 
                {
                    int result = current.Parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        // если значение родительского узла больше удаляемого, 
                        //делаем левого потомка текущего элемента левым потомком родителя
                        current.Parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        // если значение родительского узла меньше удаляемого, 
                        //делаем правого потомка текущего элемента правым потомком родителя
                        current.Parent.Right = leftmost;
                    }
                }
            }

            if (treeToBalance != null)
            {
                //treeToBalance.Balance();
            }

            else
            {
                if (Head != null)
                {
                    //Head.Balance();
                }
            }
            return true;
        }
        #endregion
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
