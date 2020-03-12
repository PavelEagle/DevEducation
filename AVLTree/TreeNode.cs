using System;
using System.Collections.Generic;
using System.Text;

namespace AVLTree
{
    public class AVLTreeNode<TNode> : IComparable<TNode> where TNode : IComparable 
    {
        AVLTree<TNode> _tree;

        AVLTreeNode<TNode> _left; // левый потомок
        AVLTreeNode<TNode> _right; // правый потомок

        public AVLTreeNode(TNode value, AVLTreeNode<TNode> parent, AVLTree<TNode> tree)
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }

        public AVLTreeNode<TNode> Left
        {
            get
            {
                return _left;
            }
            internal set
            {
                _left = value;

                if (_left != null)
                {
                    _left.Parent = this;
                }
            }
        }

        public AVLTreeNode<TNode> Right
        {
            get
            {
                return _right;
            }
            internal set
            {
                _right = value;

                if (_right != null)
                {
                    _right.Parent = this;
                }
            }
        }

        public AVLTreeNode<TNode> Parent
        {
            get;
            internal set;
        }


        // значение текущего узла 
        public TNode Value
        {
            get;
            private set;
        }

        // Возвращает: 
        //  1, если значение экзампляра больше переданного значени,
        // -1, если значение экзампляра меньше переданного значени,
        //  0, если значения равны
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        internal void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    LeftRightRotation();
                }

                else
                {
                    LeftRotation();
                }
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    RightLeftRotation();
                }
                else
                {
                    RightRotation();
                }
            }
        }
        private int MaxChildHeight(AVLTreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }

            return 0;
        }

        private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }

        private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeState.LeftHeavy;
                }

                if (RightHeight - LeftHeight > 1)
                {
                    return TreeState.RightHeavy;
                }

                return TreeState.Balanced;
            }
        }


        private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

        enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy,
        }


        private void LeftRotation()
        {

            // сделать правого потомка новым корнем дерева
            AVLTreeNode<TNode> newRoot = Right;
            ReplaceRoot(newRoot);

            // поставить на место правого потомка - левого потомка нового корня   
            Right = newRoot.Left;
            // сделать текущий узел - левым потомком нового корня    
            newRoot.Left = this;
        }

        private void RightRotation()
        {

            // сделать левого потомка новым корнем дерева
            AVLTreeNode<TNode> newRoot = Left;
            ReplaceRoot(newRoot);

            //поставить на место левого потомка - правого потомка нового корня
            Left = newRoot.Right;

            //сделать текущий узел - правым потомком нового корня     
            newRoot.Right = this;
        }

        private void LeftRightRotation()
        {
            Right.RightRotation();
            LeftRotation();
        }

        private void RightLeftRotation()
        {
            Left.LeftRotation();
            RightRotation();
        }


        private void ReplaceRoot(AVLTreeNode<TNode> newRoot)
        {
            if (Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                _tree.Head = newRoot;
            }
            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }
    }
}

