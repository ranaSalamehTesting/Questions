﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstQuestion
{
    class SearchForTargetDemo : SearchForTarget
    {
        static void Main(string[] args)
        {
            //Test Case 1
            int[] nums1 = { 2, 7, 11, 15 };
            var targets1 = 9;
            SearchForTarget searchForTarget = new SearchForTarget();

            int[] result1 = searchForTarget.GetTwoSumEqualTarget(nums1, targets1);
            Console.WriteLine($"the indeces of the firts num is: {result1[0]} and the second is: {result1[1]}");

            //Test Case 2
            int[] nums2 = { 3, 2, 4 };
            var targets2 = 6;
            int[] result2 = searchForTarget.GetTwoSumEqualTarget(nums2, targets2);
            Console.WriteLine($"the indeces of the firts num is: {result2[0]} and the second is: {result2[1]}");

            //Test Case 3
            int[] nums3 = { 3, 3 };
            var targets3 = 6;
            int[] result3 = searchForTarget.GetTwoSumEqualTarget(nums3, targets3);
            Console.WriteLine($"the indeces of the firts num is: {result3[0]} and the second is: {result3[1]}");
            
            //Test Case 4
            int[] nums4 = {1,1,1,1,1,1,1,7,1,1,1,1,1};
            var targets4 = 6;
            int[] result4 = searchForTarget.GetTwoSumEqualTarget(nums4, targets4);
            Console.WriteLine($"the indeces of the firts num is: {result4[0]} and the second is: {result4[1]}");

        }
    }
}
