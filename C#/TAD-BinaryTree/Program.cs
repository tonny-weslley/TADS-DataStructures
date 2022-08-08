using BinaryTree;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

BST bst = new BST(10);
bst.Insert(5);
bst.Insert(15);
bst.Insert(3);
bst.Insert(7);
Console.WriteLine(bst.Size());
Console.WriteLine(bst.Search(3));
Console.WriteLine(bst.Remove(15));