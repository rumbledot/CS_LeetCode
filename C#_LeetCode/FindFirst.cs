using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindFirst
    {
        public int index { get; private set; }

        public FindFirst(int n, int[] nums)
        {
            int left = 1, right = nums.Length;
            int mid = 0;

            while (left <= right) 
            {
                mid = left + (right - left) / 2;
                if (nums[mid] == n)
                {
                    index = mid;
                    right = mid - 1;
                }
                else 
                {
                    left = mid + 1;
                }
            }
        }

        public int SearchInsert(int[] nums, int target)
        {
            int start = 0, end = nums.Length;
            int mid = 0;

            while (start <= end)
            { 
                mid = (start + end) / 2;

                if (nums[mid] == target) return mid;

                else if (nums[mid] > target) end = mid - 1;

                else start = mid + 1;

            }

            return start;
        }

        public void Rotate(int[] nums, int k)
        {
            int size = nums.Length;
            k = k % size;

            if (k == 0)
            {
                return;
            }

            Reverse(nums, 0, size - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, size - 1);
        }

        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                nums[start] = nums[start] + nums[end];
                nums[end] = nums[start] - nums[end];
                nums[start] = nums[start] - nums[end];

                start++;
                end--;
            }
        }

        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                }
            }
        }
    }
}
