using BinaryTree;

Tree<int> tree = new Tree<int>(true);
tree.Add(20);
tree.Add(10);
tree.Add(9);
tree.Add(4000);
tree.Add(-2022);
tree.Add(0);


IEnumerator<int> enumerator = tree.GetEnumerator();


foreach (var item in tree)
{
    Console.WriteLine(item);
}