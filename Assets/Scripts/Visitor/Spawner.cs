using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Visitor
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private EnemyFactory _enemyFactory;
        [SerializeField] private Accountant _accountant;

        private Coroutine _spawn;

        private void OnEnable()
        {
            _accountant.OnMassExceed += StopWork;
        }
        public void StartWork()
        {
            StopWork();
            _spawn = StartCoroutine(Spawn());
        }

        private void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                enemy.MoveTo(_spawnPoints[(Random.Range(0, _spawnPoints.Count))].position);
                _accountant.SpawnedEnemies.Add(enemy);
                enemy.OnDied += _accountant.OnEnemyDied;
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private void OnDisable()
        {
            _accountant.OnMassExceed -= StopWork;
        }
    }
}
