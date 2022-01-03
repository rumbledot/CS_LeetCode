using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            char[] s1 = { 's', 'a', 'v', 'n', 'o', 'y' };

            ReverseString rs = new ReverseString(s1);

            rs.ReverseWord("Let's take LeetCode contest");
            rs.ReverseWord("God Ding");


            Console.ReadLine();
        }
    }
}
