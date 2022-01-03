using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SquareRoot
    {
        public SquareRoot()
        {

        }

        public bool PerfectSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }

        public int NearestRoot(int n) 
        {
            if (n <= 0) return 1;

            return Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
        }

        public int NumberOfSquares(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            List<int> num_squares = new List<int>();
            int m = num_squares.Count;
            int counter = int.MaxValue;

            // While cntPerfectSquares.size() <= n, we need to incrementally 
            // calculate the next result until we get the result for n.
            while (num_squares.Count <= n)
            {
                m = num_squares.Count;
                counter = int.MaxValue;
                for (int i = 1; i * i <= m; i++)
                {
                    counter = Math.Min(counter, num_squares[m - i * i] + 1);
                }

                num_squares.Add(counter);
            }

            return num_squares[n];
        }

        public int[] SortedSquares(int[] nums)
        {
            List<int> squared = new List<int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                squared.Add(nums[i] * nums[i]);
            }

            return squared.OrderBy(x => x).ToArray();
        }
    }
}
