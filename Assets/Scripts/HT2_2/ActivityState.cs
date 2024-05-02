using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;

    protected float StateDuration;
    protected Places Place;

    protected readonly Player Player;

    public ActivityState(IStateSwitcher stateSwitcher, StateMachineData data, Player player)
    {
        StateSwitcher = stateSwitcher;
        Player = player;
        Data = data;
    }

    public virtual void Enter()
    {
        Debug.Log(GetType());
    }

    public virtual void Exit()
    {
        
    }

    public void HandleInput()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Update()
    {
        float t = 0;
        
        while (t <= StateDuration)
        {
            Place.ActivityAtPlace();
            t += Time.deltaTime;
        }
        
        Exit();
    }
}
