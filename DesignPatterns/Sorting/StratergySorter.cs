using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public class StratergySorter
    {
        public static ISorter sortingStratergy; 

        public static void setStratergy(ISorter sStratergy)
        {
            sortingStratergy = sStratergy;
        }

        public static void sort(int[] array) 
        {
            sortingStratergy.Sort(array);    
        }
    }
}
