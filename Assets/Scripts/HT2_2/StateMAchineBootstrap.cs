using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
    public class StateMAchineBootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Transform _homePoint;
        [SerializeField] private Transform _workPoint;

        private void Awake()
        {
            _player.Initialize(_homePoint, _workPoint);
        }
    }
}
