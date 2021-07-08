/*
 * @lc app=leetcode.cn id=874 lang=csharp
 *
 * [874] 模拟行走机器人
 */

// @lc code=start
using System.Linq;
using System.Collections.Generic;
public class Solution
{
    public int RobotSim(int[] commands, int[][] obstacles)
    {
        int x = 0;
        int y = 0;
        // 0：+Y  
        // 1：+X
        // 2：-Y
        // 3：-X
        var direction = 0;
        var obstaclesList = GetObstacles(obstacles);
        var res = 0;
        foreach (var command in commands)
        {
            if (command == -1)
            {
                direction++;
                if (direction > 3)
                {
                    direction = 0;
                }
                continue;
            }
            if (command == -2)
            {
                direction--;
                if (direction < 0)
                {
                    direction = 3;
                }
                continue;
            }
            if (direction == 0)
            {
                for (int i = 0; i < command; i++)
                {
                    y++;
                    var pointStr = x.ToString() + y.ToString();
                    if (obstaclesList.Contains(pointStr))
                    {
                        y--;
                        break;
                    }
                }
                res = Math.Max(res,x*x+y*y);
                continue;
            }
            if (direction == 1)
            {
                for (int i = 0; i < command; i++)
                {
                    x++;
                    var pointStr = x.ToString() + y.ToString();
                    if (obstaclesList.Contains(pointStr))
                    {
                        x--;
                        break;
                    }
                }
                res = Math.Max(res,x*x+y*y);
                continue;
            }
            if (direction == 2)
            {
                for (int i = 0; i < command; i++)
                {
                    y--;
                    var pointStr = x.ToString() + y.ToString();
                    if (obstaclesList.Contains(pointStr))
                    {
                        y++;
                        break;
                    }
                }
                res = Math.Max(res,x*x+y*y);
                continue;
            }
            if (direction == 3)
            {
                for (int i = 0; i < command; i++)
                {
                    x--;
                    var pointStr = x.ToString() + y.ToString();
                    if (obstaclesList.Contains(pointStr))
                    {
                        x++;
                        break;
                    }
                }
                res = Math.Max(res,x*x+y*y);
                continue;
            }

        }
        return res;
    }

    public static List<string> GetObstacles(int[][] obstacles)
    {
        var list = new List<string>();
        foreach (var item in obstacles)
        {
            var addItem = item[0].ToString() + item[1].ToString();
            list.Add(addItem);
        }
        return list;
    }
}
// @lc code=end

