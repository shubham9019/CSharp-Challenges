using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteK
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
            }
        }

        public void deleteKNode(int k)
        {
            if (head == null || k == 0)
            {
                return;
            }

            Node first = head;
            Node second = head;

            for (int i = 0; i < k; i++)
            {
                second = second.next;
                if (second.next == null)
                {
                    if (i == k - 1)
                    {
                        head = head.next;
                    }
                    return;
                }
            }

            while (second.next != null)
            {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;
        }

        public void print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data);
                if(current.next != null)
                {
                    Console.Write("->");
                }
                current = current.next;
            }
        }
    }
}
