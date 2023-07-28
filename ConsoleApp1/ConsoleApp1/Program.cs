using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, 0, result, 0, nums1.Length);
            Array.Copy(nums2, 0, result, nums1.Length, nums2.Length);
            Array.Sort(result);
            int n = result.Length / 2;
            if (result.Length % 2 == 1) return result[n];
            return 0.5 * (result[n] + result[n - 1]);
        }

        static void Main(string[] args)
        {
            Solution sol = new Solution();

            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            double ans = sol.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(ans);  // must be 2

            nums1 = new int[] { 1, 2 };
            nums2 = new int[] { 3, 4 };
            ans = sol.FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine(ans);  // must be 2.5

        }
    }
}
