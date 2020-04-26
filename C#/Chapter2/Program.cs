using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter2.DeleteMiddleNode;
using static Chapter2.MyLinkedList<int>;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode nodeE = new ListNode('E');
            ListNode nodeD = new ListNode('D', nodeE);
            ListNode nodeC = new ListNode('C', nodeD);
            ListNode nodeB = new ListNode('B', nodeC);
            ListNode nodeA = new ListNode('A', nodeB);
            char result;

            ListNode node = nodeA;
            while (!ReferenceEquals(null, node))
            {
                result = node.data;
                node = node.next;
                Console.WriteLine(result);
            }

            DeleteMiddleNode.DeleteNode(nodeC);

            node = nodeA;
            while (!ReferenceEquals(null, node))
            {
                result = node.data;
                node = node.next;
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
