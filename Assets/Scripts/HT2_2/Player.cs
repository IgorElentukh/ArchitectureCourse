using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public class Player : MonoBehaviour
    {
        private PlayerStateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine = new PlayerStateMachine();
        }

        private void Update()
        {
            _stateMachine.HandleInput();
            _stateMachine.Update();
        }
    }
}
