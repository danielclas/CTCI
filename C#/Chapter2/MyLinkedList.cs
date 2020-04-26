using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public class MyLinkedList<T> where T : IComparable<T>
    {
        int size;
        Node head;

        public int Size { get { return size; } }
        public T this[int index]
        {
            get
            {
                return index > size ? default(T) : GetData(index);
            }
        }

        public MyLinkedList()
        {
            size = 0;
            head = null;
        }

        public bool AddNode(T data)
        {
            if (size == 0)
            {
                head = new Node(data);
            }
            else
            {
                Node n = GetNode(size);
                n.next = new Node(data);
            }

            size++;

            return true;
        }

        public bool AddNode(Node node)
        {
            if (size == 0)
            {
                head = node;
            }
            else
            {
                Node n = GetNode(size);
                n.next = node;
            }

            size++;

            return true;
        }

        public bool AppendList(MyLinkedList<T> list)
        {
            GetNode(size).next = list.head;
            size += list.Size;

            return true;
        }

        public bool RemoveNode(int index)
        {
            Node prev, next;

            if (index <= size && index >= 1)
            {
                if (index == 1)
                {
                    next = head.next;
                    head = next;
                }
                else if (index < size)
                {
                    prev = GetNode(index - 1);
                    next = GetNode(index + 1);
                    prev.next = next;
                }
                else
                {
                    prev = GetNode(index - 1);
                    prev.next = null;
                }
            }
            else
            {
                return false;
            }

            size--;

            return true;
        }

        public Node GetNode(int index)
        {
            Node n = null;

            if (index <= size && index > 0)
            {
                if (index == 1)
                {
                    n = head;
                }
                else
                {
                    n = head;
                    for (int i = 2; i <= size; i++)
                    {
                        n = n.next;
                        if (i == index)
                        {
                            break;
                        }
                    }
                }
            }

            return n;
        }

        public T GetData(int index)
        {
            if (index == 0 || index > size)
            {
                return default(T);
            }
            else
            {
                return GetNode(index).data;
            }
        }

        public bool CompareList(MyLinkedList<T> list)
        {
            bool equals = true;

            if (list.Size != size)
            {
                equals = false;
            }
            else
            {
                for (int i = 1; i <= Size; i++)
                {
                    if (list[i].CompareTo(this[i]) != 0)
                    {
                        equals = false;
                        break;
                    }
                }
            }

            return equals;
        }

        public int IndexOf(T data)
        {
            int index = -1;
            T nData;

            for (int i = 1; i <= size; i++)
            {
                nData = GetNode(i).data;
                if (nData.CompareTo(data) == 0)
                {
                    return i;
                }
            }

            return index;
        }

        public class Node
        {
            public Node next { get; set; }
            public T data { get; set; }

            public Node()
            {
                next = null;
            }

            public Node(T data)
            {
                this.data = data;
                next = null;
            }
        }
    }
}
