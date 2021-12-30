using System;

namespace BSTSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 4;

            BST.Insert(rootNode, 2);
            BST.Insert(rootNode, 3);
            BST.Insert(rootNode, 5);
            BST.Insert(rootNode, 6);
            BST.Insert(rootNode, 4);

            Console.WriteLine(BST.Search(rootNode, 2)); //true
            Console.WriteLine(BST.Search(rootNode, 3)); //true
            Console.WriteLine(BST.Search(rootNode, 5)); //true
            Console.WriteLine(BST.Search(rootNode, 6)); //true
            Console.WriteLine(BST.Search(rootNode, 8)); //false
            Console.WriteLine(BST.Search(rootNode, 0)); //false
            Console.WriteLine(BST.Search(rootNode, -1)); //false
            Console.WriteLine(BST.Search(null, 4)); //false
        }
    }
}
