using System.Collections.Generic;
using UnityEngine;

public class AllBallsWinStrategy : IWinStrategy
{
    private List<Ball> _allBalls = new List<Ball>();

    public AllBallsWinStrategy(List<Ball> allBalls)
    {
        _allBalls = allBalls;
    }

    public void CheckWin()
    {
        if (_allBalls.Count > 0)
            return;
        else
            Debug.Log("Victory! You've popped up all balls!");
    }
}
