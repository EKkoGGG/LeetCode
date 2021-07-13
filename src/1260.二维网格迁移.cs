/*
 * @lc app=leetcode.cn id=1260 lang=csharp
 *
 * [1260] 二维网格迁移
 */

// @lc code=start
using System.Linq;
using System.Collections.Generic;
public class Solution
{
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        if (k == 0)
        {
            return grid;
        }
        var gridList = new List<int>();
        var res = new List<List<int>>();
        foreach (var gridItem in grid)
        {
            foreach (var item in gridItem)
            {
                gridList.Add(item);
            }
        }
        var startIndex = gridList.Count - k;
        bool finish = false;
        var tempList = new List<int>();
        var listCount = grid[0].Length;
        for (int i = startIndex; i < gridList.Count; i++)
        {
            tempList.Add(gridList[i]);
            if (tempList.Count == listCount)
            {
                res.Add(tempList);
                
            }
            if (i == gridList.Count - 1 && finish == false)
            {
                i = 0;
                finish = true;
            }
        }
        return res;
    }
}
// @lc code=end

