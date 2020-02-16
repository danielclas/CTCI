using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter2;

namespace Testing
{
    [TestClass]
    public class Chapter2
    {
        [TestMethod]
        public void tRemoveDups()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddNode(1);
            list.AddNode(4);
            list.AddNode(5);
            list.AddNode(16);
            list.AddNode(16);
            list.AddNode(4);
            list.AddNode(5);

            MyLinkedList<int> list2 = new MyLinkedList<int>();
            list2.AddNode(1);
            list2.AddNode(1);
            list2.AddNode(1);

            RemoveDups.RemoveDuplicates(list);
            RemoveDups.RemoveDuplicates(list2);

            Assert.IsTrue(list.Size == 4);
            Assert.IsTrue(list2.Size == 1);
        }

        [TestMethod]
        public void tKthToLast()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();

            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);

            Assert.IsTrue(2 == ReturnKthToLast.KthToLast(2, list));
            Assert.IsTrue(4 == ReturnKthToLast.KthToLast(0, list));
            Assert.IsTrue(1 == ReturnKthToLast.KthToLast(3, list));
        }

        [TestMethod]
        public void tPalindrome()
        {
            MyLinkedList<char> list = new MyLinkedList<char>();
            MyLinkedList<char> list2 = new MyLinkedList<char>();
            MyLinkedList<char> list3 = new MyLinkedList<char>();

            foreach (char c in "neuquen")
            {
                list.AddNode(c);
            }

            foreach (char c in "palindrome")
            {
                list2.AddNode(c);
            }

            foreach (char c in "BoquitaatiuqoB")
            {
                list3.AddNode(c);
            }

            Assert.IsTrue(Palindrome.IsPalindrome(list));
            Assert.IsFalse(Palindrome.IsPalindrome(list2));
            Assert.IsTrue(Palindrome.IsPalindrome(list3));
        }

        [TestMethod]
        public void tSumLists()
        {
            MyLinkedList<char> list1 = new MyLinkedList<char>();
            MyLinkedList<char> list2 = new MyLinkedList<char>();
            MyLinkedList<char> success = new MyLinkedList<char>();

            list1.AddNode('7');
            list1.AddNode('1');
            list1.AddNode('6');

            list2.AddNode('5');
            list2.AddNode('9');
            list2.AddNode('2');

            success.AddNode('2');
            success.AddNode('1');
            success.AddNode('9');

            Assert.IsTrue(SumLists.Sum(list1, list2).CompareList(success));
        }
    }
}
