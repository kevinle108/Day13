using System;
using System.Collections.Generic;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 3, 12, 25, 1, 8, 15, 2, 17 };
            int sum = 30;
            SubsetSum(myList, sum);
        }

        public static void SubsetSum(List<int> li, int sum)
        {
            var result = new Stack<int>();
            if ( SubsetSum(li, 0, sum, result))
            {
                //result.ForEach(num => Console.WriteLine(num));
                foreach (int num in result)
                {
                    Console.WriteLine(num);
                }
            }

        }

        public static bool SubsetSum(List<int> li, int index, int sum, Stack<int> result)
        {
            if (sum == 0)
            {
                return true;
            }
            for (int i = index; i < li.Count; i++)
            {
                if (li[i] <= sum)
                {
                    result.Push(li[i]);
                    if (SubsetSum(li, i + 1, sum - li[i], result)) return true;
                    result.Pop();
                }
                
            }
            return false;
        }
    }
}
