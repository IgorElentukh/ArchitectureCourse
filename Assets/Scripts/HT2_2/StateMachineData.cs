using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineData
{
    private float _speed;

    public float Speed 
    { 
        get => _speed; 
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(value));

            _speed = value;
        }
    }
}
