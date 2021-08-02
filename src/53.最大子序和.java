/*
 * @lc app=leetcode.cn id=53 lang=java
 *
 * [53] 最大子序和
 */

// @lc code=start
class Solution {

    // 贪心
    public int maxSubArray(int[] nums) {
        int sum = 0;
        int maxVal = nums[0];
        for (int item : nums) {
            sum = Math.max(item, sum + item);
            maxVal = Math.max(maxVal, sum);
        }
        return maxVal;
    }
}
// @lc code=end

