using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> temp = new Stack<int>();

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            stack2.Push(4);
            stack2.Push(5);
            stack2.Push(6);

            stack1.Concat(stack2);

            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }
            /*
             1-2-3
             4-5-6

             */

            Console.ReadLine();
        }
    }
}
