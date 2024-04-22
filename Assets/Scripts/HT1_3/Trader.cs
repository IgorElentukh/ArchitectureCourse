using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader : MonoBehaviour
{
    private bool _canTrade;
    private ITrading _tradingOption;

    public bool CanTrade { get => _canTrade; private set => _canTrade = value; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            if (player.Tradable == true)
                _canTrade = true;
            else
                _canTrade = false;
        }
    }

    public void Trade(ITrading tradingOption)
    {
        if (_canTrade == true)
        {
            tradingOption.Trade();
        }
    }
}

