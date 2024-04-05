using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public class HeapSorter : ISorter
    {
        public int[] Sort(int[] array)
        {
            Console.WriteLine("Heap Sort");
            return array; 
        }
    }
}
