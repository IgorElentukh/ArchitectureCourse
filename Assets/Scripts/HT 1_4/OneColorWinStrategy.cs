using System.Collections.Generic;
using UnityEngine;

public class OneColorWinStrategy : IWinStrategy
{
    private List<Ball> _whiteBalls = new List<Ball>();
    private List<Ball> _redBalls = new List<Ball>();
    private List<Ball> _greenBalls = new List<Ball>();

    public OneColorWinStrategy(List<Ball> whiteBalls, List<Ball> redBalls, List<Ball> greenBalls)
    {
        _whiteBalls = whiteBalls;
        _redBalls = redBalls;
        _greenBalls = greenBalls;
    }

    public void CheckWin()
    {
        if (_whiteBalls.Count <= 0)
            Debug.Log("Victory! You've popped up all white balls!");
        else if (_redBalls.Count <= 0)
            Debug.Log("Victory! You've popped up all red balls!");
        else if (_greenBalls.Count <= 0)
            Debug.Log("Victory! You've popped up all green balls!");
    }
}
