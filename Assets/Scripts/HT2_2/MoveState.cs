using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class MoveState : IState
    {
        private IStateSwitcher _stateSwitcher;
        private StateMachineData _data;
        private Player _player;
        private float _speed;

        public MoveState(IStateSwitcher stateSwitcher, StateMachineData data, Player player)
        {
            _stateSwitcher = stateSwitcher;
            _data = data;
            _player = player;
            _speed = _data.Speed;
        }

        public  void Enter()
        {
            Debug.Log("Выхожу");
            _speed = 0.5f;
        }

        public  void Exit()
        { 
            _speed = 0f;
        }

        public void Update()
        {
            Vector3 direction = _data.TargetPosition - _player.transform.position;
            _player.transform.Translate(direction * _speed * Time.deltaTime);

            if (direction.sqrMagnitude < 1f)
            {
                if (_data.TargetPosition == _player.WorkPoint.position)
                    _stateSwitcher.SwitchState<WorkingState>();
                else if (_data.TargetPosition == _player.HomePoint.position)
                    _stateSwitcher.SwitchState<RestState>();
            }
                
        }
    }
}
