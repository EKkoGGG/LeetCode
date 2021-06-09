/*
 * @lc app=leetcode.cn id=232 lang=csharp
 *
 * [232] 用栈实现队列
 */

// @lc code=start
using System.Collections;
using System.Linq;
public class MyQueue
{

    /** Initialize your data structure here. */
    private Stack<int> leftStack;
    private Stack<int> rightStack;
    public MyQueue()
    {
        leftStack = new Stack<int>();
        rightStack = new Stack<int>();
    }

    /** Push element x to the back of queue. */
    public void Push(int x)
    {
        if (!rightStack.Any())
        {
            leftStack.Push(x);
        }
        else
        {
            var length = rightStack.Count();
            for (int i = 0; i < length; i++)
            {
                leftStack.Push(rightStack.Pop());
            }
            leftStack.Push(x);
        }
    }

    /** Removes the element from in front of queue and returns that element. */
    public int Pop()
    {
        if (rightStack.Any())
        {
            return rightStack.Pop();
        }
        else
        {
            var length = leftStack.Count();
            for (int i = 0; i < length; i++)
            {
                rightStack.Push(leftStack.Pop());
            }
            return rightStack.Pop();
        }
    }

    /** Get the front element. */
    public int Peek()
    {
        if (rightStack.Any())
        {
            return rightStack.Peek();
        }
        else
        {
            var length = leftStack.Count();
            for (int i = 0; i < length; i++)
            {
                rightStack.Push(leftStack.Pop());
            }
            return rightStack.Peek();
        }
    }

    /** Returns whether the queue is empty. */
    public bool Empty()
    {
        return !leftStack.Any() && !rightStack.Any();
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

