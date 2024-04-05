using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public class MainClass
    {
        public static void Main(string []args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };

            Console.WriteLine("Enter the sort \nQuick\nHeap\nMerge");
            switch (Console.ReadLine())
            {
                case "quick":
                    StratergySorter.setStratergy(new QuickSorter());
                    break;

                case "heap":
                    StratergySorter.setStratergy(new HeapSorter());
                    break;

                case "merge":
                    StratergySorter.setStratergy(new MergeSorter());
                    break;
            }

            StratergySorter.sort(array);
        }
    }
}
