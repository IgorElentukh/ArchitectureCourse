using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class RestState : ActivityState
    {
        public RestState(IStateSwitcher stateSwitcher, StateMachineData data, Player player) : base(stateSwitcher, data, player, 8)
        {

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

        protected override void OnTimeEnded()
        {
            Data.TargetPosition = Player.WorkPoint.position;
            StateSwitcher.SwitchState<MoveState>();
        }
    }
}
