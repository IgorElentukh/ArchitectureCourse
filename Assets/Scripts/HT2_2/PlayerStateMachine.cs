using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StatePattern
{
    public class PlayerStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public IState PreviousState { get; private set; }

        public PlayerStateMachine(Player player)
        {
            StateMachineData _data = new StateMachineData();
            _states = new List<IState>()
            {
            new RestState(this, _data, player),
            new WorkingState(this, _data, player),
            new MoveState(this, _data, player),

            };
            _currentState = _states[0];
            _currentState.Enter();
        }

        public void SwitchState<T>() where T : IState
        {
            IState state = _states.FirstOrDefault(state => state is T);
            _currentState.Exit();
            PreviousState = _currentState;
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}
