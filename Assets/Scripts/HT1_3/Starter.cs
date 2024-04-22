using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private Trader _trader;
    [SerializeField] private Player _player;

    private void Update()
    {
        if (_trader.CanTrade == true)
        {
            if (_player.Experience < 10)
                _trader.Trade(new NoTradePattern());
            else if (_player.Experience >= 10 && _player.Experience < 30)
                _trader.Trade(new FruitsTrade());
            else if (_player.Experience >= 30)
                _trader.Trade(new ArmorTrading());
        }

    }

}
