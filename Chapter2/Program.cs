using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            list.AddNode(2);
            list.AddNode(4);
            list.AddNode(2);
            list.AddNode(4);
            list.AddNode(6);
            list.AddNode(8);

            Console.WriteLine("Size: "+list.Size);
            for (int i = 1; i <= list.Size; i++)
            {
                Console.WriteLine(list.GetData(i));
            }

            RemoveDups.RemoveDuplicates(list);
            Console.WriteLine("Size: " + list.Size);
            for (int i = 1; i <= list.Size; i++)
            {
                Console.WriteLine(list.GetData(i));
            }

            Console.ReadLine();
        }
    }
}
