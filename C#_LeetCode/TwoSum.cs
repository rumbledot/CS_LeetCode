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
            List<int> list = nums.ToList();
            int y = 0;
            int[] result = new int[2];

            foreach (int num in list)
            {
                y = target - num;

                if (list.Contains(y)) 
                {
                    if (list.IndexOf(num) == list.IndexOf(y)) continue;

                    result[0] = list.IndexOf(num);
                    result[1] = list.IndexOf(y);

                    return result;
                }
            }

            return null;
        }
    }
}
