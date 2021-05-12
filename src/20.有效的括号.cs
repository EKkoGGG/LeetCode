/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
using System.Collections;
using System.Collections.Generic;
public class Solution
{
    public bool IsValid(string s)
    {
        var dic = new Dictionary<char, char>()
            {
                {'(',')'},
                {'[',']'},
                {'{','}'}
            };
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!stack.Any())
            {
                stack.Push(s[i]);
                continue;
            }
            if (dic.ContainsKey(stack.Peek()))
            {
                if (s[i] != dic[stack.Peek()]) stack.Push(s[i]);
                else stack.Pop();
            }
        }
        if (stack.Any())
        {
            return false;
        }
        return true;
    }
}
// @lc code=end

