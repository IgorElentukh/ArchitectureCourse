using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ITradable
{
    [SerializeField, Range(0, 50)] private int _experience;

    public bool Tradable => true;
    public int Experience { get => _experience; private set => _experience = value; }

    
}
