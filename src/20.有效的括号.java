import java.util.Stack;

/*
 * @lc app=leetcode.cn id=20 lang=java
 *
 * [20] 有效的括号
 */

// @lc code=start
class Solution {
    public boolean isValid(String s) {
        Stack<Character> st = new Stack<>();
        for (int i = 0; i < s.length(); i++) {
            char item = s.charAt(i);
            if (st.isEmpty()){
                st.push(item);
                continue;
            }
            if (item == '(') {
                st.push(item);
            } else if (item == ')') {
                if (st.peek() == '(') {
                    st.pop();
                    continue;
                }
                return false;
            } else if (item == '[') {
                st.push(item);
            } else if (item == ']') {
                if (st.peek() == '[') {
                    st.pop();
                    continue;
                }
                return false;
            } else if (item == '{') {
                st.push(item);
            } else if (item == '}') {
                if (st.peek() == '{') {
                    st.pop();
                    continue;
                }
                return false;
            }
        }
        return st.isEmpty();
    }
}
// @lc code=end
