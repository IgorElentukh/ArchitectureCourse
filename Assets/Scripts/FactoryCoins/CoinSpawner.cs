using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace FactoryCoins
{
    public class CoinSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private CoinFactory _coinFactory;

        private Coroutine _spawn;
        public List<Transform> _availablePoints;

        public void StartWork()
        {
            StopWork();
            _availablePoints = new List<Transform>(_spawnPoints);
            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        private Vector3 ChooseSpawnPoint()
        {
            Transform choosenPoint = _availablePoints[Random.Range(0, _availablePoints.Count)];
            _availablePoints.Remove(choosenPoint);

            if (_availablePoints.Count == 0)
                _availablePoints = _spawnPoints;

            return choosenPoint.position;
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                CoinType coinType = (CoinType)Random.Range(0, Enum.GetValues(typeof(CoinType)).Length);
                Coin coin = _coinFactory.GetCoin(coinType);
                coin.MoveTo(ChooseSpawnPoint());
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }
    }
}
