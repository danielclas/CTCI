using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class MyStack<T>
    {
        private class StackNode<T>
        {
            public T data;
            public StackNode<T> next = null;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode<T> top;

        public bool IsEmpty()
        {
            return ReferenceEquals(top, null);
        }

        public T Peek()
        {
            return top.data;
        }

        public void Push(T data)
        {
            StackNode<T> t = new StackNode<T>(data);
            t.next = top;
            top = t;
        }

        public T Pop()
        {
            T data = top.data;
            top = top.next;
            return data;
        }
    }
}
