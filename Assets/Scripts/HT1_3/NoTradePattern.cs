using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTradePattern : ITrading
{
    public void Trade()
    {
       Debug.Log("Проходи мимо, нищий!");
    }
}
