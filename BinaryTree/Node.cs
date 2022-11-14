using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node<T> where T : IComparable
    {
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }
        public T Value { get; set; }

        public Node()
        {

        }
        public Node(T Value)
        {
            this.Value = Value;
        }

        public void Add(T item)
        {
            if (item.CompareTo(Value) > 0)
            {
                if (RightNode == null)
                {
                    RightNode = new Node<T>(item);
                }
                else
                {
                    RightNode.Add(item);
                }
            }
            if (item.CompareTo(Value) < 0)
            {
                if (LeftNode == null)
                {
                    LeftNode = new Node<T>(item);
                }
                else
                {
                    LeftNode.Add(item);
                }
            }
            if (item.CompareTo(Value) == 0)
            {
                throw new ArgumentException("Values can not be same");
            }
        }
    }
}

