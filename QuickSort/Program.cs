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
            List<int> listToSort = new List<int> { 1, 5, 2, 8, 6};
            //OutputList(listToSort);
            //OutputList(BubbleSort(listToSort));
            //FindPivotIndexes(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 8, 6, 7} });
            QuickSort(listToSort);
            Console.ReadLine();
        }

        static List<int> BubbleSort(List<int> list)
        {
            List<int> sortingList = list;
            int item1 = 0;
            int item2 = 0;

            for (int pass = 0; pass < sortingList.Count; pass++) // Number of passes
            {
                for (int comparison = 0; comparison < sortingList.Count - (pass + 1); comparison++)
                {
                    item1 = sortingList[comparison];
                    item2 = sortingList[comparison + 1];

                    if (item1 > item2)
                    {
                        sortingList[comparison] = item2;
                        sortingList[comparison + 1] = item1;
                    }

                }
            }

            return sortingList;
        }

        static void QuickSort(List<int> list)
        {
            List<int> sortingList = list;
            List<List<int>> sortingSublists = new List<List<int>>();
            List<int> pivotIndexes = new List<int>();
            List<int> sortedList = new List<int>(list.Count); // Insert list

            int pivotIndex = (int)Math.Ceiling((double)(sortingList.Count - 1) / 2);
            sortingSublists.Add(sortingList.GetRange(0, pivotIndex));
            sortingSublists.Add(sortingList.GetRange(pivotIndex + 1, sortingList.Count - (pivotIndex + 1)));

            OutputList(sortingSublists[0]);
            OutputList(sortingSublists[1]);
            
        }

        static List<int> FindPivotIndexes(List<List<int>> sublists) // works
        {
            List<int> pivotIndexes = new List<int>();

            foreach (List<int> sublist in sublists)
            {
                pivotIndexes.Add((int)Math.Ceiling((double)(sublist.Count - 1) / 2));
            }

            return pivotIndexes;
        }

        static void OutputList(List<int> list)
        {
            string lineToOutput = "";

            foreach (int item in list)
            {
                lineToOutput += item == list.Last() ? item.ToString() : item.ToString() + ", ";
            }

            Console.WriteLine(lineToOutput);
        }
    }
}
