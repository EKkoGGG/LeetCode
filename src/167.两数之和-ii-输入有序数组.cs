/*
 * @lc app=leetcode.cn id=167 lang=csharp
 *
 * [167] 两数之和 II - 输入有序数组
 */

// @lc code=start
public class Solution
{
    // 暴力
    public int[] TwoSum(int[] numbers, int target)
    {
        var a1 = 0;
        var a2 = 0;
        var length = numbers.Length;
        for (int i = a1; i < length; i++)
        {
            a2 = i + 1;
            for (int j = a2; j < length; j++)
            {
                if (target - numbers[i] > numbers[j])
                {
                    continue;
                }
                else if (numbers[i] + numbers[j] == target)
                {
                    a1 = i;
                    a2 = j;
                    i = length;
                    break;
                }
                else
                {
                    break;
                }
            }
        }
        return new int[2] { a1 + 1, a2 + 1 };
    }
}
// @lc code=end

