using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;

        private void Awake()
        {
            _spawner.StartWork();
        }
    }
}
