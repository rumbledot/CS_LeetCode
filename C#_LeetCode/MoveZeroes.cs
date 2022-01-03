using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MoveZeroes
    {
        public MoveZeroes(int[] nums)
        {
            Print(nums);

            if (nums.Length <= 1) return;

            if (nums.Length == 2 && nums[nums.Length - 1] == 0) return;

            int smallest = int.MaxValue;
            int lastindex = nums.Length - 1;
            int counter = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == 0) counter++;
            }

            if (counter == 1 && nums[lastindex] == 0) return;

            while (counter > 0) 
            {
                for (int i = 0; i < lastindex; i++) 
                {
                    Console.WriteLine("\n index " + i + " " + nums[i]);
                    if (nums[i] == 0) 
                    {
                        smallest = nums[i];

                        for (int j = i + 1; j < nums.Length; j++)
                        {
                            nums[j - 1] = nums[j];
                            Print(nums);
                        }

                        nums[lastindex] = smallest;

                        Print(nums);
                        Console.WriteLine("\n---");

                        counter--;
                        break;
                    }
                }
            }
        }

        public void MoveZeroesAnswer(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;

            int insertPos = 0;
            foreach (int num in nums)
            {
                if (num != 0) nums[insertPos++] = num;
            }

            while (insertPos < nums.Length)
            {
                nums[insertPos++] = 0;
            }
        }

        public void Print(int[] nums) 
        {
            Console.Write("\nResult [ ");
            for (int i = 0; i < nums.Length; i++) 
            {
                Console.Write(nums[i] + " ");
            }
            Console.Write("]");
        }
    }
}
