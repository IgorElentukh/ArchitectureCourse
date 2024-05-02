using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : ActivityState
{
    [SerializeField] private Places _homePlace;
    [SerializeField] private Places _workPlace;
    
    public MoveState(IStateSwitcher stateSwitcher, StateMachineData data, Player player) : base(stateSwitcher, data, player)
    {
        StateDuration = 4f;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("������");
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("������, �������!");
    }

    public override void Update()
    {
        float t = 0;
        float d = 0;

        while (t <= StateDuration)
        {
            Debug.Log("��� �� ������");
            t += Time.deltaTime;
            d = t / StateDuration;

            
        }
    }
}
