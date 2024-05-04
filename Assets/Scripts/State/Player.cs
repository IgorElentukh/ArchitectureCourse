using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StatePattern
{
    public class Player : MonoBehaviour
    {
        private PlayerStateMachine _stateMachine;

        public void Initialize(Transform homePoint, Transform workPoint)
        {
            HomePoint = homePoint;
            WorkPoint = workPoint;
            
            _stateMachine = new PlayerStateMachine(this);
           
        }

        public Transform HomePoint { get; private set; }
        public Transform WorkPoint { get; private set; }

        private void Update()
        {
            _stateMachine.Update();
        }
    }
}

