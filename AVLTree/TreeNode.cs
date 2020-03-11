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
    }
}
