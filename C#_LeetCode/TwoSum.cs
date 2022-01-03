using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSum
    {
        public TwoSum()
        {

        }

        public void Print(int[] res) 
        {
            if (res is null
                || res.Length != 2)
            {
                Console.WriteLine("no result");
            }
            else
            {
                Console.WriteLine($"[{res[0]}, {res[1]}]");
            }
        }

        public int[] Sum(int[] nums, int target) 
        {
            int y = 0, pair_index = -1;
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++) 
            {
                y = target - nums[i];

                if (FindSumPair(nums, i, y, out pair_index)) 
                {
                    return new int[] { i + 1, pair_index + 1 };
                }
            }

            return null;
        }

        private bool FindSumPair(int[] nums, int avoid_index, int find_this_num, out int pair_index)
        {
            pair_index = -1;

            for (int i = 0; nums.Length > i; i++) 
            {
                if (i == avoid_index) continue;

                if (nums[i] == find_this_num) 
                {
                    pair_index = i;

                    return true;
                }
            }

            return false;
        }

        public int[] TwoSumAnswer(int[] numbers, int target)
        {
            int start = 0, end = numbers.Length - 1;

            while (start < end)
            {
                if (numbers[start] + numbers[end] == target) break;
                if (numbers[start] + numbers[end] < target) start++;
                else end--;
            }

            return new int[] { start + 1, end + 1 };
        }
    }
}
