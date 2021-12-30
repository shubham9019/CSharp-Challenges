using System;
using System.Collections.Generic;

namespace LinkedListCycle
{
    internal class Program:LinkedL
    {
        static void Main(string[] args)
        {
            LinkedL noCycleLinkedList = new LinkedL();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            noCycleLinkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            Console.WriteLine(noCycleLinkedList.hasCycle());

            LinkedL cycleLinkedList = new LinkedL();
            cycleLinkedList.head = firstNode;
            thirdNode.next = secondNode;

            Console.WriteLine(cycleLinkedList.hasCycle());
        }
    }
}
