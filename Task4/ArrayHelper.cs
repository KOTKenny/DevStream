using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class ArrayHelper
    {
        public static IEnumerable<int> MissingElements(int[] arr)
        {
            var newList = new List<int>();

            if(arr.Length <= 1)
                return newList;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 < arr[i + 1])
                    newList.AddRange(arr[i] + 1, arr[i + 1] - 1);
            }

            return newList;
        }

        private static void AddRange(this List<int> list, int current, int next)
        {
            for (int i = current; i <= next; i++)
                list.Add(i);
        }
    }
}
