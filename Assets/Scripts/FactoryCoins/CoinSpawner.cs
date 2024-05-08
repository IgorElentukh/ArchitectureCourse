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
        public void StartWork()
        {
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if (_spawn != null)
                StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                CoinType coinType = (CoinType)Random.Range(0, Enum.GetValues(typeof(CoinType)).Length);
                Coin coin = _coinFactory.GetCoin(coinType);
                coin.MoveTo(_spawnPoints);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }
    }
}
