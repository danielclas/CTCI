using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    public class StackOfPlates<T>
    {
        /*
            Imagine a (literal) stack of plates. If the stack gets too high, it might topple.
            Therefore, in real life, we would likely start a new stack when the previous stack exceeds some
            threshold. Implement a data structure SetOfStacks that mimics this. SetOfStacks should be
            composed of several stacks and should create a new stack once the previous one exceeds capacity.
            SetOfStacks. push () and SetOfStacks. pop () should behave identically to a single stack
            (that is, pop ( ) should return the same values as it would if there were just a single stack).
            FOLLOW UP
            Implement a function popAt (int index) which performs a pop operation on a specific sub-stack. 
         */

        List<Stack<T>> stacks;
        private int threshold = 5;

        public StackOfPlates()
        {
            stacks = new List<Stack<T>>();
            stacks.Add(new Stack<T>());
        }

        public void Push(T item)
        {
            Stack<T> stack = null;
            
            foreach(var st in stacks)
            {
                if (st.Count < threshold)
                {
                    stack = st;
                    break;
                }
            }

            if (ReferenceEquals(stack,null))
            {
                stack = new Stack<T>();
                stacks.Add(stack);
            }

            stack.Push(item);
        }

        public T Pop()
        {
            T item = default(T);

            foreach (var stack in stacks)
            {
                if (stack.Count != 0)
                {
                    item = stack.Pop();
                    break;
                }
            }

            return item;
        }

        private void Rearrange()
        {
            for (int i = 0; i < stacks.Count-1; i++)
            {
                while(stacks[i].Count < 5 && stacks[i+1].Count != 0)
                {
                    stacks[i].Push(stacks[i + 1].Pop());
                }
            }
        }


    }
}
