/*
 * @lc app=leetcode.cn id=1 lang=java
 *
 * [1] 两数之和
 */

// @lc code=start
class Solution {
    // 暴力
    public int[] twoSum(int[] nums, int target) {
        var n = nums.length;
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        return new int[2];
    }
    // 哈希
    public int[] twoSum(int[] nums, int target) {
        var hm = new HashMap<Integer, Integer>();
        for (int i = 0; i < nums.length; i++) {
            if (hm.containsKey(target - nums[i])) {
                return new int[]{i,hm.get(target - nums[i])};
            }else{
                hm.put(nums[i],i);
            }
        }
        return new int[2];
    }
}
// @lc code=end
