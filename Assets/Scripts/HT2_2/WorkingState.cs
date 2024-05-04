using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class WorkingState : ActivityState
    {
        public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, Player player) : base(stateSwitcher, data, player, 5)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Debug.Log("������� ��������");
        }

        public override void Exit()
        {
            base.Exit();

            Debug.Log("���� �����");
        }

        protected override void OnTimeEnded()
        {
            Data.TargetPosition = Player.HomePoint.position;
            StateSwitcher.SwitchState<MoveState>();
        }
    }
}
