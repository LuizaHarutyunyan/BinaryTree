
namespace BinaryTree
{
    internal class Node<T> where T : IComparable
    {
        public Node<T> LeftNode { get; private set; }
        public Node<T> RightNode { get; private set; }
        public T Value { get; private set; }

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

