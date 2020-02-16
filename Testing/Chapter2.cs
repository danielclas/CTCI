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
    }
}
