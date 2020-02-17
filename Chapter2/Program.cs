using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter2.MyLinkedList<int>;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<char> list = new MyLinkedList<char>();

            MyLinkedList<char>.Node repeatedNode = new MyLinkedList<char>.Node('C');

            MyLinkedList<char>.Node node = new MyLinkedList<char>.Node('A');
            list.AddNode(node);
            node = new MyLinkedList<char>.Node('B');
            list.AddNode(node);
            list.AddNode(repeatedNode);
            node = new MyLinkedList<char>.Node('D');
            list.AddNode(node);
            node = new MyLinkedList<char>.Node('E');
            list.AddNode(node);

            list.AddNode(repeatedNode);

            LoopDetection.Detect(list);

            Console.ReadLine();
        }
    }
}
