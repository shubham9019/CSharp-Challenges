using System;

namespace DeleteK
{
    internal class Program:LinkedL
    {
        static void Main(string[] args)
        {
            LinkedL linkedList = new LinkedL();
            Node firstNode = new Node(1);
            Node secondNode = new Node(2);
            Node thirdNode = new Node(3);
            Node fourthNode = new Node(4);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            linkedList.print();
            linkedList.deleteKNode(2);
            Console.WriteLine();
            linkedList.print();
        }
    }
}
