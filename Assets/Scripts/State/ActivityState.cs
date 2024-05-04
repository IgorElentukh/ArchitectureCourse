using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public abstract class ActivityState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly StateMachineData Data;

        private float StateDuration;
        protected Places Place;

        protected readonly Player Player;

        private float t = 0;

        public ActivityState(IStateSwitcher stateSwitcher, StateMachineData data, Player player, float stateDuration)
        {
            StateSwitcher = stateSwitcher;
            Player = player;
            Data = data;
            StateDuration = stateDuration;
        }

        public virtual void Enter()
        {
            Debug.Log(GetType());
            t = 0;
        }

        public virtual void Exit()
        {

        }


        public virtual void Update()
        {
            t += Time.deltaTime;
            if (t>= StateDuration)
            OnTimeEnded();
        }

        protected abstract void OnTimeEnded();
    }
}
