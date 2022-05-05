using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.Utility
{
    public class BubbleSort
    {
        public void Sort(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 1; j < array[i].Length; j++)
                {
                    if (array[j-1].CompareTo(array[j])>0)
                    {
                        var temp = array[j];
                        array[j] = array[j-1];
                        array[j-1] = temp;
                    }
                }
            }
            foreach(var data in array)
            {
                Console.WriteLine("\t {0}",array);
            }
        }
    }
}
