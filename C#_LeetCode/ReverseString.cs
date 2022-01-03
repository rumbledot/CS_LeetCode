using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseString
    {
        public ReverseString(char[] s)
        {
            int mid = (int)Math.Ceiling(s.Length / 2.0);
            int lastindex  = s.Length - 1;
            char swap = ' ';

            for (int i = 0; i < mid; i++) 
            {
                swap = s[i];
                s[i] = s[lastindex];
                s[lastindex] = swap;

                lastindex--;
            }

            Print(s);
        }

        public void ReverseWord(string w) 
        {
            string[] words = w.Split(' ');

            for (int j = 0; j < words.Length; j++)
            {
                char[] s = words[j].ToCharArray();

                int mid = (int)Math.Ceiling(s.Length / 2.0);
                int lastindex = s.Length - 1;
                char swap = ' ';

                for (int i = 0; i < mid; i++)
                {
                    swap = s[i];
                    s[i] = s[lastindex];
                    s[lastindex] = swap;

                    lastindex--;
                }

                Console.WriteLine(new string(s));
            }
        }

        private void Print(char[] s) 
        {
            Console.Write("\n[ ");
            for (int i = 0; i < s.Length; i++) 
            {
                Console.Write(s[i] + " ");
            }
            Console.Write("]");
        }
    }
}
