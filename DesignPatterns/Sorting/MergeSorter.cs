using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public class MergeSorter : ISorter
    {
        public int[] Sort(int[] array)
        {
            Console.WriteLine("Merger Sorter");
            return array;
        }
    }
}
