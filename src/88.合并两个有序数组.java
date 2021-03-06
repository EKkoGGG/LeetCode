/*
 * @lc app=leetcode.cn id=88 lang=java
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1;
        int p2 = n - 1;
        int tail = m + n - 1;
        int cur;
        while (p1 >= 0 || p2 >= 0)
        {
            if (p1 < 0)
            {
                cur = nums2[p2];
                p2--;
            }
            else if (p2 < 0)
            {
                cur = nums1[p1];
                p1--;
            }
            else if (nums1[p1] > nums2[p2])
            {
                cur = nums1[p1];
                p1--;
            }
            else
            {
                cur = nums2[p2];
                p2--;
            }
            nums1[tail] = cur;
            tail--;
        }
    }
}
// @lc code=end

