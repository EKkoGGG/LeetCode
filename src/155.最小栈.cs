/*
 * @lc app=leetcode.cn id=155 lang=csharp
 *
 * [155] 最小栈
 */

// @lc code=start
using System.Collections;
public class MinStack
{
    Stack<int> st;
    Stack<int> minSt;
    public MinStack()
    {
        st = new Stack<int>();
        minSt = new Stack<int>();
    }

    public void Push(int val)
    {
        st.Push(val);
        if (minSt.Count == 0)
        {
            minSt.Push(val);
        }
        else if (val <= minSt.Peek())
        {
            minSt.Push(val);
        }
        else
        {
            minSt.Push(minSt.Peek());
        }
    }

    public void Pop()
    {
        st.Pop();
        minSt.Pop();
    }

    public int Top()
    {
        return st.Peek();
    }

    public int GetMin()
    {
        return minSt.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

