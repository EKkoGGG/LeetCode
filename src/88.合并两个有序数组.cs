/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int index = 0;
        bool isEnd = false;
        if(m == 0) isEnd = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = index; j < m; j++)
            {
                if (nums2[i] < nums1[j])
                {
                    for (int k = m - 1; k >= j; k--)
                    {
                        nums1[k + 1] = nums1[k];
                    }
                    nums1[j] = nums2[i];
                    index = j + 1;
                    m++;
                    break;
                }
                else if (j == (m - 1)) isEnd = true;
            }
            if (isEnd)
            {
                for (int l = m; l < nums1.Length; l++)
                {
                    nums1[l] = nums2[i];
                    i++;
                }
                break;
            }
        }
    }
}
// @lc code=end

