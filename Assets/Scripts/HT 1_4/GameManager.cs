using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private List<Ball> _allBalls = new List<Ball>();
    private List<Ball> _whiteBalls = new List<Ball>();
    private List<Ball> _redBalls = new List<Ball>();
    private List<Ball> _greenBalls = new List<Ball>();
    private int _strategyType;
    private IWinStrategy _strategy;

    public int Strategy { get => _strategyType; set => _strategyType = value; }

    private void Awake()
    {
        Ball[] _ballsInHierarchy = GameObject.FindObjectsOfType<Ball>();
        foreach (Ball _ball in _ballsInHierarchy)
        {
            _allBalls.Add(_ball);

            if(_ball.BallColor == BallColor.White)
                _whiteBalls.Add(_ball);
            else if (_ball.BallColor == BallColor.Red)
                _redBalls.Add(_ball);
            else if (_ball.BallColor == BallColor.Green)
                _greenBalls.Add(_ball);
        }
    }

    private void OnEnable()
    {
        Ball.OnBallDestroyed += CheckLists;
    }

    private void Start()
    {
        if (_strategyType == 1)
            _strategy = new AllBallsWinStrategy(_allBalls);

        if(_strategyType == 2)
            _strategy = new OneColorWinStrategy(_whiteBalls, _redBalls, _greenBalls);
    }

    private void Update()
    {
        _strategy.ToString();
    }

    private void CheckLists(Ball ball)
    {   
        if (ball.BallColor == BallColor.White)
        {
            _allBalls.Remove(ball);
            _whiteBalls.Remove(ball);
        }
        else if (ball.BallColor == BallColor.Red)
        {
            _allBalls.Remove(ball);
            _redBalls.Remove(ball);
        }
        else if(ball.BallColor == BallColor.Green)
        {
            _allBalls.Remove(ball);
            _greenBalls.Remove(ball);
        }

        _strategy.CheckWin();
    }

    private void OnDisable()
    {
        Ball.OnBallDestroyed -= CheckLists;
    }
}
