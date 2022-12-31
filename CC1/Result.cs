using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC1
{
    public class Result
    {
        public static int[]? ValidateAndCleanNums(int[] nums, int target)
        {
            if(nums == null) { return null; };
            if (nums.Length < 2 || nums.Length > 104 || target < -109 || target > 109)
            {
                return null;
            }
            return nums.Where(x => x <= target & x <= 109).ToArray();
        }
        public static int[]? FindAddTarget(int[] nums, int target)
        {
            int[]? cleanArray = ValidateAndCleanNums(nums,target);
            if (cleanArray == null)
            {
                return null;
            }

            /*
            var result = (from i in cleanArray
                        from j in cleanArray
                        where i + j == target && i!= j 
                        select new { i, j }
                        ).FirstOrDefault();
            */

            var sizeArray = cleanArray.Length;

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = i + 1; j < sizeArray; j++)
                {
                    if (cleanArray[i] + cleanArray[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { 0, 0 };

        }
    }
}
