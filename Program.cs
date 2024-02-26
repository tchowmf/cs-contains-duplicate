// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class program 
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var map = new Dictionary<int, int>();

            foreach(var num in nums){
                if(map.ContainsKey(num)) {
                    return true;
                }
                map[num] = 1;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            var solution = new Solution();
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12, 1};
            Console.WriteLine(solution.ContainsDuplicate(numbers));
        }
    }

}
