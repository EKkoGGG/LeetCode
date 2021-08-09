import java.util.ArrayList;
import java.util.List;

/*
 * @lc app=leetcode.cn id=66 lang=java
 *
 * [66] 加一
 */

// @lc code=start
class Solution {
    public int[] plusOne(int[] digits) {
        for (int i = digits.length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i] += 1;
                return digits;
            }
        }
        int[] res = new int[digits.length + 1];
        res[0] = 1;
        for (int j = 1; j < res.length; j++) {
            res[j] = 0;
        }
        return res;
    }
}
// @lc code=end

