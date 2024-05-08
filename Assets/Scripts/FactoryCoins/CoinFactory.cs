using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryCoins
{
    public class CoinFactory : MonoBehaviour
    {
        [SerializeField] private Coin _emptyCoin, _standardCoin, _randomCoin;

        public Coin GetCoin(CoinType coinType)
        {
            switch (coinType)
            {
                case CoinType.Empty:
                    return Instantiate(_emptyCoin);

                case CoinType.Standard:
                    return Instantiate(_standardCoin);

                case CoinType.Random:
                    return Instantiate(_randomCoin);

                default:
                    throw new ArgumentException(nameof(coinType));
            }
        }
    }
}
