using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTSearch
{
    class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Data { get; set; }
    }
    internal class BST
    {
        public static Boolean Search(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }
            else if (value < root.Data)
            {
                return Search(root.Left, value);
            }
            else if (value > root.Data)
            {
                return Search(root.Right, value);
            }
            else
            {
                return true;
            }
        }
        public static Node Insert(Node root, int value)
        {
            if (root == null)
            {
                root = new Node();
                root.Data = value;
            }
            else if (value < root.Data)
            {
                root.Left = Insert(root.Left, value);
            }
            else if (value > root.Data)
            {
                root.Right = Insert(root.Right, value);
            }

            return root;
        }
    }
}
