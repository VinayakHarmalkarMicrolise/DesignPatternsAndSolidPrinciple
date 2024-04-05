using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public class QuickSorter : ISorter
    {
        public int[] Sort(int[] array)
        {
            Console.WriteLine("QuickSort");
            return array;
        }
    }
}
