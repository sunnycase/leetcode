using System;
using System.Collections.Generic;

public partial class Solution
{
    public int[] TwoSum_Naive(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new[] { i, j };
            }
        }

        throw new ArgumentException();
    }

    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(target - nums[i], out var j))
                return new[] { j, i };
            else
                dic[nums[i]] = i;
        }

        throw new ArgumentException();
    }
}