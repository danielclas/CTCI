using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class MyQueue<T>
    {
        private class QueueNode<T>
        {
            public T data;
            public QueueNode<T> next = null;

            public QueueNode(T data)
            {
                this.data = data;
            }
        }

        private QueueNode<T> first = null;
        private QueueNode<T> last = null;

        public void Add(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);
            if (!ReferenceEquals(null, last))
            {
                last.next = t;
            }

            last = t;
            if (ReferenceEquals(null, first))
            {
                first = last;
            }
        }

        public bool IsEmpty()
        {
            return ReferenceEquals(first, null);
        }

        public T Remove()
        {
            T data = first.data;
            first = first.next;

            if (ReferenceEquals(first, null))
            {
                last = null;
            }

            return data;
        }

        public T Peek()
        {
            return first.data;
        }
    }
}
