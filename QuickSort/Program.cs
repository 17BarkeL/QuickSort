using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort(new List<int>{1, 5, 2, 8, 6});

            Console.ReadLine();
        }

        /*List<int> QuickSort(List<int> listToSort)
        {
            
        }*/

        static void BubbleSort(List<int> listToSort)
        {
            int item1 = 0;
            int item2 = 0;

            for (int pass = 0; pass < listToSort.Count; pass++) // Number of passes
            {
                Console.WriteLine("--------");

                for (int comparison = 0; comparison < listToSort.Count - pass; comparison++)
                {
                    item1 = listToSort[comparison];
                    item2 = listToSort[(comparison + 1, listToSort.Count)];

                    Console.WriteLine(item1 + ", " + item2);
                }
            }
        }
    }
}
