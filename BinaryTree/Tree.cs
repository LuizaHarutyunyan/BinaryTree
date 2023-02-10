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
        private bool _isReversedReading;

        public Tree(bool isReversedReading)
        {
            this._isReversedReading = isReversedReading;
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
            List<T> listOfItems = new List<T>();
            return this.CreateList(root, listOfItems).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            List<T> listOfItems = new List<T>();
            return this.CreateList(root, listOfItems).GetEnumerator();
        }

        private List<T> CreateList(Node<T> item, List<T> listOfItems)
        {
            if (item != null)
            {
                if (_isReversedReading)
                {
                    CreateList(item.RightNode, listOfItems);
                    listOfItems.Add(item.Value);
                    CreateList(item.LeftNode, listOfItems);
                }
                else
                {
                    CreateList(item.LeftNode, listOfItems);
                    listOfItems.Add(item.Value);
                    CreateList(item.RightNode, listOfItems);
                }
            }
            return listOfItems;
        }
    }
}
