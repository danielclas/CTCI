using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> toSort = new List<int>() { 100,500,-400,5,10,1,0,50,7};

            Console.WriteLine("Unsorted: \n");
            toSort.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("Sorted: \n");
            toSort = MergeSort.Sort(toSort);
            toSort.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
