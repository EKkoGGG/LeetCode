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

    // 双指针
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return new int[2] { left + 1, right + 1 };
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return new int[2] { -1, -1 };
    }

    // 二分法
    public int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            var left = i + 1;
            var right = numbers.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (numbers[mid] == target - numbers[i])
                {
                    return new int[2] { i + 1, mid + 1 };
                }
                else if (numbers[mid] > target - numbers[i])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }
        return new int[2] { -1, -1 };
    }
}
// @lc code=end

