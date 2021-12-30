using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    internal class LinkedL
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public Boolean hasCycle()
        {
            HashSet<Node> nodes = new HashSet<Node>();
            Node current = head;
            while (current != null)
            {
                if (nodes.Contains(current))
                {
                    return true;
                }
                else
                {
                    nodes.Add(current);
                }

                current = current.next;
            }
            return false;
        }
    }
}
