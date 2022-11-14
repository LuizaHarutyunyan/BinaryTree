using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BinaryTree
{


    internal class Tree<T> : IEnumerable<T> where T : IComparable
    {
        private Node<T> root { get; set; }
        private bool isReversedReading;
        private List<T> ts = new List<T>();


        public Tree(bool isReversedReading)
        {
            this.isReversedReading = isReversedReading;
        }

        public void Add(T item)
        {
            if (root == null)
            {
                root = new Node<T>(item);
            }
            else
            {
                root.Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.CreateList(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.CreateList(root).GetEnumerator();
        }

        private List<T> CreateList(Node<T> item)
        {
            if (item != null)
            {
                if (isReversedReading)
                {
                    CreateList(item.RightNode);
                    this.ts.Add(item.Value);
                    CreateList(item.LeftNode);
                }
                else
                {
                    CreateList(item.LeftNode);
                    this.ts.Add(item.Value);
                    CreateList(item.RightNode);
                }
            }
            return this.ts;
        }
    }
}
