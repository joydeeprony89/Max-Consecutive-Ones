using System;
using System.Linq;
using System.Net.Http.Headers;

namespace Max_Consecutive_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 0, 1, 1, 1 };
            Console.WriteLine("{0}", FindMaxConsecutiveOnes(nums));
            CompareLengthVsCount();
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int max = 0;
            foreach(int i in nums)
            {
                if(i == 1)
                {
                    count = count + 1;
                    max = count > max ? count : max;
                }
                else
                {
                    if (max >= nums.Count() / 2) return max;
                    count = 0;
                }
            }

            return max;
        }

        public static void CompareLengthVsCount()
        {
            int[] arr = new int[100000000];
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Count());
        }
    }
}
