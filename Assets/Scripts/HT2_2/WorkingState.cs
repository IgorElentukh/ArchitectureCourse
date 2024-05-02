using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkingState : ActivityState
{
    public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, Player player) : base(stateSwitcher, data, player)
    {
        StateDuration = 8f;
        Place = new WorkPlace();
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Начинаю работать");
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("Пора домой");
    }

}
