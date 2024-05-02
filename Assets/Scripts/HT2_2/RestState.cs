using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestState : ActivityState
{
    public RestState(IStateSwitcher stateSwitcher, StateMachineData data, Player player) : base(stateSwitcher, data, player)
    {
        StateDuration = 8f;
        Place = new HomePlace();
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("Дом, милый дом");
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("Пора на работу");
    }
}
